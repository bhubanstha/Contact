namespace Contact
{
    partial class frmGMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGMap));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlGMap = new GMap.NET.WindowsForms.GMapControl();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblAddress);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(763, 40);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(593, 40);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::Contact.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(738, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 40);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlGMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 408);
            this.panel2.TabIndex = 1;
            // 
            // ctrlGMap
            // 
            this.ctrlGMap.Bearing = 0F;
            this.ctrlGMap.CanDragMap = true;
            this.ctrlGMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlGMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.ctrlGMap.GrayScaleMode = false;
            this.ctrlGMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.ctrlGMap.LevelsKeepInMemmory = 5;
            this.ctrlGMap.Location = new System.Drawing.Point(0, 0);
            this.ctrlGMap.MarkersEnabled = true;
            this.ctrlGMap.MaxZoom = 30;
            this.ctrlGMap.MinZoom = 10;
            this.ctrlGMap.MouseWheelZoomEnabled = true;
            this.ctrlGMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.ctrlGMap.Name = "ctrlGMap";
            this.ctrlGMap.NegativeMode = false;
            this.ctrlGMap.PolygonsEnabled = true;
            this.ctrlGMap.RetryLoadTile = 0;
            this.ctrlGMap.RoutesEnabled = true;
            this.ctrlGMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.ctrlGMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.ctrlGMap.ShowTileGridLines = false;
            this.ctrlGMap.Size = new System.Drawing.Size(763, 408);
            this.ctrlGMap.TabIndex = 0;
            this.ctrlGMap.Zoom = 14D;
            // 
            // frmGMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGMap";
            this.Text = "frmGMap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGMap_FormClosing);
            this.Load += new System.EventHandler(this.frmGMap_Load);
            this.Shown += new System.EventHandler(this.frmGMap_Shown);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private GMap.NET.WindowsForms.GMapControl ctrlGMap;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblAddress;
    }
}