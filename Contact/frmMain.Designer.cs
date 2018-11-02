namespace Contact
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearchContainer = new System.Windows.Forms.Panel();
            this.lblSearchUnderline = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picToggleMenu = new System.Windows.Forms.PictureBox();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picDeveloper = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCtrlContainer = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToggleMenu)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeveloper)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlCtrlContainer.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.pnlSearchContainer);
            this.pnlHeader.Controls.Add(this.picToggleMenu);
            this.pnlHeader.Controls.Add(this.pnlUserInfo);
            this.pnlHeader.Controls.Add(this.txtCaption);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(746, 46);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.TabStop = true;
            // 
            // pnlSearchContainer
            // 
            this.pnlSearchContainer.Controls.Add(this.lblSearchUnderline);
            this.pnlSearchContainer.Controls.Add(this.txtSearch);
            this.pnlSearchContainer.Controls.Add(this.picSearch);
            this.pnlSearchContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearchContainer.Location = new System.Drawing.Point(354, 0);
            this.pnlSearchContainer.Name = "pnlSearchContainer";
            this.pnlSearchContainer.Size = new System.Drawing.Size(218, 46);
            this.pnlSearchContainer.TabIndex = 6;
            // 
            // lblSearchUnderline
            // 
            this.lblSearchUnderline.AutoSize = true;
            this.lblSearchUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSearchUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUnderline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearchUnderline.Location = new System.Drawing.Point(2, 37);
            this.lblSearchUnderline.Name = "lblSearchUnderline";
            this.lblSearchUnderline.Size = new System.Drawing.Size(183, 4);
            this.lblSearchUnderline.TabIndex = 5;
            this.lblSearchUnderline.Text = "_________________________________________________________________________________" +
    "_________";
            this.lblSearchUnderline.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Location = new System.Drawing.Point(1, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 25);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = global::Contact.Properties.Resources.search;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSearch.Location = new System.Drawing.Point(182, 9);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(30, 30);
            this.picSearch.TabIndex = 3;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // picToggleMenu
            // 
            this.picToggleMenu.Image = ((System.Drawing.Image)(resources.GetObject("picToggleMenu.Image")));
            this.picToggleMenu.Location = new System.Drawing.Point(193, 8);
            this.picToggleMenu.Name = "picToggleMenu";
            this.picToggleMenu.Size = new System.Drawing.Size(30, 30);
            this.picToggleMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToggleMenu.TabIndex = 2;
            this.picToggleMenu.TabStop = false;
            this.picToggleMenu.Click += new System.EventHandler(this.picToggleMenu_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserInfo.Controls.Add(this.picUserIcon);
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserInfo.Location = new System.Drawing.Point(572, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(174, 46);
            this.pnlUserInfo.TabIndex = 1;
            this.pnlUserInfo.Click += new System.EventHandler(this.ShowOptions);
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::Contact.Properties.Resources.person_white;
            this.picUserIcon.Location = new System.Drawing.Point(4, 11);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(25, 25);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserIcon.TabIndex = 3;
            this.picUserIcon.TabStop = false;
            this.picUserIcon.Click += new System.EventHandler(this.ShowOptions);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(36, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(128, 21);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Bhuban Shrestha";
            this.lblUserName.Click += new System.EventHandler(this.ShowOptions);
            // 
            // txtCaption
            // 
            this.txtCaption.AutoSize = true;
            this.txtCaption.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.ForeColor = System.Drawing.Color.White;
            this.txtCaption.Location = new System.Drawing.Point(3, 1);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(184, 44);
            this.txtCaption.TabIndex = 0;
            this.txtCaption.Text = "My Contact";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnNewGroup);
            this.pnlMenu.Controls.Add(this.btnAddNew);
            this.pnlMenu.Controls.Add(this.btnContact);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 46);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(223, 361);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.TabStop = true;
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGroup.Image")));
            this.btnNewGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGroup.Location = new System.Drawing.Point(0, 135);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(223, 45);
            this.btnNewGroup.TabIndex = 3;
            this.btnNewGroup.Text = "Add Group";
            this.btnNewGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewGroup.UseVisualStyleBackColor = false;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNew.Image = global::Contact.Properties.Resources.person_white;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(0, 90);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(223, 45);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New Contact";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Transparent;
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContact.Image = global::Contact.Properties.Resources.contactbook_white;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 45);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(223, 45);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contacts";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.picDeveloper);
            this.panel5.Controls.Add(this.lblDeveloper);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 71);
            this.panel5.TabIndex = 6;
            this.panel5.TabStop = true;
            // 
            // picDeveloper
            // 
            this.picDeveloper.Dock = System.Windows.Forms.DockStyle.Left;
            this.picDeveloper.Image = global::Contact.Properties.Resources._2bbujtW__400x400;
            this.picDeveloper.Location = new System.Drawing.Point(0, 0);
            this.picDeveloper.Name = "picDeveloper";
            this.picDeveloper.Size = new System.Drawing.Size(75, 71);
            this.picDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeveloper.TabIndex = 2;
            this.picDeveloper.TabStop = false;
            this.picDeveloper.Visible = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(0, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(223, 71);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Design By Bhuban Shrestha";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = global::Contact.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(223, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlCtrlContainer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(223, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 361);
            this.panel3.TabIndex = 2;
            // 
            // pnlCtrlContainer
            // 
            this.pnlCtrlContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCtrlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCtrlContainer.Controls.Add(this.pnlOptions);
            this.pnlCtrlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlContainer.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCtrlContainer.Name = "pnlCtrlContainer";
            this.pnlCtrlContainer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlCtrlContainer.Size = new System.Drawing.Size(523, 361);
            this.pnlCtrlContainer.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnProfile);
            this.pnlOptions.Controls.Add(this.btnChangePassword);
            this.pnlOptions.Location = new System.Drawing.Point(335, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnlOptions.Size = new System.Drawing.Size(185, 101);
            this.pnlOptions.TabIndex = 1;
            this.pnlOptions.Visible = false;
            this.pnlOptions.Leave += new System.EventHandler(this.pnlOptions_MouseLeave);
            this.pnlOptions.MouseLeave += new System.EventHandler(this.pnlOptions_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.Location = new System.Drawing.Point(2, 62);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 31);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "  Sign Off";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProfile.Location = new System.Drawing.Point(2, 31);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(181, 31);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "  Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = global::Contact.Properties.Resources._lock;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(2, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(181, 31);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "  Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 407);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearchContainer.ResumeLayout(false);
            this.pnlSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToggleMenu)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeveloper)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlCtrlContainer.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlCtrlContainer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label txtCaption;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.PictureBox picToggleMenu;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.PictureBox picDeveloper;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchUnderline;
        private System.Windows.Forms.Panel pnlSearchContainer;
    }
}

