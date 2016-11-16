using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Threading;
using System.IO;
using System.Collections;
using demo1;
using Microsoft.VisualBasic.FileIO;


namespace UI
{
    public partial class MainForm :CCSkinMain
    {
        public static int tot = 0; //图片数
        public static bool[] selected; //每幅图片是否选择
        public static string[] name; //图片名字
        public static string[] name_copy; //用于图片排序后展示的图片路径
        public static string[] path_name; //图片路径，记录第i张图片的地址
        public static string[] path_name_copy; //用于图片排序后展示的图片地址
        public static bool[] state; //图片状态
        public static int progress; //排序进度
        public static int clear_ratio = 50; //图片清理率，也就是清除图片评分后百分之几的图片（现在假设已经排好序）
        public static int COMPRESS_SELECTED;

        TreeViewEventArgs ee; //用于右侧目录树缩略图加载函数loadjiedian中获取treeview控件
        string tag = "True"; //Tag标签，用于检测被check的结点（每个被check的结点的tag属性被设置为true）
        TreeNode rootNode; //用于设置目录树根节点（我的电脑）
        bool load = false; //用于控制鼠标状态是旋转圆圈（图片排序时）还是默认状态
        bool select_all = false; //是否全选
        Color unselected_color = Color.FromArgb(128, 208, 255); //图片未选择时背景颜色
        Color selected_color = Color.FromArgb(92, 199, 249); //图片选择时背景颜色

        EventHandler e1; //点击单元格panel改变选择状态的事件
        EventHandler e2; //点击单元格panel改变选择状态的事件
        EventHandler e3; //点击单元格panel改变选择状态的事件

        //主窗口初始化变量
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            selected = new bool[10000];
            state = new bool[10000];
            name = new string[10000];
            name_copy = new string[10000];
            path_name = new string[10000];
            path_name_copy = new string[10000];
            for(int i=0;i<10000;i++)
            {
                selected[i] = false;
                state[i] = false;
            }
            e1 = new EventHandler(item_click);
            e2 = new EventHandler(pictureBox_click);
            e3 = new EventHandler(label_click);
        }

        //窗口加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载目录树
            directoryTree();

