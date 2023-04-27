namespace MenuSneakerBusiness
{
    partial class addItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItem));
            Condition = new Label();
            ItemName = new Label();
            SKU = new Label();
            Price = new Label();
            textBoxItemName = new TextBox();
            textBoxSKU = new TextBox();
            Size = new Label();
            textBoxSize = new TextBox();
            textBoxPrice = new TextBox();
            comboBoxCondition = new ComboBox();
            buttonAddItem = new Button();
            SuspendLayout();
            // 
            // Condition
            // 
            Condition.AutoSize = true;
            Condition.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Condition.Location = new Point(12, 298);
            Condition.Name = "Condition";
            Condition.Size = new Size(153, 32);
            Condition.TabIndex = 1;
            Condition.Text = "Condition:";
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ItemName.Location = new Point(14, 67);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(178, 32);
            ItemName.TabIndex = 2;
            ItemName.Text = "Item Name:";
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SKU.Location = new Point(14, 144);
            SKU.Name = "SKU";
            SKU.Size = new Size(93, 32);
            SKU.TabIndex = 4;
            SKU.Text = "SKU: ";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(12, 375);
            Price.Name = "Price";
            Price.Size = new Size(91, 32);
            Price.TabIndex = 5;
            Price.Text = "Price:";
            // 
            // textBoxItemName
            // 
            textBoxItemName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxItemName.Location = new Point(12, 102);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(508, 39);
            textBoxItemName.TabIndex = 6;
            // 
            // textBoxSKU
            // 
            textBoxSKU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSKU.Location = new Point(14, 179);
            textBoxSKU.Name = "textBoxSKU";
            textBoxSKU.Size = new Size(508, 39);
            textBoxSKU.TabIndex = 7;
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Size.Location = new Point(14, 221);
            Size.Name = "Size";
            Size.Size = new Size(81, 32);
            Size.TabIndex = 3;
            Size.Text = "Size:";
            // 
            // textBoxSize
            // 
            textBoxSize.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSize.Location = new Point(12, 256);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(508, 39);
            textBoxSize.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(12, 410);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(508, 39);
            textBoxPrice.TabIndex = 10;
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(12, 333);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(508, 39);
            comboBoxCondition.TabIndex = 11;
            // 
            // buttonAddItem
            // 
            buttonAddItem.BackColor = Color.Transparent;
            buttonAddItem.BackgroundImage = (Image)resources.GetObject("buttonAddItem.BackgroundImage");
            buttonAddItem.FlatStyle = FlatStyle.Flat;
            buttonAddItem.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddItem.ForeColor = Color.White;
            buttonAddItem.Location = new Point(124, 494);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(269, 88);
            buttonAddItem.TabIndex = 12;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = false;
            // 
            // addItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(532, 603);
            Controls.Add(buttonAddItem);
            Controls.Add(comboBoxCondition);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxSKU);
            Controls.Add(textBoxItemName);
            Controls.Add(Price);
            Controls.Add(SKU);
            Controls.Add(Size);
            Controls.Add(ItemName);
            Controls.Add(Condition);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "addItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            Load += addItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Condition;
        private Label ItemName;
        private Label SKU;
        private Label Price;
        private TextBox textBoxItemName;
        private TextBox textBoxSKU;
        private Label Size;
        private TextBox textBoxSize;
        private TextBox textBoxPrice;
        private ComboBox comboBoxCondition;
        private Button buttonAddItem;
    }
}