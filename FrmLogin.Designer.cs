namespace Winform.Animation.Train
{
    partial class FrmLogin
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BTStart = new System.Windows.Forms.Button();
            this.BTStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.animTrainLoadingPartial1 = new Winform.Animation.Train.Animation.AnimTrainLoadingPartial();
            this.SuspendLayout();
            // 
            // BTStart
            // 
            this.BTStart.Location = new System.Drawing.Point(924, 499);
            this.BTStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(183, 40);
            this.BTStart.TabIndex = 1;
            this.BTStart.Text = "登陆";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // BTStop
            // 
            this.BTStop.Location = new System.Drawing.Point(1177, 499);
            this.BTStop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTStop.Name = "BTStop";
            this.BTStop.Size = new System.Drawing.Size(183, 40);
            this.BTStop.TabIndex = 2;
            this.BTStop.Text = "退出";
            this.BTStop.UseVisualStyleBackColor = true;
            this.BTStop.Click += new System.EventHandler(this.BTStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1049, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1049, 231);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 31);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(939, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(939, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 7;
            // 
            // animTrainLoadingPartial1
            // 
            this.animTrainLoadingPartial1.BackColor = System.Drawing.Color.White;
            this.animTrainLoadingPartial1.Location = new System.Drawing.Point(22, 21);
            this.animTrainLoadingPartial1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.animTrainLoadingPartial1.Name = "animTrainLoadingPartial1";
            this.animTrainLoadingPartial1.Size = new System.Drawing.Size(827, 457);
            this.animTrainLoadingPartial1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTStop);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.animTrainLoadingPartial1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Animation.AnimTrainLoadingPartial animTrainLoadingPartial1;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.Button BTStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

