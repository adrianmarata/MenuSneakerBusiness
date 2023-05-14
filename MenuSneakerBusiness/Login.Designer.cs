namespace MenuSneakerBusiness
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelUsername = new Label();
            panel2 = new Panel();
            labelPassword = new Label();
            panel3 = new Panel();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonSignIn = new Button();
            usernameLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)usernameLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.Control;
            labelUsername.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(63, 243);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(141, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(22, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 3);
            panel2.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.Control;
            labelPassword.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(63, 329);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(138, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(22, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 3);
            panel3.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.Control;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(22, 277);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(440, 19);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Control;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(22, 371);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(440, 19);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(192, 211, 254);
            buttonSignIn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.ForeColor = Color.Black;
            buttonSignIn.Location = new Point(151, 429);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(167, 53);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // usernameLogo
            // 
            usernameLogo.Image = (Image)resources.GetObject("usernameLogo.Image");
            usernameLogo.Location = new Point(22, 235);
            usernameLogo.Name = "usernameLogo";
            usernameLogo.Size = new Size(35, 35);
            usernameLogo.SizeMode = PictureBoxSizeMode.Zoom;
            usernameLogo.TabIndex = 7;
            usernameLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(430, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = Properties.Resources.WeLacedIt;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(482, 164);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 531);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLogo);
            Controls.Add(buttonSignIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(panel3);
            Controls.Add(labelPassword);
            Controls.Add(panel2);
            Controls.Add(labelUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "We Laced It";
            ((System.ComponentModel.ISupportInitialize)usernameLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUsername;
        private Panel panel2;
        private Label labelPassword;
        private Panel panel3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSignIn;
        private PictureBox usernameLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLogo;
    }
}