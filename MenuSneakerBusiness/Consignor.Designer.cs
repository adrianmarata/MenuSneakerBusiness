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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consignor));
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
            labelDetails.Location = new Point(77, 25);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(375, 48);
            labelDetails.TabIndex = 0;
            labelDetails.Text = "Consignor Details";
            // 
            // textBoxConsignorName
            // 
            textBoxConsignorName.AcceptsTab = true;
            textBoxConsignorName.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsignorName.Location = new Point(34, 95);
            textBoxConsignorName.Name = "textBoxConsignorName";
            textBoxConsignorName.PlaceholderText = "Consignor Name";
            textBoxConsignorName.Size = new Size(465, 40);
            textBoxConsignorName.TabIndex = 1;
            // 
            // textBoxConsignorEmailAddress
            // 
            textBoxConsignorEmailAddress.AcceptsTab = true;
            textBoxConsignorEmailAddress.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsignorEmailAddress.Location = new Point(34, 186);
            textBoxConsignorEmailAddress.Name = "textBoxConsignorEmailAddress";
            textBoxConsignorEmailAddress.PlaceholderText = "Email Address";
            textBoxConsignorEmailAddress.Size = new Size(465, 40);
            textBoxConsignorEmailAddress.TabIndex = 2;
            // 
            // textBoxCellphoneNumber
            // 
            textBoxCellphoneNumber.AcceptsTab = true;
            textBoxCellphoneNumber.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCellphoneNumber.Location = new Point(34, 281);
            textBoxCellphoneNumber.Name = "textBoxCellphoneNumber";
            textBoxCellphoneNumber.PlaceholderText = "Cellphone Number";
            textBoxCellphoneNumber.Size = new Size(465, 40);
            textBoxCellphoneNumber.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            textBoxAddress.AcceptsTab = true;
            textBoxAddress.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(34, 377);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Address";
            textBoxAddress.Size = new Size(465, 40);
            textBoxAddress.TabIndex = 4;
            // 
            // buttonAddConsignor
            // 
            buttonAddConsignor.BackgroundImage = (Image)resources.GetObject("buttonAddConsignor.BackgroundImage");
            buttonAddConsignor.FlatAppearance.BorderSize = 0;
            buttonAddConsignor.FlatStyle = FlatStyle.Flat;
            buttonAddConsignor.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddConsignor.Location = new Point(147, 459);
            buttonAddConsignor.Name = "buttonAddConsignor";
            buttonAddConsignor.Size = new Size(212, 88);
            buttonAddConsignor.TabIndex = 1;
            buttonAddConsignor.Text = "Add Consignor";
            buttonAddConsignor.UseVisualStyleBackColor = true;
            // 
            // Consignor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 603);
            Controls.Add(buttonAddConsignor);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCellphoneNumber);
            Controls.Add(textBoxConsignorEmailAddress);
            Controls.Add(textBoxConsignorName);
            Controls.Add(labelDetails);
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