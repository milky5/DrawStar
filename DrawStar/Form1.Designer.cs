namespace DrawStar
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVertex1 = new System.Windows.Forms.Label();
            this.lblVertex2 = new System.Windows.Forms.Label();
            this.lblVertex3 = new System.Windows.Forms.Label();
            this.lblVertex5 = new System.Windows.Forms.Label();
            this.lblVertex4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVertex1
            // 
            this.lblVertex1.AutoSize = true;
            this.lblVertex1.BackColor = System.Drawing.Color.Transparent;
            this.lblVertex1.Location = new System.Drawing.Point(66, 230);
            this.lblVertex1.Name = "lblVertex1";
            this.lblVertex1.Size = new System.Drawing.Size(17, 12);
            this.lblVertex1.TabIndex = 0;
            this.lblVertex1.Text = "○";
            this.lblVertex1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseDown);
            this.lblVertex1.MouseEnter += new System.EventHandler(this.lblVertex_MouseEnter);
            this.lblVertex1.MouseLeave += new System.EventHandler(this.lblVertex_MouseLeave);
            this.lblVertex1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseMove);
            this.lblVertex1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseUp);
            // 
            // lblVertex2
            // 
            this.lblVertex2.AutoSize = true;
            this.lblVertex2.BackColor = System.Drawing.Color.Transparent;
            this.lblVertex2.Location = new System.Drawing.Point(134, 22);
            this.lblVertex2.Name = "lblVertex2";
            this.lblVertex2.Size = new System.Drawing.Size(17, 12);
            this.lblVertex2.TabIndex = 1;
            this.lblVertex2.Text = "○";
            this.lblVertex2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseDown);
            this.lblVertex2.MouseEnter += new System.EventHandler(this.lblVertex_MouseEnter);
            this.lblVertex2.MouseLeave += new System.EventHandler(this.lblVertex_MouseLeave);
            this.lblVertex2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseMove);
            this.lblVertex2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseUp);
            // 
            // lblVertex3
            // 
            this.lblVertex3.AutoSize = true;
            this.lblVertex3.BackColor = System.Drawing.Color.Transparent;
            this.lblVertex3.Location = new System.Drawing.Point(202, 230);
            this.lblVertex3.Name = "lblVertex3";
            this.lblVertex3.Size = new System.Drawing.Size(17, 12);
            this.lblVertex3.TabIndex = 2;
            this.lblVertex3.Text = "○";
            this.lblVertex3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseDown);
            this.lblVertex3.MouseEnter += new System.EventHandler(this.lblVertex_MouseEnter);
            this.lblVertex3.MouseLeave += new System.EventHandler(this.lblVertex_MouseLeave);
            this.lblVertex3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseMove);
            this.lblVertex3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseUp);
            // 
            // lblVertex5
            // 
            this.lblVertex5.AutoSize = true;
            this.lblVertex5.BackColor = System.Drawing.Color.Transparent;
            this.lblVertex5.Location = new System.Drawing.Point(246, 100);
            this.lblVertex5.Name = "lblVertex5";
            this.lblVertex5.Size = new System.Drawing.Size(17, 12);
            this.lblVertex5.TabIndex = 3;
            this.lblVertex5.Text = "○";
            this.lblVertex5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseDown);
            this.lblVertex5.MouseEnter += new System.EventHandler(this.lblVertex_MouseEnter);
            this.lblVertex5.MouseLeave += new System.EventHandler(this.lblVertex_MouseLeave);
            this.lblVertex5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseMove);
            this.lblVertex5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseUp);
            // 
            // lblVertex4
            // 
            this.lblVertex4.AutoSize = true;
            this.lblVertex4.BackColor = System.Drawing.Color.Transparent;
            this.lblVertex4.Location = new System.Drawing.Point(23, 100);
            this.lblVertex4.Name = "lblVertex4";
            this.lblVertex4.Size = new System.Drawing.Size(17, 12);
            this.lblVertex4.TabIndex = 4;
            this.lblVertex4.Text = "○";
            this.lblVertex4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseDown);
            this.lblVertex4.MouseEnter += new System.EventHandler(this.lblVertex_MouseEnter);
            this.lblVertex4.MouseLeave += new System.EventHandler(this.lblVertex_MouseLeave);
            this.lblVertex4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseMove);
            this.lblVertex4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVertex_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 261);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblVertex4);
            this.Controls.Add(this.lblVertex5);
            this.Controls.Add(this.lblVertex3);
            this.Controls.Add(this.lblVertex2);
            this.Controls.Add(this.lblVertex1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVertex1;
        private System.Windows.Forms.Label lblVertex2;
        private System.Windows.Forms.Label lblVertex3;
        private System.Windows.Forms.Label lblVertex5;
        private System.Windows.Forms.Label lblVertex4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

