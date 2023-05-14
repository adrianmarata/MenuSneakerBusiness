namespace MenuSneakerBusiness
{
    partial class Inventory
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
            panelSearch = new Panel();
            pictureBoxSearch = new PictureBox();
            buttonAddItem = new Button();
            textBoxSearchInput = new TextBox();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(192, 254, 204);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Controls.Add(buttonAddItem);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(5, 4, 5, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(890, 57);
            panelSearch.TabIndex = 0;
            panelSearch.TabStop = true;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Dock = DockStyle.Left;
            pictureBoxSearch.Image = Properties.Resources.icons8_search_52;
            pictureBoxSearch.Location = new Point(0, 0);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(52, 57);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearch.TabIndex = 3;
            pictureBoxSearch.TabStop = false;
            // 
            // buttonAddItem
            // 
            buttonAddItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddItem.BackColor = Color.Transparent;
            buttonAddItem.Dock = DockStyle.Right;
            buttonAddItem.FlatAppearance.BorderColor = Color.FromArgb(192, 254, 204);
            buttonAddItem.FlatAppearance.BorderSize = 2;
            buttonAddItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 211, 254);
            buttonAddItem.FlatStyle = FlatStyle.Flat;
            buttonAddItem.Image = Properties.Resources.iconadd;
            buttonAddItem.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddItem.Location = new Point(723, 0);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(167, 57);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddItem.UseVisualStyleBackColor = false;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchInput.BackColor = Color.FromArgb(192, 254, 204);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 28F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(55, 0);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Brandname or SKU";
            textBoxSearchInput.Size = new Size(662, 46);
            textBoxSearchInput.TabIndex = 1;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelSearch);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Inventory";
            Size = new Size(890, 608);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private TextBox textBoxSearchInput;
        private Button buttonAddItem;
        private PictureBox pictureBoxSearch;
    }
}
