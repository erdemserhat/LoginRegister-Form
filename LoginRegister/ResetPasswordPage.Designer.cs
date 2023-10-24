namespace LoginRegister
{
    partial class ResetPasswordPage
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
            privateQuestionLabel = new Label();
            label4 = new Label();
            resetPasswordPhoneTextBox = new TextBox();
            label2 = new Label();
            resetPasswordEmailTextBox = new TextBox();
            label3 = new Label();
            resetPasswordConfirmButton = new Button();
            resetPasswordAnswerTextBox = new TextBox();
            resetPasswordConfirm2Button = new Button();
            resetPasswordInfoMessage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // privateQuestionLabel
            // 
            privateQuestionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privateQuestionLabel.AutoSize = true;
            privateQuestionLabel.Location = new Point(12, 271);
            privateQuestionLabel.Name = "privateQuestionLabel";
            privateQuestionLabel.Size = new Size(117, 20);
            privateQuestionLabel.TabIndex = 41;
            privateQuestionLabel.Text = "Private Question";
            privateQuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            privateQuestionLabel.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 149);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 39;
            label4.Text = "Phone :";
            label4.Click += label4_Click;
            // 
            // resetPasswordPhoneTextBox
            // 
            resetPasswordPhoneTextBox.Location = new Point(172, 146);
            resetPasswordPhoneTextBox.Name = "resetPasswordPhoneTextBox";
            resetPasswordPhoneTextBox.Size = new Size(167, 27);
            resetPasswordPhoneTextBox.TabIndex = 38;
            resetPasswordPhoneTextBox.TextChanged += registerPhoneTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 37;
            label2.Text = "E-Mail :";
            label2.Click += label2_Click;
            // 
            // resetPasswordEmailTextBox
            // 
            resetPasswordEmailTextBox.Location = new Point(172, 102);
            resetPasswordEmailTextBox.Name = "resetPasswordEmailTextBox";
            resetPasswordEmailTextBox.Size = new Size(167, 27);
            resetPasswordEmailTextBox.TabIndex = 36;
            resetPasswordEmailTextBox.TextChanged += registerEmailTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(70, 31);
            label3.Name = "label3";
            label3.Size = new Size(302, 34);
            label3.TabIndex = 35;
            label3.Text = "RESET PASSWORD";
            label3.TextAlign = ContentAlignment.BottomRight;
            label3.Click += label3_Click;
            // 
            // resetPasswordConfirmButton
            // 
            resetPasswordConfirmButton.Location = new Point(170, 225);
            resetPasswordConfirmButton.Name = "resetPasswordConfirmButton";
            resetPasswordConfirmButton.Size = new Size(94, 29);
            resetPasswordConfirmButton.TabIndex = 42;
            resetPasswordConfirmButton.Text = "Confirm";
            resetPasswordConfirmButton.UseVisualStyleBackColor = true;
            resetPasswordConfirmButton.Click += button1_Click;
            // 
            // resetPasswordAnswerTextBox
            // 
            resetPasswordAnswerTextBox.Location = new Point(142, 306);
            resetPasswordAnswerTextBox.Name = "resetPasswordAnswerTextBox";
            resetPasswordAnswerTextBox.Size = new Size(151, 27);
            resetPasswordAnswerTextBox.TabIndex = 43;
            // 
            // resetPasswordConfirm2Button
            // 
            resetPasswordConfirm2Button.Location = new Point(170, 353);
            resetPasswordConfirm2Button.Name = "resetPasswordConfirm2Button";
            resetPasswordConfirm2Button.Size = new Size(94, 29);
            resetPasswordConfirm2Button.TabIndex = 44;
            resetPasswordConfirm2Button.Text = "Confirm";
            resetPasswordConfirm2Button.UseVisualStyleBackColor = true;
            resetPasswordConfirm2Button.Click += resetPasswordConfirm2Button_Click;
            // 
            // resetPasswordInfoMessage
            // 
            resetPasswordInfoMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resetPasswordInfoMessage.AutoSize = true;
            resetPasswordInfoMessage.Location = new Point(12, 421);
            resetPasswordInfoMessage.Name = "resetPasswordInfoMessage";
            resetPasswordInfoMessage.Size = new Size(117, 20);
            resetPasswordInfoMessage.TabIndex = 45;
            resetPasswordInfoMessage.Text = "Private Question";
            resetPasswordInfoMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(410, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // ResetPasswordPage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 489);
            Controls.Add(pictureBox1);
            Controls.Add(resetPasswordInfoMessage);
            Controls.Add(resetPasswordConfirm2Button);
            Controls.Add(resetPasswordAnswerTextBox);
            Controls.Add(resetPasswordConfirmButton);
            Controls.Add(privateQuestionLabel);
            Controls.Add(label4);
            Controls.Add(resetPasswordPhoneTextBox);
            Controls.Add(label2);
            Controls.Add(resetPasswordEmailTextBox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label privateQuestionLabel;
        private Label label4;
        private TextBox resetPasswordPhoneTextBox;
        private Label label2;
        private TextBox resetPasswordEmailTextBox;
        private Label label3;
        private Button resetPasswordConfirmButton;
        private TextBox resetPasswordAnswerTextBox;
        private Button resetPasswordConfirm2Button;
        private Label resetPasswordInfoMessage;
        private PictureBox pictureBox1;
    }
}