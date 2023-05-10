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
            buttonFinancial = new Button();
            buttonPOS = new Button();
            buttonConsignment = new Button();
            buttonInventory = new Button();
            menuDashboardLogo = new PictureBox();
            labelPosition = new Label();
            labelEmployeeName = new Label();
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxExit = new PictureBox();
            currentForm = new Label();
            pictureBoxCurrentForm = new PictureBox();
            panelContents = new Panel();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentForm).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.BackgroundImage = Properties.Resources.COLOR_BG;
            panelDashboard.Controls.Add(buttonFinancial);
            panelDashboard.Controls.Add(buttonPOS);
            panelDashboard.Controls.Add(buttonConsignment);
            panelDashboard.Controls.Add(buttonInventory);
            panelDashboard.Controls.Add(menuDashboardLogo);
            panelDashboard.Dock = DockStyle.Left;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(390, 1033);
            panelDashboard.TabIndex = 0;
            // 
            // buttonFinancial
            // 
            buttonFinancial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            buttonFinancial.Location = new Point(0, 601);
            buttonFinancial.Name = "buttonFinancial";
            buttonFinancial.Padding = new Padding(25, 0, 0, 0);
            buttonFinancial.Size = new Size(390, 150);
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
            buttonPOS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            buttonPOS.Location = new Point(0, 451);
            buttonPOS.Name = "buttonPOS";
            buttonPOS.Padding = new Padding(25, 0, 0, 0);
            buttonPOS.Size = new Size(390, 150);
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
            buttonConsignment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            buttonConsignment.Location = new Point(0, 301);
            buttonConsignment.Name = "buttonConsignment";
            buttonConsignment.Padding = new Padding(25, 0, 0, 0);
            buttonConsignment.Size = new Size(390, 150);
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
            buttonInventory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            buttonInventory.Location = new Point(0, 151);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Padding = new Padding(25, 0, 0, 0);
            buttonInventory.RightToLeft = RightToLeft.No;
            buttonInventory.Size = new Size(390, 150);
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
            menuDashboardLogo.Size = new Size(390, 151);
            menuDashboardLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            menuDashboardLogo.TabIndex = 0;
            menuDashboardLogo.TabStop = false;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.BackColor = Color.Transparent;
            labelPosition.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(1056, 77);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(91, 25);
            labelPosition.TabIndex = 4;
            labelPosition.Text = "Position";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.BackColor = Color.Transparent;
            labelEmployeeName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeName.ForeColor = Color.White;
            labelEmployeeName.Location = new Point(1056, 52);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(175, 25);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Employee Name";
            // 
            // panelTop
            // 
            panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTop.BackgroundImage = Properties.Resources.COLOR_BG;
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(pictureBoxExit);
            panelTop.Controls.Add(currentForm);
            panelTop.Controls.Add(labelEmployeeName);
            panelTop.Controls.Add(pictureBoxCurrentForm);
            panelTop.Controls.Add(labelPosition);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(390, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1512, 112);
            panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_minimize_window_50;
            pictureBox1.Location = new Point(1428, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = Properties.Resources.icons8_exit_50;
            pictureBoxExit.Location = new Point(1480, 3);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(50, 50);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // currentForm
            // 
            currentForm.AutoSize = true;
            currentForm.BackColor = Color.Transparent;
            currentForm.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            currentForm.ForeColor = Color.White;
            currentForm.Location = new Point(62, 77);
            currentForm.Name = "currentForm";
            currentForm.Size = new Size(86, 28);
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
            panelContents.Size = new Size(1512, 921);
            panelContents.TabIndex = 3;
            // 
            // MainDashboard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelContents);
            Controls.Add(panelTop);
            Controls.Add(panelDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.DimGray;
            WindowState = FormWindowState.Maximized;
            FormClosed += MainDashboard_FormClosed;
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBoxExit;
    }
}