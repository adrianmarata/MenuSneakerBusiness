namespace MenuSneakerBusiness
{
    partial class Consignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consignment));
            panelSearch = new Panel();
            buttonAddConsignor = new Button();
            panelUnderLineSearch = new Panel();
            textBoxSearchInput = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(242, 190, 167);
            panelSearch.Controls.Add(buttonAddConsignor);
            panelSearch.Controls.Add(panelUnderLineSearch);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(5, 4, 5, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1902, 75);
            panelSearch.TabIndex = 1;
            panelSearch.TabStop = true;
            // 
            // buttonAddConsignor
            // 
            buttonAddConsignor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddConsignor.BackColor = Color.Transparent;
            buttonAddConsignor.Dock = DockStyle.Right;
            buttonAddConsignor.FlatAppearance.BorderColor = Color.White;
            buttonAddConsignor.FlatAppearance.BorderSize = 2;
            buttonAddConsignor.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 207, 192);
            buttonAddConsignor.FlatStyle = FlatStyle.Flat;
            buttonAddConsignor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddConsignor.Image = (Image)resources.GetObject("buttonAddConsignor.Image");
            buttonAddConsignor.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddConsignor.Location = new Point(1660, 0);
            buttonAddConsignor.Name = "buttonAddConsignor";
            buttonAddConsignor.Size = new Size(242, 75);
            buttonAddConsignor.TabIndex = 2;
            buttonAddConsignor.Text = "Add Consignor";
            buttonAddConsignor.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddConsignor.UseVisualStyleBackColor = false;
            buttonAddConsignor.Click += buttonAddConsignor_Click;
            // 
            // panelUnderLineSearch
            // 
            panelUnderLineSearch.BackColor = SystemColors.MenuText;
            panelUnderLineSearch.Location = new Point(207, 69);
            panelUnderLineSearch.Name = "panelUnderLineSearch";
            panelUnderLineSearch.Size = new Size(1447, 3);
            panelUnderLineSearch.TabIndex = 1;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.BackColor = Color.FromArgb(242, 190, 167);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(207, 15);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Name";
            textBoxSearchInput.Size = new Size(1447, 49);
            textBoxSearchInput.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Transparent;
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 207, 192);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ActiveCaptionText;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(5, 4, 5, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(199, 75);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1902, 808);
            dataGridView1.TabIndex = 2;
            // 
            // Consignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelSearch);
            Name = "Consignment";
            Size = new Size(1902, 883);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Button buttonAddConsignor;
        private Panel panelUnderLineSearch;
        private TextBox textBoxSearchInput;
        private Button buttonSearch;
        private DataGridView dataGridView1;
    }
}
