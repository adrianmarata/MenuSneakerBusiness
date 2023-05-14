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
            Condition = new Label();
            ItemName = new Label();
            SKU = new Label();
            Price = new Label();
            textBoxItemName = new TextBox();
            textBoxSKU = new TextBox();
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
            Condition.Location = new Point(10, 224);
            Condition.Name = "Condition";
            Condition.Size = new Size(126, 26);
            Condition.TabIndex = 1;
            Condition.Text = "Condition:";
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ItemName.Location = new Point(12, 50);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(146, 26);
            ItemName.TabIndex = 2;
            ItemName.Text = "Item Name:";
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SKU.Location = new Point(12, 108);
            SKU.Name = "SKU";
            SKU.Size = new Size(76, 26);
            SKU.TabIndex = 4;
            SKU.Text = "SKU: ";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(10, 281);
            Price.Name = "Price";
            Price.Size = new Size(74, 26);
            Price.TabIndex = 5;
            Price.Text = "Price:";
            // 
            // textBoxItemName
            // 
            textBoxItemName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxItemName.Location = new Point(10, 76);
            textBoxItemName.Margin = new Padding(3, 2, 3, 2);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(445, 32);
            textBoxItemName.TabIndex = 6;
            // 
            // textBoxSKU
            // 
            textBoxSKU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSKU.Location = new Point(12, 134);
            textBoxSKU.Margin = new Padding(3, 2, 3, 2);
            textBoxSKU.Name = "textBoxSKU";
            textBoxSKU.Size = new Size(445, 32);
            textBoxSKU.TabIndex = 7;
            // 
            // textBoxSize
            // 
            textBoxSize.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSize.Location = new Point(10, 192);
            textBoxSize.Margin = new Padding(3, 2, 3, 2);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(445, 32);
            textBoxSize.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(10, 308);
            textBoxPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(445, 32);
            textBoxPrice.TabIndex = 10;
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(10, 250);
            comboBoxCondition.Margin = new Padding(3, 2, 3, 2);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(445, 33);
            comboBoxCondition.TabIndex = 11;
            // 
            // buttonAddItem
            // 
            buttonAddItem.BackColor = Color.FromArgb(192, 211, 254);
            buttonAddItem.FlatStyle = FlatStyle.Flat;
            buttonAddItem.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddItem.ForeColor = Color.Black;
            buttonAddItem.Location = new Point(108, 370);
            buttonAddItem.Margin = new Padding(3, 2, 3, 2);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(235, 66);
            buttonAddItem.TabIndex = 12;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = false;
            // 
            // addItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(466, 452);
            Controls.Add(buttonAddItem);
            Controls.Add(comboBoxCondition);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxSKU);
            Controls.Add(textBoxItemName);
            Controls.Add(Price);
            Controls.Add(SKU);
            Controls.Add(ItemName);
            Controls.Add(Condition);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBoxSize;
        private TextBox textBoxPrice;
        private ComboBox comboBoxCondition;
        private Button buttonAddItem;
    }
}