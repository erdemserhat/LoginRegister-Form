namespace LoginRegister
{
    partial class RegisterPage
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
            registerPrivateAnswerTextBox = new TextBox();
            capthcaAnswer = new TextBox();
            registerConfirmPasswordTextBox = new TextBox();
            registerPasswordTextBox = new TextBox();
            registerConfirmPrivateAnswerTextBox = new TextBox();
            registerPrivateQuestionTextBox = new TextBox();
            registerPhoneTextBox = new TextBox();
            registerEmailTextBox = new TextBox();
            registerUsernameTextBox = new TextBox();
            registerSendButton = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            captchaCheckBox = new CheckBox();
            captchaQuestionLabel = new Label();
            infoMessage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerPrivateAnswerTextBox
            // 
            registerPrivateAnswerTextBox.Location = new Point(151, 238);
            registerPrivateAnswerTextBox.Name = "registerPrivateAnswerTextBox";
            registerPrivateAnswerTextBox.Size = new Size(125, 27);
            registerPrivateAnswerTextBox.TabIndex = 22;
            // 
            // capthcaAnswer
            // 
            capthcaAnswer.Location = new Point(184, 405);
            capthcaAnswer.Name = "capthcaAnswer";
            capthcaAnswer.Size = new Size(33, 27);
            capthcaAnswer.TabIndex = 32;
            // 
            // registerConfirmPasswordTextBox
            // 
            registerConfirmPasswordTextBox.Location = new Point(151, 364);
            registerConfirmPasswordTextBox.Name = "registerConfirmPasswordTextBox";
            registerConfirmPasswordTextBox.Size = new Size(125, 27);
            registerConfirmPasswordTextBox.TabIndex = 28;
            // 
            // registerPasswordTextBox
            // 
            registerPasswordTextBox.Location = new Point(151, 322);
            registerPasswordTextBox.Name = "registerPasswordTextBox";
            registerPasswordTextBox.Size = new Size(125, 27);
            registerPasswordTextBox.TabIndex = 26;
            // 
            // registerConfirmPrivateAnswerTextBox
            // 
            registerConfirmPrivateAnswerTextBox.Location = new Point(151, 282);
            registerConfirmPrivateAnswerTextBox.Name = "registerConfirmPrivateAnswerTextBox";
            registerConfirmPrivateAnswerTextBox.Size = new Size(125, 27);
            registerConfirmPrivateAnswerTextBox.TabIndex = 24;
            // 
            // registerPrivateQuestionTextBox
            // 
            registerPrivateQuestionTextBox.Location = new Point(151, 195);
            registerPrivateQuestionTextBox.Name = "registerPrivateQuestionTextBox";
            registerPrivateQuestionTextBox.Size = new Size(125, 27);
            registerPrivateQuestionTextBox.TabIndex = 20;
            // 
            // registerPhoneTextBox
            // 
            registerPhoneTextBox.Location = new Point(151, 151);
            registerPhoneTextBox.Name = "registerPhoneTextBox";
            registerPhoneTextBox.Size = new Size(125, 27);
            registerPhoneTextBox.TabIndex = 18;
            // 
            // registerEmailTextBox
            // 
            registerEmailTextBox.Location = new Point(151, 107);
            registerEmailTextBox.Name = "registerEmailTextBox";
            registerEmailTextBox.Size = new Size(125, 27);
            registerEmailTextBox.TabIndex = 16;
            // 
            // registerUsernameTextBox
            // 
            registerUsernameTextBox.Location = new Point(151, 61);
            registerUsernameTextBox.Name = "registerUsernameTextBox";
            registerUsernameTextBox.Size = new Size(125, 27);
            registerUsernameTextBox.TabIndex = 8;
            // 
            // registerSendButton
            // 
            registerSendButton.Location = new Point(77, 461);
            registerSendButton.Name = "registerSendButton";
            registerSendButton.Size = new Size(213, 29);
            registerSendButton.TabIndex = 15;
            registerSendButton.Text = "Register";
            registerSendButton.UseVisualStyleBackColor = true;
            registerSendButton.Click += registerSendButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(107, 9);
            label3.Name = "label3";
            label3.Size = new Size(171, 34);
            label3.TabIndex = 14;
            label3.Text = "REGISTER";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 107);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 17;
            label2.Text = "E-Mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 154);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 19;
            label4.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 202);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 21;
            label5.Text = "Private Question :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 245);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 23;
            label6.Text = "Answer :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 285);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 25;
            label7.Text = "Confirm Answer :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 371);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 29;
            label8.Text = "Confirm Password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 325);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 27;
            label9.Text = "Password :";
            // 
            // captchaCheckBox
            // 
            captchaCheckBox.AutoSize = true;
            captchaCheckBox.Location = new Point(121, 431);
            captchaCheckBox.Name = "captchaCheckBox";
            captchaCheckBox.Size = new Size(133, 24);
            captchaCheckBox.TabIndex = 30;
            captchaCheckBox.Text = "I am not robot..";
            captchaCheckBox.UseVisualStyleBackColor = true;
            captchaCheckBox.CheckedChanged += captchaCheckBox_CheckedChanged;
            // 
            // captchaQuestionLabel
            // 
            captchaQuestionLabel.AutoSize = true;
            captchaQuestionLabel.Location = new Point(107, 408);
            captchaQuestionLabel.Name = "captchaQuestionLabel";
            captchaQuestionLabel.Size = new Size(57, 20);
            captchaQuestionLabel.TabIndex = 31;
            captchaQuestionLabel.Text = "3 + 5 =";
            // 
            // infoMessage
            // 
            infoMessage.AutoSize = true;
            infoMessage.Location = new Point(77, 493);
            infoMessage.Name = "infoMessage";
            infoMessage.Size = new Size(0, 20);
            infoMessage.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(337, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegisterPage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 586);
            Controls.Add(pictureBox1);
            Controls.Add(infoMessage);
            Controls.Add(capthcaAnswer);
            Controls.Add(captchaQuestionLabel);
            Controls.Add(captchaCheckBox);
            Controls.Add(label8);
            Controls.Add(registerConfirmPasswordTextBox);
            Controls.Add(label9);
            Controls.Add(registerPasswordTextBox);
            Controls.Add(label7);
            Controls.Add(registerConfirmPrivateAnswerTextBox);
            Controls.Add(label6);
            Controls.Add(registerPrivateAnswerTextBox);
            Controls.Add(label5);
            Controls.Add(registerPrivateQuestionTextBox);
            Controls.Add(label4);
            Controls.Add(registerPhoneTextBox);
            Controls.Add(label2);
            Controls.Add(registerEmailTextBox);
            Controls.Add(registerSendButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(registerUsernameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterPage";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Page";
            Load += RegisterPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerSendButton;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        public Label label7;
        public Label label8;
        private Label label9;
        private CheckBox captchaCheckBox;
        public Label captchaQuestionLabel;
        private TextBox registerUsernameTextBox;
        private TextBox registerEmailTextBox;
        private TextBox registerPhoneTextBox;
        private TextBox registerPrivateQuestionTextBox;
        private TextBox registerConfirmPrivateAnswerTextBox;
        private TextBox registerConfirmPasswordTextBox;
        private TextBox registerPasswordTextBox;
        private TextBox capthcaAnswer;
        private Label infoMessage;
        private TextBox registerPrivateAnswerTextBox;
        private PictureBox pictureBox1;
    }
}