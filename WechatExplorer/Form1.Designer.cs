namespace WechatExplorer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 555);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(278, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 556);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(506, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 556);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1213, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 645);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

