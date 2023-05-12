namespace MenuSneakerBusiness
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            panelDashboard = new Panel();
            pictureBoxMBS = new PictureBox();
            pictureBoxInstagram = new PictureBox();
            pictureBoxFacebook = new PictureBox();
            buttonFinancial = new Button();
            buttonPOS = new Button();
            buttonConsignment = new Button();
            buttonInventory = new Button();
            menuDashboardLogo = new PictureBox();
            labelPosition = new Label();
            labelEmployeeName = new Label();
            panelTop = new Panel();
            pictureBoxMaximized = new PictureBox();
            pictureBoxMinimized = new PictureBox();
            pictureBoxExit = new PictureBox();
            currentForm = new Label();
            pictureBoxCurrentForm = new PictureBox();
            panelContents = new Panel();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximized).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimized).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentForm).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.BackgroundImage = Properties.Resources.COLOR_BG;
            panelDashboard.Controls.Add(pictureBoxMBS);
            panelDashboard.Controls.Add(pictureBoxInstagram);
            panelDashboard.Controls.Add(pictureBoxFacebook);
            panelDashboard.Controls.Add(buttonFinancial);
            panelDashboard.Controls.Add(buttonPOS);
            panelDashboard.Controls.Add(buttonConsignment);
            panelDashboard.Controls.Add(buttonInventory);
            panelDashboard.Controls.Add(menuDashboardLogo);
            panelDashboard.Dock = DockStyle.Left;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(390, 720);
            panelDashboard.TabIndex = 0;
            // 
            // pictureBoxMBS
            // 
            pictureBoxMBS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxMBS.Image = Properties.Resources.icons8_meta_50;
            pictureBoxMBS.Location = new Point(184, 637);
            pictureBoxMBS.Name = "pictureBoxMBS";
            pictureBoxMBS.Size = new Size(50, 50);
            pictureBoxMBS.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxMBS.TabIndex = 7;
            pictureBoxMBS.TabStop = false;
            pictureBoxMBS.Click += pictureBoxMBS_Click;
            pictureBoxMBS.MouseEnter += pictureBoxMBS_MouseEnter;
            pictureBoxMBS.MouseLeave += pictureBoxMBS_MouseLeave;
            // 
            // pictureBoxInstagram
            // 
            pictureBoxInstagram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxInstagram.Image = Properties.Resources.icons8_instagram_50;
            pictureBoxInstagram.Location = new Point(110, 637);
            pictureBoxInstagram.Name = "pictureBoxInstagram";
            pictureBoxInstagram.Size = new Size(50, 50);
            pictureBoxInstagram.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxInstagram.TabIndex = 6;
            pictureBoxInstagram.TabStop = false;
            pictureBoxInstagram.Click += pictureBoxInstagram_Click;
            pictureBoxInstagram.MouseEnter += pictureBoxInstagram_MouseEnter;
            pictureBoxInstagram.MouseLeave += pictureBoxInstagram_MouseLeave;
            // 
            // pictureBoxFacebook
            // 
            pictureBoxFacebook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxFacebook.BackColor = Color.Transparent;
            pictureBoxFacebook.Image = Properties.Resources.icons8_facebook_50__1_;
            pictureBoxFacebook.Location = new Point(36, 637);
            pictureBoxFacebook.Name = "pictureBoxFacebook";
            pictureBoxFacebook.Size = new Size(50, 50);
            pictureBoxFacebook.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFacebook.TabIndex = 5;
            pictureBoxFacebook.TabStop = false;
            pictureBoxFacebook.Click += pictureBoxFacebook_Click;
            pictureBoxFacebook.MouseEnter += pictureBoxFacebook_MouseEnter;
            pictureBoxFacebook.MouseLeave += pictureBoxFacebook_MouseLeave;
            // 
            // buttonFinancial
            // 
            buttonFinancial.BackColor = Color.Transparent;
            buttonFinancial.Dock = DockStyle.Top;
            buttonFinancial.FlatAppearance.BorderSize = 0;
            buttonFinancial.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonFinancial.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonFinancial.FlatStyle = FlatStyle.Flat;
            buttonFinancial.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinancial.ForeColor = Color.White;
            buttonFinancial.Image = (Image)resources.GetObject("buttonFinancial.Image");
            buttonFinancial.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinancial.Location = new Point(0, 472);
            buttonFinancial.Name = "buttonFinancial";
            buttonFinancial.Padding = new Padding(25, 0, 0, 0);
            buttonFinancial.Size = new Size(390, 120);
            buttonFinancial.TabIndex = 4;
            buttonFinancial.Text = "Financial";
            buttonFinancial.TextAlign = ContentAlignment.MiddleLeft;
            buttonFinancial.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFinancial.UseVisualStyleBackColor = false;
            buttonFinancial.Click += buttonFinancial_Click;
            buttonFinancial.MouseEnter += buttonFinancial_MouseEnter;
            buttonFinancial.MouseLeave += buttonFinancial_MouseLeave;
            // 
            // buttonPOS
            // 
            buttonPOS.BackColor = Color.Transparent;
            buttonPOS.Dock = DockStyle.Top;
            buttonPOS.FlatAppearance.BorderSize = 0;
            buttonPOS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPOS.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonPOS.FlatStyle = FlatStyle.Flat;
            buttonPOS.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOS.ForeColor = Color.White;
            buttonPOS.Image = (Image)resources.GetObject("buttonPOS.Image");
            buttonPOS.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPOS.Location = new Point(0, 352);
            buttonPOS.Name = "buttonPOS";
            buttonPOS.Padding = new Padding(25, 0, 0, 0);
            buttonPOS.Size = new Size(390, 120);
            buttonPOS.TabIndex = 3;
            buttonPOS.Text = "Order";
            buttonPOS.TextAlign = ContentAlignment.MiddleLeft;
            buttonPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPOS.UseVisualStyleBackColor = false;
            buttonPOS.Click += buttonPOS_Click;
            buttonPOS.MouseEnter += buttonPOS_MouseEnter;
            buttonPOS.MouseLeave += buttonPOS_MouseLeave;
            // 
            // buttonConsignment
            // 
            buttonConsignment.BackColor = Color.Transparent;
            buttonConsignment.Dock = DockStyle.Top;
            buttonConsignment.FlatAppearance.BorderSize = 0;
            buttonConsignment.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonConsignment.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonConsignment.FlatStyle = FlatStyle.Flat;
            buttonConsignment.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsignment.ForeColor = Color.White;
            buttonConsignment.Image = (Image)resources.GetObject("buttonConsignment.Image");
            buttonConsignment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsignment.Location = new Point(0, 232);
            buttonConsignment.Name = "buttonConsignment";
            buttonConsignment.Padding = new Padding(25, 0, 0, 0);
            buttonConsignment.Size = new Size(390, 120);
            buttonConsignment.TabIndex = 2;
            buttonConsignment.Text = "Consignment";
            buttonConsignment.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsignment.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsignment.UseVisualStyleBackColor = false;
            buttonConsignment.Click += buttonConsignment_Click;
            buttonConsignment.MouseEnter += buttonConsignment_MouseEnter;
            buttonConsignment.MouseLeave += buttonConsignment_MouseLeave;
            // 
            // buttonInventory
            // 
            buttonInventory.BackColor = Color.Transparent;
            buttonInventory.Dock = DockStyle.Top;
            buttonInventory.FlatAppearance.BorderSize = 0;
            buttonInventory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonInventory.FlatStyle = FlatStyle.Flat;
            buttonInventory.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInventory.ForeColor = Color.White;
            buttonInventory.Image = (Image)resources.GetObject("buttonInventory.Image");
            buttonInventory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventory.Location = new Point(0, 112);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Padding = new Padding(25, 0, 0, 0);
            buttonInventory.RightToLeft = RightToLeft.No;
            buttonInventory.Size = new Size(390, 120);
            buttonInventory.TabIndex = 1;
            buttonInventory.Text = "Inventory";
            buttonInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventory.UseVisualStyleBackColor = false;
            buttonInventory.Click += buttonInventory_Click;
            buttonInventory.MouseEnter += buttonInventory_MouseEnter;
            buttonInventory.MouseLeave += buttonInventory_MouseLeave;
            // 
            // menuDashboardLogo
            // 
            menuDashboardLogo.BackColor = Color.Transparent;
            menuDashboardLogo.BackgroundImageLayout = ImageLayout.Center;
            menuDashboardLogo.Dock = DockStyle.Top;
            menuDashboardLogo.Image = Properties.Resources.MAIN_DASHBOARD_LOGO;
            menuDashboardLogo.Location = new Point(0, 0);
            menuDashboardLogo.Name = "menuDashboardLogo";
            menuDashboardLogo.Size = new Size(390, 112);
            menuDashboardLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            menuDashboardLogo.TabIndex = 0;
            menuDashboardLogo.TabStop = false;
            // 
            // labelPosition
            // 
            labelPosition.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPosition.AutoSize = true;
            labelPosition.BackColor = Color.Transparent;
            labelPosition.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(600, 80);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(74, 18);
            labelPosition.TabIndex = 4;
            labelPosition.Text = "Position";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.BackColor = Color.Transparent;
            labelEmployeeName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeName.ForeColor = Color.White;
            labelEmployeeName.Location = new Point(600, 55);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(140, 18);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Employee Name";
            // 
            // panelTop
            // 
            panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTop.BackgroundImage = Properties.Resources.COLOR_BG;
            panelTop.Controls.Add(pictureBoxMaximized);
            panelTop.Controls.Add(pictureBoxMinimized);
            panelTop.Controls.Add(pictureBoxExit);
            panelTop.Controls.Add(currentForm);
            panelTop.Controls.Add(labelEmployeeName);
            panelTop.Controls.Add(pictureBoxCurrentForm);
            panelTop.Controls.Add(labelPosition);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(390, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(890, 112);
            panelTop.TabIndex = 2;
            // 
            // pictureBoxMaximized
            // 
            pictureBoxMaximized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMaximized.BackColor = Color.Transparent;
            pictureBoxMaximized.Image = Properties.Resources.icons8_maximize_50__1_;
            pictureBoxMaximized.Location = new Point(783, 1);
            pictureBoxMaximized.Name = "pictureBoxMaximized";
            pictureBoxMaximized.Size = new Size(50, 50);
            pictureBoxMaximized.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxMaximized.TabIndex = 6;
            pictureBoxMaximized.TabStop = false;
            pictureBoxMaximized.Click += pictureBoxMaximized_Click;
            pictureBoxMaximized.MouseEnter += pictureBoxMaximized_MouseEnter;
            pictureBoxMaximized.MouseLeave += pictureBoxMaximized_MouseLeave;
            // 
            // pictureBoxMinimized
            // 
            pictureBoxMinimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimized.BackColor = Color.Transparent;
            pictureBoxMinimized.Image = Properties.Resources.icons8_minimize_window_50__1_;
            pictureBoxMinimized.Location = new Point(727, 1);
            pictureBoxMinimized.Name = "pictureBoxMinimized";
            pictureBoxMinimized.Size = new Size(50, 50);
            pictureBoxMinimized.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxMinimized.TabIndex = 0;
            pictureBoxMinimized.TabStop = false;
            pictureBoxMinimized.Click += pictureBox1_Click;
            pictureBoxMinimized.MouseEnter += pictureBoxMinimized_MouseEnter;
            pictureBoxMinimized.MouseLeave += pictureBoxMinimized_MouseLeave;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = Properties.Resources.icons8_exit_50__1_;
            pictureBoxExit.Location = new Point(839, 1);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(50, 50);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            pictureBoxExit.MouseEnter += pictureBoxExit_MouseEnter;
            pictureBoxExit.MouseLeave += pictureBoxExit_MouseLeave;
            // 
            // currentForm
            // 
            currentForm.AutoSize = true;
            currentForm.BackColor = Color.Transparent;
            currentForm.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            currentForm.ForeColor = Color.White;
            currentForm.Location = new Point(62, 77);
            currentForm.Name = "currentForm";
            currentForm.Size = new Size(72, 23);
            currentForm.TabIndex = 5;
            currentForm.Text = "Home";
            // 
            // pictureBoxCurrentForm
            // 
            pictureBoxCurrentForm.BackColor = Color.Transparent;
            pictureBoxCurrentForm.Image = (Image)resources.GetObject("pictureBoxCurrentForm.Image");
            pictureBoxCurrentForm.Location = new Point(6, 55);
            pictureBoxCurrentForm.Name = "pictureBoxCurrentForm";
            pictureBoxCurrentForm.Size = new Size(50, 50);
            pictureBoxCurrentForm.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCurrentForm.TabIndex = 4;
            pictureBoxCurrentForm.TabStop = false;
            // 
            // panelContents
            // 
            panelContents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContents.Dock = DockStyle.Fill;
            panelContents.Location = new Point(390, 112);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(890, 608);
            panelContents.TabIndex = 3;
            // 
            // MainDashboard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelContents);
            Controls.Add(panelTop);
            Controls.Add(panelDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.DimGray;
            FormClosed += MainDashboard_FormClosed;
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximized).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimized).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashboard;
        private PictureBox menuDashboardLogo;
        private Button buttonInventory;
        private Button buttonPOS;
        private Button buttonConsignment;
        private Label labelEmployeeName;
        private Label labelPosition;
        private Panel panelTop;
        private Label currentForm;
        private PictureBox pictureBoxCurrentForm;
        private Button buttonFinancial;
        private Panel panelContents;
        private PictureBox pictureBoxMinimized;
        private PictureBox pictureBoxExit;
        private PictureBox pictureBoxFacebook;
        private PictureBox pictureBoxMBS;
        private PictureBox pictureBoxInstagram;
        private PictureBox pictureBoxMaximized;
    }
}