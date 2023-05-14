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
            panelSearch = new Panel();
            textBoxSearchInput = new TextBox();
            pictureBoxSearch = new PictureBox();
            buttonAddConsignor = new Button();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(192, 254, 204);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Controls.Add(buttonAddConsignor);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(5, 4, 5, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(890, 57);
            panelSearch.TabIndex = 1;
            panelSearch.TabStop = true;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchInput.BackColor = Color.FromArgb(192, 254, 204);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 28F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(55, 0);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Name or Consignor ID";
            textBoxSearchInput.Size = new Size(614, 57);
            textBoxSearchInput.TabIndex = 2;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Dock = DockStyle.Left;
            pictureBoxSearch.Image = Properties.Resources.icons8_search_52;
            pictureBoxSearch.Location = new Point(0, 0);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(52, 57);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearch.TabIndex = 4;
            pictureBoxSearch.TabStop = false;
            // 
            // buttonAddConsignor
            // 
            buttonAddConsignor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddConsignor.BackColor = Color.Transparent;
            buttonAddConsignor.Dock = DockStyle.Right;
            buttonAddConsignor.FlatAppearance.BorderColor = Color.FromArgb(192, 254, 204);
            buttonAddConsignor.FlatAppearance.BorderSize = 2;
            buttonAddConsignor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 211, 254);
            buttonAddConsignor.FlatStyle = FlatStyle.Flat;
            buttonAddConsignor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddConsignor.Image = Properties.Resources.iconadd;
            buttonAddConsignor.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddConsignor.Location = new Point(669, 0);
            buttonAddConsignor.Name = "buttonAddConsignor";
            buttonAddConsignor.Size = new Size(221, 57);
            buttonAddConsignor.TabIndex = 2;
            buttonAddConsignor.Text = "Add Consignor";
            buttonAddConsignor.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddConsignor.UseVisualStyleBackColor = false;
            buttonAddConsignor.Click += buttonAddConsignor_Click;
            // 
            // Consignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSearch);
            Name = "Consignment";
            Size = new Size(890, 608);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Button buttonAddConsignor;
        private TextBox textBoxSearchInput;
        private PictureBox pictureBoxSearch;
    }
}
