namespace MenuSneakerBusiness
{
    partial class Pay
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
            textBoxCustomerName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            textBoxEmailAddress = new TextBox();
            comboBoxPaymentMethod = new ComboBox();
            textBoxAmountPaid = new TextBox();
            labelChange = new Label();
            labelAmountChange = new Label();
            buttonProceed = new Button();
            SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCustomerName.Location = new Point(106, 42);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.PlaceholderText = "Customer Name";
            textBoxCustomerName.Size = new Size(334, 44);
            textBoxCustomerName.TabIndex = 0;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(106, 101);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Phone Number";
            textBoxPhoneNumber.Size = new Size(334, 44);
            textBoxPhoneNumber.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(106, 158);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Address";
            textBoxAddress.Size = new Size(334, 44);
            textBoxAddress.TabIndex = 2;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailAddress.Location = new Point(106, 216);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.PlaceholderText = "Email Address";
            textBoxEmailAddress.Size = new Size(334, 44);
            textBoxEmailAddress.TabIndex = 3;
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(106, 274);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(334, 44);
            comboBoxPaymentMethod.TabIndex = 4;
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmountPaid.Location = new Point(106, 330);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.PlaceholderText = "Amount Paid";
            textBoxAmountPaid.Size = new Size(334, 44);
            textBoxAmountPaid.TabIndex = 5;
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelChange.ForeColor = SystemColors.WindowText;
            labelChange.Location = new Point(106, 381);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(143, 36);
            labelChange.TabIndex = 6;
            labelChange.Text = "Change:";
            // 
            // labelAmountChange
            // 
            labelAmountChange.AutoSize = true;
            labelAmountChange.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmountChange.Location = new Point(255, 381);
            labelAmountChange.Name = "labelAmountChange";
            labelAmountChange.Size = new Size(33, 36);
            labelAmountChange.TabIndex = 7;
            labelAmountChange.Text = "₱";
            // 
            // buttonProceed
            // 
            buttonProceed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonProceed.BackColor = SystemColors.ActiveCaption;
            buttonProceed.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProceed.Location = new Point(156, 459);
            buttonProceed.Name = "buttonProceed";
            buttonProceed.Size = new Size(229, 76);
            buttonProceed.TabIndex = 0;
            buttonProceed.Text = "Proceed";
            buttonProceed.UseVisualStyleBackColor = false;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(532, 603);
            Controls.Add(buttonProceed);
            Controls.Add(labelAmountChange);
            Controls.Add(labelChange);
            Controls.Add(textBoxAmountPaid);
            Controls.Add(comboBoxPaymentMethod);
            Controls.Add(textBoxEmailAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxCustomerName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCustomerName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAddress;
        private TextBox textBoxEmailAddress;
        private ComboBox comboBoxPaymentMethod;
        private TextBox textBoxAmountPaid;
        private Label labelChange;
        private Label labelAmountChange;
        private Button buttonProceed;
    }
}