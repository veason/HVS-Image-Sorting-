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
using Microsoft.VisualBasic.FileIO;
using demo1;

namespace UI
{
    public partial class MainForm :CCSkinMain
    {
        public static int tot = 0; //图片数
        public static bool[] selected; //每张图片是否被选中，true表示被选中，false表示没被选中
        public static string[] name; //图片名字
        public static string[] path_name; //图片路径，记录第i张图片的地址
        public static string[] name_copy; //用于图片排序展示的副本
        public static string[] path_name_copy; //用于图片排序展示的副本
        public static bool[] state; //图片状态
        public static int progress; //排序进度
        public static int clear_ratio = 50; //图片清理率，也就是清除图片评分后百分之几的图片
        public static List<string> existed_images; //记录图片是否已经添加，防止重复添加一张图片
        public static Dictionary<string, Pic> picInfo; //图片信息，键值对<图片路径,Pic对象>，可以根据路径名得到图片信息，包括图片的bitmap类对象(封装在Pic类中)，可用于控件的图像展示
        private const int SIZE = 10000; //初始化常量
        public string last_pic = null; //上一次全参考选择的图像

        TreeViewEventArgs ee; //用于右侧目录树缩略图加载函数loadjiedian中获取treeview控件
        string tag = "True"; //Tag标签，用于检测被check的结点（每个被check的结点的tag属性被设置为true）
        TreeNode rootNode; //用于设置目录树根节点（我的电脑）
        bool select_all = false; //是否全选
        Color unselected_color = Color.FromArgb(128, 208, 255); //图片未选择时背景颜色
        Color selected_color = Color.FromArgb(92, 199, 249); //图片选择时背景颜色
        int sizeF = 5; //缩放等级，缩放等级越小图片越大
        bool result_show_flag = false; //记录ctrl键是否键下，用于图片缩放

        EventHandler e1; //点击单元格panel改变选择状态的事件
        EventHandler e2; //点击单元格panel改变选择状态的事件
        EventHandler e3; //点击单元格panel改变选择状态的事件

        //主窗口初始化变量
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            selected = new bool[SIZE];
            state = new bool[SIZE];
            name = new string[SIZE];
            name_copy = new string[SIZE];
            path_name = new string[SIZE];
            path_name_copy = new string[SIZE];
            existed_images = new List<string>();
            picInfo = new Dictionary<string, Pic>();
            for (int i = 0; i < SIZE; i++)
            {
                selected[i] = false;
                state[i] = false;
            }
            e1 = new EventHandler(item_click);
            e2 = new EventHandler(pictureBox_click);
            e3 = new EventHandler(label_click);
            result_show.Width = splitContainer2.Panel1.Width / sizeF * 5;
            if (sizeF != 5)
            {
                result_show.Width += sizeF * 5;
            }
            result_show.MouseWheel += new System.Windows.Forms.MouseEventHandler(changeSize);
        }

