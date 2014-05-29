namespace AmapTileSlicing
{
    partial class Main
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslPicPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtMaxLevel = new System.Windows.Forms.TextBox();
            this.txtMinLevel = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJoinPic = new System.Windows.Forms.Button();
            this.btnSlicingPic = new System.Windows.Forms.Button();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPicPath});
            this.statusStrip.Location = new System.Drawing.Point(0, 267);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(404, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsslPicPath
            // 
            this.tsslPicPath.Name = "tsslPicPath";
            this.tsslPicPath.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Controls.Add(this.txtMaxLevel);
            this.panel1.Controls.Add(this.txtMinLevel);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnJoinPic);
            this.panel1.Controls.Add(this.btnSlicingPic);
            this.panel1.Controls.Add(this.btnSelectPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 64);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最大层级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "最小层级";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(333, 32);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 21);
            this.txtY.TabIndex = 2;
            this.txtY.Text = "0";
            // 
            // txtMaxLevel
            // 
            this.txtMaxLevel.Location = new System.Drawing.Point(186, 32);
            this.txtMaxLevel.Name = "txtMaxLevel";
            this.txtMaxLevel.Size = new System.Drawing.Size(50, 21);
            this.txtMaxLevel.TabIndex = 2;
            this.txtMaxLevel.Text = "18";
            // 
            // txtMinLevel
            // 
            this.txtMinLevel.Location = new System.Drawing.Point(71, 32);
            this.txtMinLevel.Name = "txtMinLevel";
            this.txtMinLevel.Size = new System.Drawing.Size(50, 21);
            this.txtMinLevel.TabIndex = 2;
            this.txtMinLevel.Text = "13";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(260, 32);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 21);
            this.txtX.TabIndex = 2;
            this.txtX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // btnJoinPic
            // 
            this.btnJoinPic.Location = new System.Drawing.Point(174, 3);
            this.btnJoinPic.Name = "btnJoinPic";
            this.btnJoinPic.Size = new System.Drawing.Size(75, 23);
            this.btnJoinPic.TabIndex = 0;
            this.btnJoinPic.Text = "拼接图片";
            this.btnJoinPic.UseVisualStyleBackColor = true;
            this.btnJoinPic.Click += new System.EventHandler(this.btnJoinPic_Click);
            // 
            // btnSlicingPic
            // 
            this.btnSlicingPic.Location = new System.Drawing.Point(93, 3);
            this.btnSlicingPic.Name = "btnSlicingPic";
            this.btnSlicingPic.Size = new System.Drawing.Size(75, 23);
            this.btnSlicingPic.TabIndex = 0;
            this.btnSlicingPic.Text = "切割图片";
            this.btnSlicingPic.UseVisualStyleBackColor = true;
            this.btnSlicingPic.Click += new System.EventHandler(this.btnSlicingPic_Click);
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Location = new System.Drawing.Point(12, 3);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPic.TabIndex = 0;
            this.btnSelectPic.Text = "选择图片";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原图";
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb1.Location = new System.Drawing.Point(3, 17);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(194, 183);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(200, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 203);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新图";
            // 
            // pb2
            // 
            this.pb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb2.Location = new System.Drawing.Point(3, 17);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(194, 183);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片切割";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslPicPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.Button btnSlicingPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnJoinPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxLevel;
    }
}

