namespace MenuSneakerBusiness
{
    partial class Consignor
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
            labelDetails = new Label();
            textBoxConsignorName = new TextBox();
            textBoxConsignorEmailAddress = new TextBox();
            textBoxCellphoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            buttonAddConsignor = new Button();
            SuspendLayout();
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelDetails.Location = new Point(67, 19);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(299, 38);
            labelDetails.TabIndex = 0;
            labelDetails.Text = "Consignor Details";
            // 
            // textBoxConsignorName
            // 
            textBoxConsignorName.AcceptsTab = true;
            textBoxConsignorName.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsignorName.Location = new Point(30, 71);
            textBoxConsignorName.Margin = new Padding(3, 2, 3, 2);
            textBoxConsignorName.Name = "textBoxConsignorName";
            textBoxConsignorName.PlaceholderText = "Consignor Name";
            textBoxConsignorName.Size = new Size(407, 34);
            textBoxConsignorName.TabIndex = 1;
            // 
            // textBoxConsignorEmailAddress
            // 
            textBoxConsignorEmailAddress.AcceptsTab = true;
            textBoxConsignorEmailAddress.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsignorEmailAddress.Location = new Point(30, 140);
            textBoxConsignorEmailAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxConsignorEmailAddress.Name = "textBoxConsignorEmailAddress";
            textBoxConsignorEmailAddress.PlaceholderText = "Email Address";
            textBoxConsignorEmailAddress.Size = new Size(407, 34);
            textBoxConsignorEmailAddress.TabIndex = 2;
            // 
            // textBoxCellphoneNumber
            // 
            textBoxCellphoneNumber.AcceptsTab = true;
            textBoxCellphoneNumber.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCellphoneNumber.Location = new Point(30, 211);
            textBoxCellphoneNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxCellphoneNumber.Name = "textBoxCellphoneNumber";
            textBoxCellphoneNumber.PlaceholderText = "Cellphone Number";
            textBoxCellphoneNumber.Size = new Size(407, 34);
            textBoxCellphoneNumber.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            textBoxAddress.AcceptsTab = true;
            textBoxAddress.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(30, 283);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Address";
            textBoxAddress.Size = new Size(407, 34);
            textBoxAddress.TabIndex = 4;
            // 
            // buttonAddConsignor
            // 
            buttonAddConsignor.BackColor = Color.FromArgb(192, 211, 254);
            buttonAddConsignor.FlatAppearance.BorderSize = 0;
            buttonAddConsignor.FlatStyle = FlatStyle.Flat;
            buttonAddConsignor.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddConsignor.ForeColor = Color.Black;
            buttonAddConsignor.Location = new Point(129, 344);
            buttonAddConsignor.Margin = new Padding(3, 2, 3, 2);
            buttonAddConsignor.Name = "buttonAddConsignor";
            buttonAddConsignor.Size = new Size(186, 66);
            buttonAddConsignor.TabIndex = 1;
            buttonAddConsignor.Text = "Add Consignor";
            buttonAddConsignor.UseVisualStyleBackColor = false;
            // 
            // Consignor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 452);
            Controls.Add(buttonAddConsignor);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCellphoneNumber);
            Controls.Add(textBoxConsignorEmailAddress);
            Controls.Add(textBoxConsignorName);
            Controls.Add(labelDetails);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Consignor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consignor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDetails;
        private TextBox textBoxConsignorName;
        private TextBox textBoxConsignorEmailAddress;
        private TextBox textBoxCellphoneNumber;
        private TextBox textBoxAddress;
        private Button buttonAddConsignor;
    }
}