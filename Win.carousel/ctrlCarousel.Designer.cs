namespace Win.Carousel
{
    partial class ctrlCarousel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prog = new System.Windows.Forms.ProgressBar();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.BackColor = System.Drawing.Color.White;
            this.lblDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDashBoard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.Location = new System.Drawing.Point(0, 0);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDashBoard.Size = new System.Drawing.Size(525, 43);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prog);
            this.panel2.Controls.Add(this.pic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 257);
            this.panel2.TabIndex = 2;
            // 
            // prog
            // 
            this.prog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prog.Location = new System.Drawing.Point(0, 252);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(525, 5);
            this.prog.Step = 100;
            this.prog.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(525, 257);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // ctrlCarousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlCarousel";
            this.Size = new System.Drawing.Size(525, 300);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDashBoard;
        internal System.Windows.Forms.ProgressBar prog;
    }
}
