namespace LoginRegister
{
    partial class LoginPage
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
            loginUsernameTextBox = new TextBox();
            loginPasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            resetPasswordLinkLabel = new LinkLabel();
            label3 = new Label();
            registerButton = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginUsernameTextBox
            // 
            loginUsernameTextBox.Location = new Point(120, 83);
            loginUsernameTextBox.Name = "loginUsernameTextBox";
            loginUsernameTextBox.Size = new Size(125, 27);
            loginUsernameTextBox.TabIndex = 0;
            // 
            // loginPasswordTextBox
            // 
            loginPasswordTextBox.Location = new Point(120, 135);
            loginPasswordTextBox.Name = "loginPasswordTextBox";
            loginPasswordTextBox.Size = new Size(125, 27);
            loginPasswordTextBox.TabIndex = 1;
            loginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 86);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 138);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(39, 243);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(213, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // resetPasswordLinkLabel
            // 
            resetPasswordLinkLabel.AutoSize = true;
            resetPasswordLinkLabel.Location = new Point(92, 209);
            resetPasswordLinkLabel.Name = "resetPasswordLinkLabel";
            resetPasswordLinkLabel.Size = new Size(110, 20);
            resetPasswordLinkLabel.TabIndex = 4;
            resetPasswordLinkLabel.TabStop = true;
            resetPasswordLinkLabel.Text = "Password Reset";
            resetPasswordLinkLabel.LinkClicked += resetPasswordLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(89, 31);
            label3.Name = "label3";
            label3.Size = new Size(113, 34);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(39, 288);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(213, 29);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(120, 168);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(265, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(298, 362);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(registerButton);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(resetPasswordLinkLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginPasswordTextBox);
            Controls.Add(loginUsernameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginUsernameTextBox;
        private TextBox loginPasswordTextBox;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private LinkLabel resetPasswordLinkLabel;
        private Label label3;
        private Button registerButton;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}