            //用于显示加载时的旋转圆圈
            Thread threadLoading = new Thread(ThreadLoading);
            threadLoading.IsBackground = true;
            threadLoading.Start();
           
        }

        //左侧结果显示控件被双击后弹出图片浏览界面
        private void result_show_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form imageshow = new ImageView();
            imageshow.Size = new Size(this.Width, this.Height);
            imageshow.Show();

        }

        //线程控制鼠标状态是旋转圆圈（图片排序时，load=true时）还是默认状态---
        private void ThreadLoading()
        {
            while (true)
            {
                if (load)
                {
                    this.Cursor = Cursors.WaitCursor;
                }
                else
                {
                    this.Cursor=Cursors.Default;
                }
            }
        }
        
        //主界面窗口变化事件，相应的调整控件位置及大小
        private void MainForm_Resize(object sender, EventArgs e) 
        {

            int width;
            int height;
            Point temp;
            //控制左侧图片显示框位置及大小
            {
                temp = this.imageCompare.Location;
                width = this.imageCompare.Width;
                height = this.imageCompare.Height;
                this.imageSortPanel.Location = new Point(temp.X, 0);
                this.imageSortPanel.Width = width;

                temp = this.imageCompress.Location;
                width = this.imageCompress.Width;
                height = this.imageCompress.Height;
                this.imageComparePanel.Location = new Point(temp.X, 0);
                this.imageComparePanel.Width = width;

                temp = this.imageClear.Location;
                width = this.imageClear.Width;
                height = this.imageClear.Height;
                this.imageCompressPanel.Location = new Point(temp.X, 0);
                this.imageCompressPanel.Width = width;

                temp = this.imageSort.Location;
                width = this.imageSort.Width;
                height = this.imageSort.Height;
                this.imageClearPanel.Location = new Point(temp.X, 0);
                this.imageClearPanel.Width = width;
            }
        }
        
        //生成目录树，根节点是"我的电脑",几个直接子节点是相应盘
        private void directoryTree()
        {
            rootNode = new TreeNode("我的电脑", IconIndexes.MyComputer, IconIndexes.MyComputer);  //载入显示 
            rootNode.Text = "我的电脑";                           //树节点标签内容
            rootNode.Name = "我的电脑";                         //结点name用于记录结点所在路径
            this.treeView1.Nodes.Add(rootNode);               //树中添加根目录

            //为根节点"我的电脑"添加几个子节点--相应盘
            foreach (string drive in Environment.GetLogicalDrives())
            {
                //实例化DriveInfo对象 命名空间System.IO
                var dir = new DriveInfo(drive);
                switch (dir.DriveType)           //判断驱动器类型
                {
                    case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 
                        {

                            TreeNode tNode = new TreeNode(dir.Name.Split(':')[0]);//Split仅获取盘符字母
                            tNode.Name = dir.Name;
                            tNode.ImageIndex = IconIndexes.FixedDrive;         //获取结点显示图片
                            tNode.SelectedImageIndex = IconIndexes.FixedDrive; //选择显示图片
                            rootNode.Nodes.Add(tNode);                    //加载驱动节点
                            tNode.Nodes.Add("");                //给该盘结点添加一个空结点以便显示一个+号表示可以展开盘

                        }
                        break;
                }
            }
            rootNode.Expand();                  //展开我的电脑
            
        }

        private void imageClear_none_Click(object sender, EventArgs e)
        {
            resetClearPanel();
            ClearSetting cs = new ClearSetting(this);
            cs.Show();
        }

        //图片清理面板
        private void imageClear_Click(object sender, EventArgs e)
        {
            resetClearPanel();
        }

        //图片比较面板
        private void imageCompare_Click(object sender, EventArgs e)
        {
            resetComparePanel();
        }

        //图片排序面板
        private void imageSort_Click(object sender, EventArgs e)
        {
            resetSortPanel();
        }

        //图片压缩面板
        private void imageCompress_Click(object sender, EventArgs e)
        {
            resetCompressPanel();
        }

        //用户设置面板
        private void personalSetting_Click(object sender, EventArgs e)
        {
            imageClearPanel.Visible = false;
            imageComparePanel.Visible = false;
            imageSortPanel.Visible = false;
            imageCompressPanel.Visible = false;
        }

        private void pictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //转换成PictureBox   
            PictureBox pi = (PictureBox)sender;
            //图片加载完成后，将光标恢复  
            pi.UseWaitCursor = false;

        }  

        //点击图片改变选择状态
        private void item_click(object sender, EventArgs e)
        {
            Panel p=(Panel)sender;
            int id = int.Parse(p.Name);
            selected[id] = !selected[id];
            if (p.BackColor == unselected_color)
            {
                p.BackColor = selected_color;
                selected[id] = true;
            }
            else
            {
                p.BackColor = unselected_color;
                selected[id] = false;
            }
        }

        //点击图片改变选择状态
        private void pictureBox_click(object sender, EventArgs e)
        {
            Panel p = (Panel)(((PictureBox)sender).Parent);
            int id = int.Parse(p.Name);
            selected[id] = !selected[id];
            if (p.BackColor == unselected_color)
            {
                p.BackColor = selected_color;
                selected[id] = true;
            }
            else
            {
                p.BackColor = unselected_color;
                selected[id] = false;
            }
        }

        //点击图片改变选择状态
        private void label_click(object sender, EventArgs e)
        {
            Panel p = (Panel)(((Label)sender).Parent);
            int id = int.Parse(p.Name);
            selected[id] = !selected[id];
            if (p.BackColor == unselected_color)
            {
                p.BackColor = selected_color;
                selected[id] = true;
            }
            else
            {
                p.BackColor = unselected_color;
                selected[id] = false;
            }
        }

        //添加图片到左边工作区
        void add_image(string path, string name)
        {
            //添加新的图片单元格
            if (tot % 5 == 0)
            {
                result_show.RowStyles.Insert(result_show.RowCount++, new RowStyle());
                TableLayoutRowStyleCollection rowstyles;
                rowstyles = result_show.RowStyles;
                foreach (RowStyle style in rowstyles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Height = 170;
                }
            }

            //添加图片到单元格
            Panel p = new Panel();
            PictureBox image = new PictureBox();
            Label image_name = new Label();
            p.Name = tot.ToString();
            p.Dock = DockStyle.Fill;
            p.BackColor = unselected_color;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read); 
            Image bm = Image.FromStream(fs);
            int basement = bm.Height > bm.Width ? bm.Height : bm.Width;
            image.Height = (int)((double)bm.Height / basement * 140);
            image.Width = (int)((double)bm.Width / basement * 140);
            image.Image = Image.FromStream(fs);
            fs.Close();
            image_name.Height = 15;
            image_name.Width = image.Width;
            image_name.TextAlign = ContentAlignment.MiddleCenter;
            image_name.Font = new Font("宋体", 10);
            image_name.Text = name;
            image.Anchor = AnchorStyles.None;
            image_name.Anchor = AnchorStyles.None;
            image.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox_LoadCompleted);
            image.MouseDoubleClick +=new MouseEventHandler(image_MouseDoubleClick);

            image.Location = new Point((p.Width - image.Width) / 2, (p.Height - 15 - image.Height) / 2);
            image_name.Location = new Point(image.Location.X, image.Location.Y + image.Height + 5);
            p.Controls.Add(image);
            p.Controls.Add(image_name);
            result_show.Controls.Add(p, tot % 5, tot / 5);
            path_name[tot] = path;
            result_show.Refresh();
            tot++;
        }

        //用于双击显示界面
        private void image_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            Form imageshow = new ImageView();
            imageshow.Size = new Size(this.Width, this.Height);//新窗口界面大小和原窗口同样大
            imageshow.Show();
        }
        
        #region //线程，用于加快左侧目录树缩略图的显示,当展开事件发生时被激活
        public delegate void MyInvoke();
        public void loadthread() 
        {
            MyInvoke mi = new MyInvoke(loadjiedian);
            BeginInvoke(mi);
        }
        public void loadjiedian()
        {
            TreeViewItems.Add(ee.Node, this.treeView1);
        }
        #endregion


        //目录树结点展开事件：显示相应文件夹子文件夹以及图片和缩略图
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
           
            //开启线程加载待展开结点
            ee = e;
            Thread t = new Thread(new ThreadStart(loadthread));
            t.IsBackground = true;
            t.Start();
        }

        //目录树子节点被双击事件，将被点击的图片添加到右侧result_show
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            string path = e.Node.Name;
            if (path.IndexOf(".") != -1)
            {
                string name= "";
                name = path;
                string[] sArray =path.Split(new char[2] { '\\', '.' });
                name = sArray[sArray.Length - 2];
                add_image(path, name);
                Panel pa = (Panel)result_show.GetControlFromPosition((tot-1) % 5, (tot-1) / 5);
                PictureBox pb = (PictureBox)pa.Controls[0];
                Label l = (Label)pa.Controls[1];
                pa.Click += e1;
                pb.Click += e2;
                l.Click += e3;
                e.Node.Tag = null;
                e.Node.Checked = false;
            }

        }

        //目录树结点拖拽事件
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {

            //将被拖拽结点的check设置为true并设置tag为true以便将其加入到result_show
            TreeNode hi = (TreeNode)e.Item;
            hi.Checked = true;
            hi.Tag = tag;
            DoDragDrop(e.Item, DragDropEffects.Move);
           
        }

        //result_show控件拖入事件
        private void result_show_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        //result_show控件转入释放事件：遍历目录树所有结点，将其中被check的图片添加到result_show中
        private void result_show_DragDrop(object sender, DragEventArgs e)
        {

            TreeNode topnode = rootNode;//得到TreeView的根结点，注意根结点只有一个
   
            TraversNodes(topnode);//遍历根结点
            
        }

        //目录树结点被check事件：检查当前被check结点是否有子结点，若有将所有子节点设置为checked；检查是否有父节点，若有，判断该父节点所有子节点是否都被checked，若是，将父节点设置为checked
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                TreeNode node = e.Node;
                //对结点check状态反转
                if (node.Tag == null)
                    node.Tag = tag;//附加结点信息
                else
                    node.Tag = null;

                //将所有子节点check状态反转
                CheckAllChildNodes(e.Node, e.Node.Checked);

                //选中父节点 
                bool bol = true;
                if (e.Node.Parent != null)
                {
                    for (int i = 0; i < e.Node.Parent.Nodes.Count; i++)
                    {
                        if (!e.Node.Parent.Nodes[i].Checked)
                            bol = false;
                    }
                    e.Node.Parent.Checked = bol;

                    ////记得如果父节点被选中或取消，记得设置它的tag哦
                    if (bol)
                    {
                        e.Node.Parent.Tag = tag;
                    }
                    else
                    {
                        e.Node.Parent.Tag = null;
                    }
                }
            }
        }

        //将所有子节点check状态设置为父节点check状态
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                if (node.Tag == null)
                    node.Tag = tag;//附加结点信息
                else
                    node.Tag = null;
                node.Checked = nodeChecked;
              
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        //遍历所有结点，将被check的结点添加到result_show
        private void TraversNodes(TreeNode parent)
        {
            TreeNode node = parent;
            if (node != null)
            {
                if (node.Tag != null && node.Tag.ToString() == tag&&node.Nodes.Count==0)
                {
                    string path = node.Name;
                    string name = path;
                    string[] sArray = path.Split(new char[2] { '\\', '.' });
                    name = sArray[sArray.Length - 2];
                    add_image(path, name);
                    node.Tag = null;
                    node.Checked = false;
                }
                //    nodesTag.AppendFormat("node:{0} has checked\n", node.Text);

                if (node.FirstNode != null)////如果node节点还有子节点则进入遍历
                {
                    TraversNodes(node.FirstNode);
                }
                if (node.NextNode != null)////如果node节点后面有同级节点则进入遍历
                {
                    TraversNodes(node.NextNode);
                }
            }
        }

        private void addImageSet_Click(object sender, EventArgs e)
        {
            int i = tot;
            TreeNode topNode = rootNode;
            TraversNodes(topNode);
            Panel pa;
            PictureBox pb;
            Label l;
            for (; i < tot; i++)
            {
                pa = (Panel)result_show.GetControlFromPosition(i % 5, i / 5);
                pb = (PictureBox)pa.Controls[0];
                l = (Label)pa.Controls[1];
                pa.Click += e1;
                pb.Click += e2;
                l.Click += e3;
            }
        }

        public void progress_thread()
        {
            SortingProgress sp = new SortingProgress();
            sp.Show();
            sp.Refresh();
            while(true)
            {
                if(progress<1000)
                {
                    sp.sortingProgressBar.Value = progress;
                }
                else
                {
                    sp.Dispose();
                    break;
                }
                Thread.Sleep(50);
            }
        }

        //点击工作区隐藏图片清理、图片压缩、图片排序的面板
        private void result_show_Click(object sender, EventArgs e)
        {
            imageSortPanel.Visible = false;
            imageCompressPanel.Visible = false;
            imageClearPanel.Visible = false;
        }

        //图片无参考排序
        private void imageSort_none_Click(object sender, EventArgs e)
        {
            resetSortPanel();
            imageSortPanel.Visible = false;
            this.Refresh();
            progress = 0;
            Thread progressThread = new Thread(progress_thread);
            progressThread.IsBackground = true;
            progressThread.Start();
            Pic[] p = new Pic[tot];
            for (int i = 0; i < tot; i++)
            {
                name_copy[i] = name[i];
                path_name_copy[i] = path_name[i];
                p[i] = new Pic(path_name[i]);
                p[i].name = ((Label)(result_show.GetControlFromPosition(i % 5, i / 5).Controls[1])).Text;
                p[i].grade = p[i].tenengrad();
                progress = 950 * (i + 1) / tot;
            }
            Array.Sort(p, new PicComparer()); //图片排序调用
            progress = 950;

            //直接在原来pictureBox上加载图片
            Panel pa;
            PictureBox pb;
            Label l;
            for (int i = 0; i < tot; i++)
            {
                pa = (Panel)result_show.GetControlFromPosition(i % 5, i / 5);
                pb = (PictureBox)pa.Controls[0];
                l = (Label)pa.Controls[1];
                int basement = p[i].height > p[i].width ? p[i].height : p[i].width;
                pb.Height = (int)((double)p[i].height / basement * 140);
                pb.Width = (int)((double)p[i].width / basement * 140);
                l.Height = 15;
                l.Width = pb.Width;
                FileStream fs = new FileStream(p[i].path, FileMode.Open, FileAccess.Read);
                pb.Image = Image.FromStream(fs);
                fs.Close();
                l.Text = p[i].name;
                pb.Location = new Point((pa.Width - pb.Width) / 2, (pa.Height - 15 - pb.Height) / 2);
                l.Location = new Point(pb.Location.X, pb.Location.Y + pb.Height + 5);
                selected[i] = false;
                pa.BackColor = unselected_color;
                name[i] = p[i].name;
                path_name[i] = p[i].path;
                progress = 950 + 50 * (i + 1) / tot;
            }
            progress = 1000;
            SortingResult sr = new SortingResult();
            sr.Show();
        }


        private void imageSort_full_Click(object sender, EventArgs e)
        {
            resetSortPanel();
            imageSortPanel.Visible = false;
            this.Refresh();
            progress = 0;
            Thread progressThread = new Thread(progress_thread);
            progressThread.IsBackground = true;
            progressThread.Start();
            Pic[] p = new Pic[tot];
            for (int i = 0; i < tot; i++)
            {
                name_copy[i] = name[i];
                path_name_copy[i] = path_name[i];
                p[i] = new Pic(path_name[i]);
                p[i].name = ((Label)(result_show.GetControlFromPosition(i % 5, i / 5).Controls[1])).Text;
                p[i].grade = p[i].tenengrad();
                progress = 950 * (i + 1) / tot;
            }
            Array.Sort(p, new PicComparer()); //图片排序调用
            progress = 950;

            //直接在原来pictureBox上加载图片
            Panel pa;
            PictureBox pb;
            Label l;
            for (int i = 0; i < tot; i++)
            {
                pa = (Panel)result_show.GetControlFromPosition(i % 5, i / 5);
                pb = (PictureBox)pa.Controls[0];
                l = (Label)pa.Controls[1];
                int basement = p[i].height > p[i].width ? p[i].height : p[i].width;
                pb.Height = (int)((double)p[i].height / basement * 140);
                pb.Width = (int)((double)p[i].width / basement * 140);
                l.Height = 15;
                l.Width = pb.Width;
                FileStream fs = new FileStream(p[i].path, FileMode.Open, FileAccess.Read);
                pb.Image = Image.FromStream(fs);
                fs.Close();
                l.Text = p[i].name;
                pb.Location = new Point((pa.Width - pb.Width) / 2, (pa.Height - 15 - pb.Height) / 2);
                l.Location = new Point(pb.Location.X, pb.Location.Y + pb.Height + 5);
                selected[i] = false;
                pa.BackColor = unselected_color;
                name[i] = p[i].name;
                path_name[i] = p[i].path;
                progress = 950 + 50 * (i + 1) / tot;
            }
            progress = 1000;
            SortingResult sr = new SortingResult();
            sr.Show();
        }

        //图片无参考压缩
        private void imageCompress_none_Click(object sender, EventArgs e)
        {
            resetCompressPanel();
            imageCompressPanel.Visible = false;
            bool flag = false;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("请至少选择一张图片!");
                return;
            }
            COMPRESS_SELECTED = SettingInfo.SELECT_COMPRESS_NONE;
            SelectCompressForm selectCompressForm = new SelectCompressForm();
            selectCompressForm.Show();
        }

        //全参考比较的点击事件
        private void imageCompare_full_Click(object sender, EventArgs e)
        {

        }

        //图片全参考压缩
        private void imageCompress_full_Click(object sender, EventArgs e)
        {
            resetCompressPanel();
            imageCompressPanel.Visible = false;

            bool flag = false;
            int i = 0;
            for (; i < tot; i++)
            {
                if (selected[i])
                {
                    break;
                }
            }
            i++;
            for (; i < tot; i++)
            {
                if (selected[i])
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("请至少选择两张图片!");
                return;
            }

            COMPRESS_SELECTED = SettingInfo.SELECT_COMPRESS_FULL;
            SelectCompressForm selectCompressForm = new SelectCompressForm();
            selectCompressForm.Show();
        }

        //删除图片的点击事件
        private void deleteImage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tot; i++)
            {
                state[i] = selected[i];
                if (selected[i])
                {
                    selected[i] = false;
                    ((Panel)result_show.GetControlFromPosition(i % 5, i / 5)).BackColor = unselected_color;
                }
            }
            delete();
        }

        //删除图片的实现函数
        public void delete()
        {
            Panel p1, p2;
            PictureBox pb1, pb2;
            Label l1, l2;
            int i = 0, k = tot - 1;
            for (; i < tot; i++)
            {
                if (state[i])
                {
                    for (; k > i; k--)
                    {
                        if (!state[k])
                        {
                            break;
                        }
                    }
                    if (k == i)
                    {
                        break;
                    }
                    else
                    {
                        state[i] = false;
                        state[k] = true;
                        path_name[i] = path_name[k];
                        path_name[k] = null;
                        p1 = (Panel)result_show.GetControlFromPosition(i % 5, i / 5);
                        p2 = (Panel)result_show.GetControlFromPosition(k % 5, k / 5);
                        pb1 = (PictureBox)p1.Controls[0];
                        pb2 = (PictureBox)p2.Controls[0];
                        l1 = (Label)p1.Controls[1];
                        l2 = (Label)p2.Controls[1];
                        pb1.Location = pb2.Location;
                        l1.Location = l2.Location;
                        pb1.Height = pb2.Height;
                        pb1.Width = pb2.Width;
                        FileStream fs = new FileStream(path_name[i], FileMode.Open, FileAccess.Read);
                        pb1.Image = Image.FromStream(fs);
                        fs.Close();
                        l1.Text = l2.Text;
                        l1.Width = l2.Width;
                    }
                }
            }
            while(tot>0&&state[tot-1])
            {
                result_show.Controls[tot - 1].Dispose();
                tot--;
            }
            while (result_show.RowCount>1&&(result_show.RowCount-2)*5>=tot)
            {
                result_show.RowStyles.RemoveAt(result_show.RowCount - 1);
                result_show.RowCount--;
            }
        }

        //添加图片的点击事件
        private void addImage_Click(object sender, EventArgs e)
        {
            if (!select_all)
            {
                select_all = true;
                for (int i = 0; i < tot; i++)
                {
                    selected[i] = true;
                    ((Panel)result_show.GetControlFromPosition(i % 5, i / 5)).BackColor = selected_color;
                }
            }
            else
            {
                select_all = false;
                for (int i = 0; i < tot; i++)
                {
                    selected[i] = false;
                    ((Panel)result_show.GetControlFromPosition(i % 5, i / 5)).BackColor = unselected_color;
                }
            }
        }

        //设置button的点击事件
        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void imageClear_full_Click(object sender, EventArgs e)
        {
            resetClearPanel();
            ClearSetting cs = new ClearSetting(this);
            cs.Show();
        }

        private void imageCompare_none_Click(object sender, EventArgs e)
        {

        }
        private void resetClearPanel()
        {
            imageClearPanel.Visible = !imageClearPanel.Visible;
            imageComparePanel.Visible = false;
            imageSortPanel.Visible = false;
            imageCompressPanel.Visible = false;
        }

        private void resetComparePanel()
        {
            imageComparePanel.Visible = !imageComparePanel.Visible;
            imageSortPanel.Visible = false;
            imageCompressPanel.Visible = false;
            imageClearPanel.Visible = false;
        }

        private void resetCompressPanel()
        {
            imageCompressPanel.Visible = !imageCompressPanel.Visible;
            imageSortPanel.Visible = false;
            imageComparePanel.Visible = false;
            imageClearPanel.Visible = false;
        }

        private void resetSortPanel()
        {
            imageSortPanel.Visible = !imageSortPanel.Visible;
            imageComparePanel.Visible = false;
            imageCompressPanel.Visible = false;
            imageClearPanel.Visible = false;
        }

       
    }

   
}
