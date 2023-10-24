using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Net;
using LoginRegister.AutomationExceptions;

namespace LoginRegister
{
    public partial class ResetPasswordPage : Form
    {

        public string privateAnswer;
        string password;
        public ResetPasswordPage()
        {
            InitializeComponent();
            resetPasswordConfirm2Button.Visible = false;
            privateQuestionLabel.Visible = false;
            resetPasswordAnswerTextBox.Visible = false;
            resetPasswordInfoMessage.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void captchaQuestionLabel_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void registerConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void registerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void registerConfirmPrivateAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void registerPrivateAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void registerPrivateQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void registerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void registerEmailTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void capthcaAnswer_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void registerUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email;
            string phone;

            try
            {
                if (string.IsNullOrEmpty(resetPasswordEmailTextBox.Text.Trim()))
                {
                    throw new EmailIllegalArgumentException("Please enter to valid email");

                }
                else
                {
                    email = resetPasswordEmailTextBox.Text;
                }

                if (string.IsNullOrEmpty(resetPasswordPhoneTextBox.Text.Trim()))
                {
                    throw new PhoneIllegalArgumentException("Please enter to valid phone number");

                }
                else
                {
                    phone = resetPasswordPhoneTextBox.Text;
                }

                //Database

                DatabaseManagement dbm = new DatabaseManagement();
                dbm.databaseConnection();

                // Control Operation to login

                DatabaseManagement.connection.Open();
                DatabaseManagement.command.Connection = DatabaseManagement.connection;
                DatabaseManagement.command.CommandText = "SELECT * FROM accounts WHERE email=@email AND phone=@phone";
                DatabaseManagement.command.Parameters.AddWithValue("email", email);
                DatabaseManagement.command.Parameters.AddWithValue("phone", phone);

                SqlDataReader reader = DatabaseManagement.command.ExecuteReader();

                if (reader.Read())

                {
                    string dbEmail = reader.GetString(3);
                    string dbPhone = reader.GetString(4);
                    string privateQuestion = reader.GetString(5);
                    password = reader.GetString(2);
                    privateAnswer = reader.GetString(6);

                    if (dbEmail == email && dbPhone == phone)
                    {
                        resetPasswordEmailTextBox.Enabled = false;
                        resetPasswordPhoneTextBox.Enabled = false;
                        resetPasswordConfirmButton.Enabled = false;
                        privateQuestionLabel.Text = privateQuestion;

                        resetPasswordConfirm2Button.Visible = true;
                        privateQuestionLabel.Visible = true;
                        resetPasswordAnswerTextBox.Visible = true;

                    }

                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DatabaseManagement.connection.Close();




            }
            catch (EmailIllegalArgumentException ex)
            {
                // Error handling:  email
                MessageBox.Show(ex.Message, "Invalid  E-mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PhoneIllegalArgumentException ex)
            {
                // Error handling: Phone number error
                MessageBox.Show(ex.Message, "Invalid Phone Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void resetPasswordConfirm2Button_Click(object sender, EventArgs e)
        {
            string privateAnswer;

            try
            {
                if (string.IsNullOrEmpty(resetPasswordAnswerTextBox.Text.Trim()))
                {
                    throw new PrivateAnswerIllegalArgumentException("Please enter a valid answer");
                }
                else
                {
                    privateAnswer = resetPasswordAnswerTextBox.Text;
                }


                if (this.privateAnswer == privateAnswer)

                {
                    string email = resetPasswordEmailTextBox.Text;

                    resetPasswordInfoMessage.Text = "Your password is sent to " + email;
                    resetPasswordInfoMessage.Visible = true;

                    try
                    {
                        string smtpServer = "smtp.gmail.com"; // Gmail SMTP sunucu adresi
                        int smtpPort = 587; // Gmail SMTP sunucu port numarası
                        string smtpUsername = "javatester60@gmail.com"; // Gmail hesap e-posta adresiniz
                        string smtpPassword = "private to me :) "; // Gmail hesap şifreniz

                        string fromEmail = "javatester60@gmail.com"; // Gönderen e-posta adresi (Gmail hesabınız)
                        string toEmail = resetPasswordEmailTextBox.Text; // Alıcı e-posta adresi
                        string subject = "Your Password"; // E-posta konusu
                        string body = password; // E-posta içeriği

                        // MailMessage oluşturun
                        MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);

                        // SmtpClient oluşturun
                        SmtpClient smtpClient = new SmtpClient(smtpServer)
                        {
                            Port = smtpPort,
                            Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                            EnableSsl = true, // SSL/TLS kullanmak istiyorsanız true yapın
                        };

                        // E-postayı gönderin
                        smtpClient.Send(mail);

                        string message = "Your password has been sent to your email address! \n" +
                            "(Please check your spam box...)";




                        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }







                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Private Answer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
