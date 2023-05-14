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
            panelCartDetails = new Panel();
            buttonPay = new Button();
            labelTotal = new Label();
            labelCart = new Label();
            pictureBox1 = new PictureBox();
            panelSearch = new Panel();
            textBoxSearchInput = new TextBox();
            pictureBoxSearch = new PictureBox();
            panelCartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panelCartDetails
            // 
            panelCartDetails.BackColor = Color.FromArgb(192, 254, 204);
            panelCartDetails.Controls.Add(buttonPay);
            panelCartDetails.Controls.Add(labelTotal);
            panelCartDetails.Controls.Add(labelCart);
            panelCartDetails.Controls.Add(pictureBox1);
            panelCartDetails.Dock = DockStyle.Right;
            panelCartDetails.Location = new Point(573, 0);
            panelCartDetails.Name = "panelCartDetails";
            panelCartDetails.Size = new Size(317, 608);
            panelCartDetails.TabIndex = 0;
            // 
            // buttonPay
            // 
            buttonPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 211, 254);
            buttonPay.Location = new Point(98, 482);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(122, 46);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "Pay";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(6, 431);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(85, 28);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total: ";
            // 
            // labelCart
            // 
            labelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelCart.Location = new Point(64, 5);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(116, 53);
            labelCart.TabIndex = 2;
            labelCart.Text = "Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icons8_shopping_cart_52;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(192, 254, 204);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(573, 57);
            panelSearch.TabIndex = 1;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchInput.BackColor = Color.FromArgb(192, 254, 204);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 28F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(58, 0);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Brandname or SKU";
            textBoxSearchInput.Size = new Size(509, 57);
            textBoxSearchInput.TabIndex = 6;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.Transparent;
            pictureBoxSearch.Dock = DockStyle.Left;
            pictureBoxSearch.Image = Properties.Resources.icons8_search_52;
            pictureBoxSearch.Location = new Point(0, 0);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(52, 57);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearch.TabIndex = 5;
            pictureBoxSearch.TabStop = false;
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelSearch);
            Controls.Add(panelCartDetails);
            Name = "PointOfSale";
            Size = new Size(890, 608);
            panelCartDetails.ResumeLayout(false);
            panelCartDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCartDetails;
        private Panel panelSearch;
        private PictureBox pictureBoxSearch;
        private TextBox textBoxSearchInput;
        private Label labelTotal;
        private Label labelCart;
        private PictureBox pictureBox1;
        private Button buttonPay;
    }
}
