namespace HighspeedNetworkEchartsTest1
{
    partial class HighspeedRailwayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighspeedRailwayFrm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.Lable = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据管理DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.能力要素管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.能力计算CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.这里没有什么帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1005, 1162);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 37);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "北京南站";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lable.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Lable.Location = new System.Drawing.Point(35, 52);
            this.Lable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(302, 28);
            this.Lable.TabIndex = 1;
            this.Lable.Text = "高铁换乘客流统计模块";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(554, 100);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1709, 1052);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(37, 35);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1656, 1052);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(2310, 100);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(37, 35);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(517, 502);
            this.webBrowser2.TabIndex = 3;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(2310, 686);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(37, 35);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(517, 466);
            this.webBrowser3.TabIndex = 4;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(35, 100);
            this.webBrowser4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(37, 35);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(482, 502);
            this.webBrowser4.TabIndex = 5;
            this.webBrowser4.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser4_DocumentCompleted);
            // 
            // webBrowser5
            // 
            this.webBrowser5.Location = new System.Drawing.Point(35, 686);
            this.webBrowser5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(37, 35);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(482, 466);
            this.webBrowser5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(35, 651);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "铁路票务信息管理模块";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(2306, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "高铁能力要素管理模块";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(2306, 651);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "高铁票价与客流需求预测模块";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(603, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "高铁能力网络可视化模块";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2873, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 38);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(288, 34);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.数据管理DToolStripMenuItem,
            this.能力计算CToolStripMenuItem,
            this.窗口WToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2873, 40);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.关闭CToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.文件FToolStripMenuItem.Text = "文件(F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(202, 40);
            this.新建NToolStripMenuItem.Text = "新建(N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(202, 40);
            this.打开OToolStripMenuItem.Text = "打开(O)";
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(202, 40);
            this.关闭CToolStripMenuItem.Text = "关闭(C)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(202, 40);
            this.退出XToolStripMenuItem.Text = "退出(X)";
            // 
            // 数据管理DToolStripMenuItem
            // 
            this.数据管理DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.能力要素管理ToolStripMenuItem});
            this.数据管理DToolStripMenuItem.Name = "数据管理DToolStripMenuItem";
            this.数据管理DToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.数据管理DToolStripMenuItem.Text = "数据管理(D)";
            // 
            // 能力要素管理ToolStripMenuItem
            // 
            this.能力要素管理ToolStripMenuItem.Name = "能力要素管理ToolStripMenuItem";
            this.能力要素管理ToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.能力要素管理ToolStripMenuItem.Text = "能力要素管理";
            this.能力要素管理ToolStripMenuItem.Click += new System.EventHandler(this.能力要素管理ToolStripMenuItem_Click);
            // 
            // 能力计算CToolStripMenuItem
            // 
            this.能力计算CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.运行图ToolStripMenuItem});
            this.能力计算CToolStripMenuItem.Name = "能力计算CToolStripMenuItem";
            this.能力计算CToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.能力计算CToolStripMenuItem.Text = "能力计算(C)";
            // 
            // 运行图ToolStripMenuItem
            // 
            this.运行图ToolStripMenuItem.Name = "运行图ToolStripMenuItem";
            this.运行图ToolStripMenuItem.Size = new System.Drawing.Size(192, 40);
            this.运行图ToolStripMenuItem.Text = "运行图";
            this.运行图ToolStripMenuItem.Click += new System.EventHandler(this.运行图ToolStripMenuItem_Click);
            // 
            // 窗口WToolStripMenuItem
            // 
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            this.窗口WToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.窗口WToolStripMenuItem.Text = "窗口(W)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.这里没有什么帮助ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 这里没有什么帮助ToolStripMenuItem
            // 
            this.这里没有什么帮助ToolStripMenuItem.Name = "这里没有什么帮助ToolStripMenuItem";
            this.这里没有什么帮助ToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.这里没有什么帮助ToolStripMenuItem.Text = "这里没有什么帮助";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(607, 1162);
            this.btn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(182, 40);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "高铁线路示意图";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(1239, 1162);
            this.btnSim.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(138, 40);
            this.btnSim.TabIndex = 15;
            this.btnSim.Text = "在线运行图";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(1472, 1162);
            this.btnAny.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(138, 40);
            this.btnAny.TabIndex = 16;
            this.btnAny.Text = "站网分析";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // HighspeedRailwayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2873, 1320);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser5);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HighspeedRailwayFrm";
            this.Text = "高速铁路能力要素管理信息系统";
            this.Load += new System.EventHandler(this.HighspeedRailwayFrm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.WebBrowser webBrowser5;
 //       private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据管理DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 能力计算CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 这里没有什么帮助ToolStripMenuItem;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ToolStripMenuItem 运行图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 能力要素管理ToolStripMenuItem;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnAny;
    }
}

