
//主窗口，其他窗口还没写
namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageCompress = new LT.WinForm.ImageButton.ImageButton();
            this.imageSort = new LT.WinForm.ImageButton.ImageButton();
            this.imageClear = new LT.WinForm.ImageButton.ImageButton();
            this.imageCompare = new LT.WinForm.ImageButton.ImageButton();
            this.settingPanel = new LT.WinForm.ImageButton.ImageButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imageSortPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imageSort_full = new LT.WinForm.ImageButton.ImageButton();
            this.imageSort_none = new LT.WinForm.ImageButton.ImageButton();
            this.imageClearPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imageCompress_full = new LT.WinForm.ImageButton.ImageButton();
            this.imageCompress_none = new LT.WinForm.ImageButton.ImageButton();
            this.result_show = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteImage = new LT.WinForm.ImageButton.ImageButton();
            this.addImageSet = new LT.WinForm.ImageButton.ImageButton();
            this.addImage = new LT.WinForm.ImageButton.ImageButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.searchButton = new LT.WinForm.ImageButton.ImageButton();
            this.settingButton = new LT.WinForm.ImageButton.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.imageSortPanel.SuspendLayout();
            this.imageClearPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 31);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1100, 600);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1189, 622);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel1.Controls.Add(this.imageCompress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageSort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageCompare, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingPanel, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageCompress
            // 
            this.imageCompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageCompress.ButtonImage = global::UI.Properties.Resources.compress_normal;
            this.imageCompress.ButtonText = "";
            this.imageCompress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCompress.Location = new System.Drawing.Point(197, 3);
            this.imageCompress.MouseClickImage = global::UI.Properties.Resources.compress_selected;
            this.imageCompress.MouseOverImage = global::UI.Properties.Resources.compress_selected;
            this.imageCompress.Name = "imageCompress";
            this.imageCompress.Size = new System.Drawing.Size(188, 79);
            this.imageCompress.TabIndex = 4;
            this.imageCompress.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageCompress_Click);
            // 
            // imageSort
            // 
            this.imageSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageSort.ButtonImage = global::UI.Properties.Resources.sort_normal2;
            this.imageSort.ButtonText = "";
            this.imageSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSort.Location = new System.Drawing.Point(3, 3);
            this.imageSort.MouseClickImage = global::UI.Properties.Resources.sort_selected;
            this.imageSort.MouseOverImage = global::UI.Properties.Resources.sort_selected;
            this.imageSort.Name = "imageSort";
            this.imageSort.Size = new System.Drawing.Size(188, 79);
            this.imageSort.TabIndex = 0;
            this.imageSort.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageSort_Click);
            // 
            // imageClear
            // 
            this.imageClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageClear.ButtonImage = global::UI.Properties.Resources.clean_normal;
            this.imageClear.ButtonText = "";
            this.imageClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageClear.Location = new System.Drawing.Point(391, 3);
            this.imageClear.MouseClickImage = global::UI.Properties.Resources.clean_selected;
            this.imageClear.MouseOverImage = global::UI.Properties.Resources.clean_selected;
            this.imageClear.Name = "imageClear";
            this.imageClear.Size = new System.Drawing.Size(188, 79);
            this.imageClear.TabIndex = 1;
            this.imageClear.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageClear_Click);
            // 
            // imageCompare
            // 
            this.imageCompare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageCompare.ButtonImage = global::UI.Properties.Resources.compare_normal;
            this.imageCompare.ButtonText = "";
            this.imageCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCompare.Location = new System.Drawing.Point(585, 3);
            this.imageCompare.MouseClickImage = global::UI.Properties.Resources.compare_selected;
            this.imageCompare.MouseOverImage = global::UI.Properties.Resources.compare_selected;
            this.imageCompare.Name = "imageCompare";
            this.imageCompare.Size = new System.Drawing.Size(188, 79);
            this.imageCompare.TabIndex = 2;
            this.imageCompare.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageCompare_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingPanel.ButtonImage = global::UI.Properties.Resources.btn6;
            this.settingPanel.ButtonText = "";
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(779, 3);
            this.settingPanel.MouseClickImage = global::UI.Properties.Resources.用户设置_高亮;
            this.settingPanel.MouseOverImage = global::UI.Properties.Resources.用户设置_高亮;
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(407, 79);
            this.settingPanel.TabIndex = 3;
            this.settingPanel.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.personalSetting_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer2.Panel1.Controls.Add(this.imageSortPanel);
            this.splitContainer2.Panel1.Controls.Add(this.imageClearPanel);
            this.splitContainer2.Panel1.Controls.Add(this.result_show);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AllowDrop = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(1189, 463);
            this.splitContainer2.SplitterDistance = 902;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // imageSortPanel
            // 
            this.imageSortPanel.ColumnCount = 1;
            this.imageSortPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageSortPanel.Controls.Add(this.imageSort_full, 0, 0);
            this.imageSortPanel.Controls.Add(this.imageSort_none, 0, 1);
            this.imageSortPanel.Location = new System.Drawing.Point(0, -3);
            this.imageSortPanel.Name = "imageSortPanel";
            this.imageSortPanel.RowCount = 2;
            this.imageSortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageSortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageSortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.imageSortPanel.Size = new System.Drawing.Size(195, 161);
            this.imageSortPanel.TabIndex = 3;
            this.imageSortPanel.Visible = false;
            // 
            // imageSort_full
            // 
            this.imageSort_full.AllowDrop = true;
            this.imageSort_full.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageSort_full.ButtonImage = global::UI.Properties.Resources.full_normal1;
            this.imageSort_full.ButtonText = "";
            this.imageSort_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSort_full.Location = new System.Drawing.Point(3, 3);
            this.imageSort_full.MouseClickImage = global::UI.Properties.Resources.full_selected;
            this.imageSort_full.MouseOverImage = global::UI.Properties.Resources.full_selected;
            this.imageSort_full.Name = "imageSort_full";
            this.imageSort_full.Size = new System.Drawing.Size(189, 74);
            this.imageSort_full.TabIndex = 0;
            this.imageSort_full.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageSort_full_Click);
            // 
            // imageSort_none
            // 
            this.imageSort_none.AllowDrop = true;
            this.imageSort_none.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageSort_none.ButtonImage = global::UI.Properties.Resources.none_normal1;
            this.imageSort_none.ButtonText = "";
            this.imageSort_none.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSort_none.Location = new System.Drawing.Point(3, 83);
            this.imageSort_none.MouseClickImage = global::UI.Properties.Resources.none_selected;
            this.imageSort_none.MouseOverImage = global::UI.Properties.Resources.none_selected;
            this.imageSort_none.Name = "imageSort_none";
            this.imageSort_none.Size = new System.Drawing.Size(189, 75);
            this.imageSort_none.TabIndex = 1;
            this.imageSort_none.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageSort_none_Click);
            // 
            // imageClearPanel
            // 
            this.imageClearPanel.ColumnCount = 1;
            this.imageClearPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageClearPanel.Controls.Add(this.imageCompress_full, 0, 0);
            this.imageClearPanel.Controls.Add(this.imageCompress_none, 0, 1);
            this.imageClearPanel.Location = new System.Drawing.Point(388, -3);
            this.imageClearPanel.Name = "imageClearPanel";
            this.imageClearPanel.RowCount = 2;
            this.imageClearPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageClearPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imageClearPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.imageClearPanel.Size = new System.Drawing.Size(195, 161);
            this.imageClearPanel.TabIndex = 2;
            this.imageClearPanel.Visible = false;
            // 
            // imageCompress_full
            // 
            this.imageCompress_full.AllowDrop = true;
            this.imageCompress_full.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageCompress_full.ButtonImage = global::UI.Properties.Resources.full_normal1;
            this.imageCompress_full.ButtonText = "";
            this.imageCompress_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCompress_full.Location = new System.Drawing.Point(3, 3);
            this.imageCompress_full.MouseClickImage = global::UI.Properties.Resources.full_selected;
            this.imageCompress_full.MouseOverImage = global::UI.Properties.Resources.full_selected;
            this.imageCompress_full.Name = "imageCompress_full";
            this.imageCompress_full.Size = new System.Drawing.Size(189, 74);
            this.imageCompress_full.TabIndex = 0;
            this.imageCompress_full.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageClear_full_Click);
            // 
            // imageCompress_none
            // 
            this.imageCompress_none.AllowDrop = true;
            this.imageCompress_none.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageCompress_none.ButtonImage = global::UI.Properties.Resources.none_normal1;
            this.imageCompress_none.ButtonText = "";
            this.imageCompress_none.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCompress_none.Location = new System.Drawing.Point(3, 83);
            this.imageCompress_none.MouseClickImage = global::UI.Properties.Resources.none_selected;
            this.imageCompress_none.MouseOverImage = global::UI.Properties.Resources.none_selected;
            this.imageCompress_none.Name = "imageCompress_none";
            this.imageCompress_none.Size = new System.Drawing.Size(189, 75);
            this.imageCompress_none.TabIndex = 1;
            this.imageCompress_none.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageClear_none_Click);
            // 
            // result_show
            // 
            this.result_show.AllowDrop = true;
            this.result_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.result_show.AutoScroll = true;
            this.result_show.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.result_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.result_show.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.result_show.ColumnCount = 5;
            this.result_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.result_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.result_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.result_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.result_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.result_show.Location = new System.Drawing.Point(0, 0);
            this.result_show.Margin = new System.Windows.Forms.Padding(0);
            this.result_show.Name = "result_show";
            this.result_show.RowCount = 1;
            this.result_show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.result_show.Size = new System.Drawing.Size(902, 465);
            this.result_show.TabIndex = 1;
            this.result_show.Click += new System.EventHandler(this.result_show_Click);
            this.result_show.DragDrop += new System.Windows.Forms.DragEventHandler(this.result_show_DragDrop);
            this.result_show.DragEnter += new System.Windows.Forms.DragEventHandler(this.result_show_DragEnter);
            //this.result_show.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.result_show_MouseDoubleClick);
            this.result_show.Resize += new System.EventHandler(this.result_show_Resize);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.deleteImage, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.addImageSet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addImage, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 423);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // deleteImage
            // 
            this.deleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteImage.AutoSize = true;
            this.deleteImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("deleteImage.ButtonImage")));
            this.deleteImage.ButtonText = "";
            this.deleteImage.Location = new System.Drawing.Point(244, 3);
            this.deleteImage.MouseClickImage = null;
            this.deleteImage.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("deleteImage.MouseOverImage")));
            this.deleteImage.Name = "deleteImage";
            this.deleteImage.Size = new System.Drawing.Size(39, 34);
            this.deleteImage.TabIndex = 2;
            this.deleteImage.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.deleteImage_Click);
            // 
            // addImageSet
            // 
            this.addImageSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageSet.AutoSize = true;
            this.addImageSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addImageSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addImageSet.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addImageSet.ButtonImage")));
            this.addImageSet.ButtonText = "";
            this.addImageSet.Location = new System.Drawing.Point(160, 3);
            this.addImageSet.MouseClickImage = null;
            this.addImageSet.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("addImageSet.MouseOverImage")));
            this.addImageSet.Name = "addImageSet";
            this.addImageSet.Size = new System.Drawing.Size(36, 34);
            this.addImageSet.TabIndex = 1;
            this.addImageSet.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.addImageSet_Click);
            // 
            // addImage
            // 
            this.addImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addImage.AutoSize = true;
            this.addImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addImage.ButtonImage")));
            this.addImage.ButtonText = "";
            this.addImage.Location = new System.Drawing.Point(202, 3);
            this.addImage.MouseClickImage = null;
            this.addImage.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("addImage.MouseOverImage")));
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(36, 34);
            this.addImage.TabIndex = 0;
            this.addImage.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.addImage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 417);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(366, 417);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addFolder.png");
            this.imageList1.Images.SetKeyName(1, "addImage.png");
            this.imageList1.Images.SetKeyName(2, "addImage2.jpg");
            this.imageList1.Images.SetKeyName(3, "check.png");
            this.imageList1.Images.SetKeyName(4, "clear.png");
            this.imageList1.Images.SetKeyName(5, "close.png");
            this.imageList1.Images.SetKeyName(6, "comparison.png");
            this.imageList1.Images.SetKeyName(7, "compress.png");
            this.imageList1.Images.SetKeyName(8, "delete.png");
            this.imageList1.Images.SetKeyName(9, "folder.png");
            this.imageList1.Images.SetKeyName(10, "ImageSort.jpg");
            this.imageList1.Images.SetKeyName(11, "maximize.png");
            this.imageList1.Images.SetKeyName(12, "minimize.png");
            this.imageList1.Images.SetKeyName(13, "optimization.png");
            this.imageList1.Images.SetKeyName(14, "person.png");
            this.imageList1.Images.SetKeyName(15, "search.png");
            this.imageList1.Images.SetKeyName(16, "settings.png");
            this.imageList1.Images.SetKeyName(17, "MyComputer.png");
            this.imageList1.Images.SetKeyName(18, "FixedDrive.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "addImage2.jpg");
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("searchButton.ButtonImage")));
            this.searchButton.ButtonText = "";
            this.searchButton.Location = new System.Drawing.Point(1029, 3);
            this.searchButton.MouseClickImage = null;
            this.searchButton.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("searchButton.MouseOverImage")));
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(25, 17);
            this.searchButton.TabIndex = 2;
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("settingButton.ButtonImage")));
            this.settingButton.ButtonText = "";
            this.settingButton.Location = new System.Drawing.Point(1063, 3);
            this.settingButton.MouseClickImage = null;
            this.settingButton.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("settingButton.MouseOverImage")));
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(25, 17);
            this.settingButton.TabIndex = 1;
            this.settingButton.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.settingButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.imageSortPanel.ResumeLayout(false);
            this.imageClearPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinToolTip skinToolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private LT.WinForm.ImageButton.ImageButton settingButton;
        private LT.WinForm.ImageButton.ImageButton searchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LT.WinForm.ImageButton.ImageButton imageSort;
        private LT.WinForm.ImageButton.ImageButton imageClear;
        private LT.WinForm.ImageButton.ImageButton imageCompare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LT.WinForm.ImageButton.ImageButton deleteImage;
        private LT.WinForm.ImageButton.ImageButton addImage;
        private LT.WinForm.ImageButton.ImageButton addImageSet;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel imageSortPanel;
        private LT.WinForm.ImageButton.ImageButton imageSort_full;
        private LT.WinForm.ImageButton.ImageButton imageSort_none;
        private System.Windows.Forms.TableLayoutPanel imageClearPanel;
        private LT.WinForm.ImageButton.ImageButton imageCompress_full;
        private LT.WinForm.ImageButton.ImageButton imageCompress_none;
        public System.Windows.Forms.TableLayoutPanel result_show;
        public System.Windows.Forms.SplitContainer splitContainer2;
        private LT.WinForm.ImageButton.ImageButton imageCompress;
        private LT.WinForm.ImageButton.ImageButton settingPanel;

    }
}