        //窗口加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载目录树
            directoryTree();
        }

        //左侧结果显示控件被双击后弹出图片浏览界面
        private void result_show_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
             * 判断左侧图片展示区是否有图片，tot为左侧图片总数
             **/
            if (MainForm.tot> 0)
            {
                Form imageshow = new ImageView();
                imageshow.Size = new Size(this.Width, this.Height);
                imageshow.Show();
            }
            else
            {
                
            }
        }
        
        //主界面窗口变化事件，相应的调整控件位置及大小
        private void MainForm_Resize(object sender, EventArgs e) 
        {
            result_show.Width = splitContainer2.Panel1.Width / sizeF * 5;
            if(sizeF!=5)
            {
                result_show.Width += sizeF * 5;
            }
            int width;
            int height;
            Point temp;
            //控制左侧图片显示框位置及大小
            {
                temp = this.imageCompare.Location;
                width = this.imageCompare.Width;
                height = this.imageCompare.Height;

                temp = this.imageCompress.Location;
                width = this.imageCompress.Width;
                height = this.imageCompress.Height;

                temp = this.imageClear.Location;
                width = this.imageClear.Width;
                height = this.imageClear.Height;
                this.imageClearPanel.Location = new Point(temp.X, 0);
                this.imageClearPanel.Width = width;

                temp = this.imageSort.Location;
                width = this.imageSort.Width;
                height = this.imageSort.Height;
                this.imageSortPanel.Location = new Point(temp.X, 0);
                this.imageSortPanel.Width = width;
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

        //图片排序面板
        private void imageSort_Click(object sender, EventArgs e)
        {
            imageSortPanel.Visible = !imageSortPanel.Visible;
            imageClearPanel.Visible = false;
        }

        //图片压缩面板
        private void imageCompress_Click(object sender, EventArgs e)
        {
            imageClearPanel.Visible = false;
            imageSortPanel.Visible = false;
            int cnt = 0;
            string _path = null;
            string _name = null;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    cnt++;
                    _path = path_name[i];
                    _name = name[i];
                }
            }
            if (cnt == 0)
            {
                MessageBox.Show("请选一张需要进行压缩的图片");
                return;
            }
            else if (cnt > 1)
            {
                MessageBox.Show("压缩图片只能为一张");
                return;
            }
            CompressForm_none cn = new CompressForm_none(_path, _name);
            cn.Show();
        }

        //图片清理面板
        private void imageClear_Click(object sender, EventArgs e)
        {
            imageClearPanel.Visible = !imageClearPanel.Visible;
            imageSortPanel.Visible = false;
        }

        //图片比较面板
        private void imageCompare_Click(object sender, EventArgs e)
        {
            imageClearPanel.Visible = false;
            imageSortPanel.Visible = false;
            int cnt = 0;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    cnt++;
                }
            }
            if (cnt != 2)
            {
                MessageBox.Show("请选择两张图片!");
                return;
            }
            CompareForm_none compareForm_none = new CompareForm_none();
            compareForm_none.Show();
        }

        //用户设置面板
        private void personalSetting_Click(object sender, EventArgs e)
        {
            imageSortPanel.Visible = false;
            imageClearPanel.Visible = false;
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
        bool add_image(string path, string _name)
        {
            if (existed_images.Contains(path))
            {
                return false; //图片已经存在，添加失败
            }
            existed_images.Add(path);
            Pic pic = new Pic(path);
            picInfo.Add(path, pic);

            //添加新的图片单元格
            if (tot % 5 == 0)
            {
                result_show.RowStyles.Insert(result_show.RowCount++, new RowStyle());
                TableLayoutRowStyleCollection rowstyles;
                rowstyles = result_show.RowStyles;
                foreach (RowStyle style in rowstyles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Height = result_show.Width / 5;
                }
            }
            name[tot] = _name;

            picturePanel p = new picturePanel();
            p.Name = tot.ToString();
            p.BackColor = unselected_color;
            p.image.MouseDoubleClick += new MouseEventHandler(image_MouseDoubleClick);

            result_show.Controls.Add(p, tot % 5, tot / 5);
            p.init(MainForm.picInfo[path].image, _name);
            path_name[tot] = path;
            result_show.Refresh();
            tot++;
            return true; //成功添加图片
        }

        //删除工作区中的图片
        public void delete()
        {
            picturePanel p1, p2;
            PictureBox pb1, pb2;
            Label l1, l2;
            int i = 0, k = tot - 1;
            for (; i < k; i++)
            {
                if (state[i])
                {
                    existed_images.Remove(path_name[i]);
                    picInfo.Remove(path_name[i]);
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

                        p1 = (picturePanel)result_show.GetControlFromPosition(i % 5, i / 5);
                        p2 = (picturePanel)result_show.GetControlFromPosition(k % 5, k / 5);
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
                        l1.Location = l2.Location;
                        l1.Width = l2.Width;
                        l1.Height = l2.Height;
                    }
                }
            }
            while (tot > 0 && state[tot - 1])
            {
                result_show.Controls[tot - 1].Dispose();
                tot--;
            }
            while (result_show.RowCount > 1 && (result_show.RowCount - 2) * 5 >= tot)
            {
                result_show.RowStyles.RemoveAt(result_show.RowCount - 1);
                result_show.RowCount--;
            }
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
                if (add_image(path, name))
                {
                    Panel pa = (Panel)result_show.GetControlFromPosition((tot - 1) % 5, (tot - 1) / 5);
                    PictureBox pb = (PictureBox)pa.Controls[0];
                    Label l = (Label)pa.Controls[1];
                    pa.Click += e1;
                    pb.Click += e2;
                    l.Click += e3;
                    e.Node.Tag = null;
                    e.Node.Checked = false;
                }
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
                {
                    node.Tag = tag;//附加结点信息
                }
                else
                {
                    node.Tag = null;
                }

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
                    if(!add_image(path, name))
                    {
                        return;
                    }
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
            picturePanel pa;
            PictureBox pb;
            Label l;
            for (; i < tot; i++)
            {
                pa = (picturePanel)result_show.GetControlFromPosition(i % 5, i / 5);
                pb = (PictureBox)pa.Controls[0];
                l = (Label)pa.Controls[1];
                pa.Click += e1;
                pb.Click += e2;
                l.Click += e3;
            }
        }

        //排序进度条更新线程
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
            imageClearPanel.Visible = false;
            imageSortPanel.Visible = false;
        }

        //图片无参考排序
        private void imageSort_none_Click(object sender, EventArgs e)
        {
            resetSortPanel();
            this.Refresh();
            progress = 0;
            Thread progressThread = new Thread(progress_thread);
            progressThread.IsBackground = true;
            progressThread.Start();
            sortObject[] sortArray = new sortObject[tot];
            for (int i = 0; i < tot; i++)
            {
                name_copy[i] = name[i];
                path_name_copy[i] = path_name[i];
                if (!picInfo[path_name[i]].state_none)
                {
                    picInfo[path_name[i]].grade_none = picInfo[path_name[i]].tenengrad();
                    picInfo[path_name[i]].state_none = true;
                }
                sortArray[i] = new sortObject(picInfo[path_name[i]].grade_none, path_name[i], name[i]);
                progress = 950 * (i + 1) / tot;
            }
            Array.Sort(sortArray, new sortObjectComparer()); //图片排序调用
            progress = 950;

            //直接在原来pictureBox上加载图片
            picturePanel picPanel;
            for (int i = 0; i < tot; i++)
            {
                picPanel = (picturePanel)result_show.GetControlFromPosition(i % 5, i / 5);
                path_name[i] = sortArray[i].path;
                name[i] = sortArray[i].name;
                picPanel.init(picInfo[path_name[i]].image, name[i]);
                selected[i] = false;
                picPanel.BackColor = unselected_color;
                progress = 950 + 50 * (i + 1) / tot;
            }
            progress = 1000;
            SortingResult sr = new SortingResult();
            sr.Show();
        }

        //图片全参考排序
        private void imageSort_full_Click(object sender, EventArgs e)
        {
            resetSortPanel();
            this.Refresh();
            int cnt = 0;
            string _path = null;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    cnt++;
                    _path = path_name[i];
                }
            }
            if (cnt == 0)
            {
                MessageBox.Show("请选一张图片作为参考图像");
                return;
            }
            else if (cnt > 1)
            {
                MessageBox.Show("只能选一张图片作为参考图像");
                return;
            }

            progress = 0;
            Thread progressThread = new Thread(progress_thread);
            progressThread.IsBackground = true;
            progressThread.Start();
            sortObject[] sortArray = new sortObject[tot];
            for (int i = 0; i < tot; i++)
            {
                name_copy[i] = name[i];
                path_name_copy[i] = path_name[i];
                if (!picInfo[path_name[i]].state_full || last_pic != _path)
                {
                    picInfo[path_name[i]].grade_full = picInfo[path_name[i]].psnr(picInfo[_path], picInfo[path_name[i]].height, picInfo[path_name[i]].width);
                    picInfo[path_name[i]].state_full = true;
                }
                sortArray[i] = new sortObject(picInfo[path_name[i]].grade_full, path_name[i], name[i]);
                progress = 950 * (i + 1) / tot;
            }
            last_pic = _path;
            Array.Sort(sortArray, new sortObjectComparer()); //图片排序调用
            progress = 950;

            //直接在原来pictureBox上加载图片
            picturePanel picPanel;
            for (int i = 0; i < tot; i++)
            {
                picPanel = (picturePanel)result_show.GetControlFromPosition(i % 5, i / 5);
                path_name[i] = sortArray[i].path;
                name[i] = sortArray[i].name;
                picPanel.init(picInfo[path_name[i]].image, name[i]);
                selected[i] = false;
                picPanel.BackColor = unselected_color;
                progress = 950 + 50 * (i + 1) / tot;
            }
            progress = 1000;
            SortingResult sr = new SortingResult(_path);
            sr.Show();
        }

        //图片无参考压缩
        private void imageCompress_none_Click(object sender, EventArgs e)
        {
        }

        //图片全参考压缩
        private void imageCompress_full_Click(object sender, EventArgs e)
        {
        }

        //图片无参考清理
        private void imageClear_none_Click(object sender, EventArgs e)
        {
            sortObject[] sortArray = new sortObject[tot];
            for (int i = 0; i < tot; i++)
            {
                if (!picInfo[path_name[i]].state_none)
                {
                    picInfo[path_name[i]].grade_none = picInfo[path_name[i]].tenengrad();
                    picInfo[path_name[i]].state_none = true;
                }
                sortArray[i] = new sortObject(picInfo[path_name[i]].grade_none, path_name[i], name[i]);
            }
            Array.Sort(sortArray, new sortObjectComparer());

            ClearSetting cs = new ClearSetting(this, sortArray);
            cs.Show();
        }

        //图片全参考清理
        private void imageClear_full_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int id = 0;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    cnt++;
                    id = i;
                }
            }
            if (cnt == 0)
            {
                MessageBox.Show("请选一张图片作为参考图像");
                return;
            }
            else if (cnt > 1)
            {
                MessageBox.Show("只能选一张图片作为参考图像");
                return;
            }

            sortObject[] sortArray = new sortObject[tot];
            for (int i = 0; i < tot; i++)
            {
                if (!picInfo[path_name[i]].state_full || last_pic != path_name[id])
                {
                    picInfo[path_name[i]].grade_full = picInfo[path_name[i]].psnr(picInfo[path_name[id]], picInfo[path_name[i]].height, picInfo[path_name[i]].width);
                    picInfo[path_name[i]].state_full = true;
                }
                sortArray[i] = new sortObject(picInfo[path_name[i]].grade_full, path_name[i], name[i]);
            }
            Array.Sort(sortArray, new sortObjectComparer());
            last_pic = path_name[id];

            ClearSetting cs = new ClearSetting(this, sortArray);
            cs.Show();
        }

        //图片全参考比较
        private void imageCompare_full_Click(object sender, EventArgs e)
        {
            resetComparePanel();
            imageClearPanel.Visible = false;
            int count = 0;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    count++;
                }

            }
            if (count != 2)
            {
                MessageBox.Show("请选择两张图片!");
                return;
            }
            CompareForm_none compareForm_none = new CompareForm_none();
            compareForm_none.Show();
        }

        //删除图片按钮点击事件
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

        //添加图片按钮点击事件
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

        //设置按钮点击事件
        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void imageCompare_none_Click(object sender, EventArgs e)
        {
            resetComparePanel();
            imageClearPanel.Visible = false;
            int count = 0;
            for (int i = 0; i < tot; i++)
            {
                if (selected[i])
                {
                    count++;
                }
            }
            if(count != 2)
            {
                MessageBox.Show("请选择两张图片!");
                return;
            }
            CompareForm_none compareForm_none = new CompareForm_none();
            compareForm_none.Show();
        }

        private void resetClearPanel()
        {
            imageSortPanel.Visible = !imageSortPanel.Visible;
            imageClearPanel.Visible = false;
        }

        private void resetComparePanel()
        {
            imageClearPanel.Visible = false;
            imageSortPanel.Visible = false;
        }

        private void resetCompressPanel()
        {
            imageClearPanel.Visible = !imageClearPanel.Visible;
            imageSortPanel.Visible = false;
        }

        private void resetSortPanel()
        {
            imageClearPanel.Visible = false;
            imageSortPanel.Visible = false;
        }

        private void result_show_Resize(object sender, EventArgs e)
        {
            TableLayoutRowStyleCollection rowstyles;
            rowstyles = result_show.RowStyles;
            foreach (RowStyle style in rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = result_show.Width / 5;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.CompareTo(Keys.Control) == 0)
            {
                result_show_flag = true;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.ControlKey)
            {
                result_show_flag = false;
            }
        }

        private void changeSize(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (result_show_flag && (result_show.RectangleToClient(this.ClientRectangle).Contains(MousePosition)||true))
            {
                if(e.Delta<0)
                {
                    if(sizeF==5)
                    {
                        return;
                    }
                    sizeF++;
                }
                else
                {
                    if(sizeF==3)
                    {
                        return;
                    }
                    sizeF--;
                }
                result_show.Width = splitContainer2.Panel1.Width / sizeF * 5;
                if (sizeF != 5)
                {
                    result_show.Width += sizeF * 5;
                }
                TableLayoutRowStyleCollection rowstyles;
                rowstyles = result_show.RowStyles;
                foreach (RowStyle style in rowstyles)
                {
                    style.SizeType = SizeType.Absolute;
                    style.Height = result_show.Width / 5;
                }
            }
        }
    }
}