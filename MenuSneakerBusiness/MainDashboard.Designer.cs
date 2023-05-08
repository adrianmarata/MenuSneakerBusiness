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
            panelContents = new Panel();
            panelTop = new Panel();
            currentForm = new Label();
            pictureBoxCurrentForm = new PictureBox();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentForm).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.BackgroundImage = (Image)resources.GetObject("panelDashboard.BackgroundImage");
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
            buttonFinancial.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinancial.ForeColor = Color.White;
            buttonFinancial.Image = (Image)resources.GetObject("buttonFinancial.Image");
            buttonFinancial.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinancial.Location = new Point(0, 600);
            buttonFinancial.Name = "buttonFinancial";
            buttonFinancial.Padding = new Padding(15, 0, 0, 0);
            buttonFinancial.Size = new Size(390, 150);
            buttonFinancial.TabIndex = 4;
            buttonFinancial.Text = "Financial";
            buttonFinancial.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFinancial.UseVisualStyleBackColor = false;
            buttonFinancial.Click += buttonFinancial_Click;
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
            buttonPOS.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOS.ForeColor = Color.White;
            buttonPOS.Image = (Image)resources.GetObject("buttonPOS.Image");
            buttonPOS.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPOS.Location = new Point(0, 450);
            buttonPOS.Name = "buttonPOS";
            buttonPOS.Padding = new Padding(15, 0, 0, 0);
            buttonPOS.Size = new Size(390, 150);
            buttonPOS.TabIndex = 3;
            buttonPOS.Text = "Order";
            buttonPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPOS.UseVisualStyleBackColor = false;
            buttonPOS.Click += buttonPOS_Click;
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
            buttonConsignment.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsignment.ForeColor = Color.White;
            buttonConsignment.Image = (Image)resources.GetObject("buttonConsignment.Image");
            buttonConsignment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsignment.Location = new Point(0, 300);
            buttonConsignment.Name = "buttonConsignment";
            buttonConsignment.Padding = new Padding(15, 0, 0, 0);
            buttonConsignment.Size = new Size(390, 150);
            buttonConsignment.TabIndex = 2;
            buttonConsignment.Text = "Consignment";
            buttonConsignment.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsignment.UseVisualStyleBackColor = false;
            buttonConsignment.Click += buttonConsignment_Click;
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
            buttonInventory.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInventory.ForeColor = Color.White;
            buttonInventory.Image = (Image)resources.GetObject("buttonInventory.Image");
            buttonInventory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventory.Location = new Point(0, 150);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Padding = new Padding(15, 0, 0, 0);
            buttonInventory.RightToLeft = RightToLeft.No;
            buttonInventory.Size = new Size(390, 150);
            buttonInventory.TabIndex = 1;
            buttonInventory.Text = "Inventory";
            buttonInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventory.UseVisualStyleBackColor = false;
            buttonInventory.Click += buttonInventory_Click;
            // 
            // menuDashboardLogo
            // 
            menuDashboardLogo.BackColor = Color.Transparent;
            menuDashboardLogo.BackgroundImage = (Image)resources.GetObject("menuDashboardLogo.BackgroundImage");
            menuDashboardLogo.BackgroundImageLayout = ImageLayout.Center;
            menuDashboardLogo.Dock = DockStyle.Top;
            menuDashboardLogo.Location = new Point(0, 0);
            menuDashboardLogo.Name = "menuDashboardLogo";
            menuDashboardLogo.Size = new Size(390, 150);
            menuDashboardLogo.TabIndex = 0;
            menuDashboardLogo.TabStop = false;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.BackColor = Color.Transparent;
            labelPosition.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(1056, 46);
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
            labelEmployeeName.Location = new Point(1056, 21);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(175, 25);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Employee Name";
            // 
            // panelContents
            // 
            panelContents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContents.Dock = DockStyle.Bottom;
            panelContents.Location = new Point(390, 87);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(1512, 946);
            panelContents.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTop.BackgroundImage = (Image)resources.GetObject("panelTop.BackgroundImage");
            panelTop.Controls.Add(currentForm);
            panelTop.Controls.Add(pictureBoxCurrentForm);
            panelTop.Controls.Add(labelPosition);
            panelTop.Controls.Add(labelEmployeeName);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(390, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1512, 87);
            panelTop.TabIndex = 2;
            // 
            // currentForm
            // 
            currentForm.AutoSize = true;
            currentForm.BackColor = Color.Transparent;
            currentForm.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            currentForm.ForeColor = Color.White;
            currentForm.Location = new Point(62, 56);
            currentForm.Name = "currentForm";
            currentForm.Size = new Size(86, 28);
            currentForm.TabIndex = 5;
            currentForm.Text = "Home";
            // 
            // pictureBoxCurrentForm
            // 
            pictureBoxCurrentForm.BackColor = Color.Transparent;
            pictureBoxCurrentForm.Image = (Image)resources.GetObject("pictureBoxCurrentForm.Image");
            pictureBoxCurrentForm.Location = new Point(6, 34);
            pictureBoxCurrentForm.Name = "pictureBoxCurrentForm";
            pictureBoxCurrentForm.Size = new Size(50, 50);
            pictureBoxCurrentForm.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCurrentForm.TabIndex = 4;
            pictureBoxCurrentForm.TabStop = false;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelTop);
            Controls.Add(panelContents);
            Controls.Add(panelDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard";
            TransparencyKey = Color.DimGray;
            WindowState = FormWindowState.Maximized;
            FormClosed += MainDashboard_FormClosed;
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
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
        private Panel panelContents;
        private Panel panelTop;
        private Label currentForm;
        private PictureBox pictureBoxCurrentForm;
        private Button buttonFinancial;
    }
}