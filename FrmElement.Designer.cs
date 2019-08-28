namespace Winform.Animation.Train
{
    partial class FrmElement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("区间");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("分界点");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("坡度曲线");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("线路要素", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("车站布置");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("到发线数量");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("咽喉区长度");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("道岔设置");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("车站要素", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("联锁方式");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("设备参数");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("空间位置");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("信号制式");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("调度系统");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("固定设备要素", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("运行速度");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("特性曲线");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("列控系统");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("动车组要素", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("基础设施", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9,
            treeNode15,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("列车径路");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("开行数量");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("速度等级");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("停站方案");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("开行方案要素", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("运行时分");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("间隔时间");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("停站时间");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("天窗时间");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("铺画规则");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("运行图要素", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("运用模式");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("周转图");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("维修计划");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("动车组运用要素", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("乘务制度");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("乘务数量");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("乘务交路");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("乘务计划要素", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("运输计划", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode31,
            treeNode35,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("高速铁路能力要素集", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode40});
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(301, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(876, 539);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "京沪高铁",
            "京广高铁",
            "京哈高铁"});
            this.comboBox1.Location = new System.Drawing.Point(30, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TreeView1
            // 
            this.TreeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.TreeView1.Location = new System.Drawing.Point(30, 56);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "节点12";
            treeNode1.Text = "区间";
            treeNode2.Name = "节点13";
            treeNode2.Text = "分界点";
            treeNode3.Name = "节点14";
            treeNode3.Text = "坡度曲线";
            treeNode4.Name = "节点1";
            treeNode4.Text = "线路要素";
            treeNode5.Name = "节点15";
            treeNode5.Text = "车站布置";
            treeNode6.Name = "节点16";
            treeNode6.Text = "到发线数量";
            treeNode7.Name = "节点17";
            treeNode7.Text = "咽喉区长度";
            treeNode8.Name = "节点18";
            treeNode8.Text = "道岔设置";
            treeNode9.Name = "节点2";
            treeNode9.Text = "车站要素";
            treeNode10.Name = "节点20";
            treeNode10.Text = "联锁方式";
            treeNode11.Name = "节点21";
            treeNode11.Text = "设备参数";
            treeNode12.Name = "节点22";
            treeNode12.Text = "空间位置";
            treeNode13.Name = "节点23";
            treeNode13.Text = "信号制式";
            treeNode14.Name = "节点24";
            treeNode14.Text = "调度系统";
            treeNode15.Name = "节点3";
            treeNode15.Text = "固定设备要素";
            treeNode16.Name = "节点25";
            treeNode16.Text = "运行速度";
            treeNode17.Name = "节点26";
            treeNode17.Text = "特性曲线";
            treeNode18.Name = "节点27";
            treeNode18.Text = "列控系统";
            treeNode19.Name = "节点4";
            treeNode19.Text = "动车组要素";
            treeNode20.Name = "节点0";
            treeNode20.Text = "基础设施";
            treeNode21.Name = "节点28";
            treeNode21.Text = "列车径路";
            treeNode22.Name = "节点29";
            treeNode22.Text = "开行数量";
            treeNode23.Name = "节点30";
            treeNode23.Text = "速度等级";
            treeNode24.Name = "节点31";
            treeNode24.Text = "停站方案";
            treeNode25.Name = "节点5";
            treeNode25.Text = "开行方案要素";
            treeNode26.Name = "运行时分";
            treeNode26.Text = "运行时分";
            treeNode27.Name = "节点33";
            treeNode27.Text = "间隔时间";
            treeNode28.Name = "节点34";
            treeNode28.Text = "停站时间";
            treeNode29.Name = "节点35";
            treeNode29.Text = "天窗时间";
            treeNode30.Name = "节点36";
            treeNode30.Text = "铺画规则";
            treeNode31.Name = "节点9";
            treeNode31.Text = "运行图要素";
            treeNode32.Name = "节点37";
            treeNode32.Text = "运用模式";
            treeNode33.Name = "节点38";
            treeNode33.Text = "周转图";
            treeNode34.Name = "节点39";
            treeNode34.Text = "维修计划";
            treeNode35.Name = "节点10";
            treeNode35.Text = "动车组运用要素";
            treeNode36.Name = "节点40";
            treeNode36.Text = "乘务制度";
            treeNode37.Name = "节点41";
            treeNode37.Text = "乘务数量";
            treeNode38.Name = "节点42";
            treeNode38.Text = "乘务交路";
            treeNode39.Name = "节点11";
            treeNode39.Text = "乘务计划要素";
            treeNode40.Name = "节点1";
            treeNode40.Text = "运输计划";
            treeNode41.BackColor = System.Drawing.Color.White;
            treeNode41.Checked = true;
            treeNode41.Name = "节点0";
            treeNode41.Text = "高速铁路能力要素集";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41});
            this.TreeView1.Size = new System.Drawing.Size(247, 539);
            this.TreeView1.TabIndex = 4;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick_1);
            // 
            // FrmElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 637);
            this.Controls.Add(this.TreeView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmElement";
            this.Text = "FrmElement";
            this.Load += new System.EventHandler(this.FrmElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView TreeView1;
    }
}