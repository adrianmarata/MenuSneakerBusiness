namespace MenuSneakerBusiness
{
    partial class PointOfSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSale));
            panelCartDetails = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            SKU = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            STYLECODE = new DataGridViewTextBoxColumn();
            panelSearch = new Panel();
            panelUnderLineSearch = new Panel();
            textBoxSearchInput = new TextBox();
            buttonSearch = new Button();
            panelCartDetails.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelCartDetails
            // 
            panelCartDetails.BackColor = Color.FromArgb(242, 190, 167);
            panelCartDetails.Controls.Add(panel1);
            panelCartDetails.Controls.Add(pictureBox1);
            panelCartDetails.Controls.Add(dataGridView1);
            panelCartDetails.Controls.Add(button1);
            panelCartDetails.Controls.Add(label1);
            panelCartDetails.Dock = DockStyle.Right;
            panelCartDetails.Location = new Point(1328, 0);
            panelCartDetails.Margin = new Padding(3, 2, 3, 2);
            panelCartDetails.Name = "panelCartDetails";
            panelCartDetails.Size = new Size(336, 662);
            panelCartDetails.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 468);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 176);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(64, 100);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(159, 50);
            button2.TabIndex = 1;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(122, 36);
            label2.TabIndex = 0;
            label2.Text = "Total: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 50);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 93);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(292, 312);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(217, 50);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 1;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(109, 46);
            label1.TabIndex = 0;
            label1.Text = "Cart";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 6;
            SKU.Name = "SKU";
            SKU.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "STYLECODE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "SKU";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // STYLECODE
            // 
            STYLECODE.HeaderText = "STYLECODE";
            STYLECODE.MinimumWidth = 6;
            STYLECODE.Name = "STYLECODE";
            STYLECODE.ReadOnly = true;
            STYLECODE.Width = 125;
            // 
            // panelSearch
            // 
            panelSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSearch.BackColor = Color.FromArgb(242, 190, 167);
            panelSearch.Controls.Add(panelUnderLineSearch);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(4, 3, 4, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1328, 56);
            panelSearch.TabIndex = 1;
            panelSearch.TabStop = true;
            // 
            // panelUnderLineSearch
            // 
            panelUnderLineSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUnderLineSearch.BackColor = SystemColors.MenuText;
            panelUnderLineSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelUnderLineSearch.Location = new Point(181, 52);
            panelUnderLineSearch.Margin = new Padding(3, 2, 3, 2);
            panelUnderLineSearch.Name = "panelUnderLineSearch";
            panelUnderLineSearch.Size = new Size(1154, 2);
            panelUnderLineSearch.TabIndex = 1;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.BackColor = Color.FromArgb(242, 190, 167);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(181, 11);
            textBoxSearchInput.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Brand Name or SKU";
            textBoxSearchInput.Size = new Size(1142, 39);
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
            buttonSearch.Image = Properties.Resources.iconsearch;
            buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(174, 56);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelSearch);
            Controls.Add(panelCartDetails);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PointOfSale";
            Size = new Size(1664, 662);
            panelCartDetails.ResumeLayout(false);
            panelCartDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCartDetails;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Label label2;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn STYLECODE;
        private Panel panelSearch;
        private Panel panelUnderLineSearch;
        private TextBox textBoxSearchInput;
        private Button buttonSearch;
    }
}
