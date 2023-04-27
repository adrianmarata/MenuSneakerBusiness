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
            labelPosition = new Label();
            labelEmployeeName = new Label();
            buttonPOS = new Button();
            buttonConsignment = new Button();
            buttonInventory = new Button();
            menuDashboardLogo = new PictureBox();
            panelContents = new Panel();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.BackgroundImage = (Image)resources.GetObject("panelDashboard.BackgroundImage");
            panelDashboard.Controls.Add(labelPosition);
            panelDashboard.Controls.Add(labelEmployeeName);
            panelDashboard.Controls.Add(buttonPOS);
            panelDashboard.Controls.Add(buttonConsignment);
            panelDashboard.Controls.Add(buttonInventory);
            panelDashboard.Controls.Add(menuDashboardLogo);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1902, 150);
            panelDashboard.TabIndex = 0;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(1620, 69);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(91, 25);
            labelPosition.TabIndex = 4;
            labelPosition.Text = "Position";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeName.ForeColor = Color.White;
            labelEmployeeName.Location = new Point(1620, 9);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(175, 25);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Employee Name";
            // 
            // buttonPOS
            // 
            buttonPOS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPOS.BackColor = Color.Transparent;
            buttonPOS.Dock = DockStyle.Left;
            buttonPOS.FlatAppearance.BorderSize = 0;
            buttonPOS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPOS.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonPOS.FlatStyle = FlatStyle.Flat;
            buttonPOS.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOS.ForeColor = Color.White;
            buttonPOS.Location = new Point(1164, 0);
            buttonPOS.Name = "buttonPOS";
            buttonPOS.Size = new Size(450, 150);
            buttonPOS.TabIndex = 3;
            buttonPOS.Text = "Point of Sale";
            buttonPOS.UseVisualStyleBackColor = false;
            // 
            // buttonConsignment
            // 
            buttonConsignment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConsignment.BackColor = Color.Transparent;
            buttonConsignment.Dock = DockStyle.Left;
            buttonConsignment.FlatAppearance.BorderSize = 0;
            buttonConsignment.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonConsignment.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonConsignment.FlatStyle = FlatStyle.Flat;
            buttonConsignment.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsignment.ForeColor = Color.White;
            buttonConsignment.Location = new Point(714, 0);
            buttonConsignment.Name = "buttonConsignment";
            buttonConsignment.Size = new Size(450, 150);
            buttonConsignment.TabIndex = 2;
            buttonConsignment.Text = "Consignment";
            buttonConsignment.UseVisualStyleBackColor = false;
            buttonConsignment.Click += buttonConsignment_Click;
            // 
            // buttonInventory
            // 
            buttonInventory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonInventory.BackColor = Color.Transparent;
            buttonInventory.Dock = DockStyle.Left;
            buttonInventory.FlatAppearance.BorderSize = 0;
            buttonInventory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonInventory.FlatStyle = FlatStyle.Flat;
            buttonInventory.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInventory.ForeColor = Color.White;
            buttonInventory.Location = new Point(264, 0);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Size = new Size(450, 150);
            buttonInventory.TabIndex = 1;
            buttonInventory.Text = "Inventory";
            buttonInventory.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonInventory.UseVisualStyleBackColor = false;
            buttonInventory.Click += buttonInventory_Click;
            // 
            // menuDashboardLogo
            // 
            menuDashboardLogo.BackColor = Color.Transparent;
            menuDashboardLogo.BackgroundImage = (Image)resources.GetObject("menuDashboardLogo.BackgroundImage");
            menuDashboardLogo.BackgroundImageLayout = ImageLayout.Center;
            menuDashboardLogo.Dock = DockStyle.Left;
            menuDashboardLogo.Location = new Point(0, 0);
            menuDashboardLogo.Name = "menuDashboardLogo";
            menuDashboardLogo.Size = new Size(264, 150);
            menuDashboardLogo.TabIndex = 0;
            menuDashboardLogo.TabStop = false;
            // 
            // panelContents
            // 
            panelContents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContents.BackColor = Color.White;
            panelContents.Dock = DockStyle.Fill;
            panelContents.Location = new Point(0, 150);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(1902, 883);
            panelContents.TabIndex = 1;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelContents);
            Controls.Add(panelDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.DimGray;
            WindowState = FormWindowState.Maximized;
            FormClosed += MainDashboard_FormClosed;
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashboard;
        private Panel panelContents;
        private PictureBox menuDashboardLogo;
        private Button buttonInventory;
        private Button buttonPOS;
        private Button buttonConsignment;
        private Label labelEmployeeName;
        private Label labelPosition;
    }
}