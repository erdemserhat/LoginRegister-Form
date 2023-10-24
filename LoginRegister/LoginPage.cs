using LoginRegister.AutomationExceptions;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginRegister
{
    public partial class LoginPage : Form
    {
        RegisterPage registerPage;
        ResetPasswordPage resetPasswordPage;
        public LoginPage()
        {
            InitializeComponent();
            registerPage = new RegisterPage();
            resetPasswordPage = new ResetPasswordPage();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username;
            String password;


            try
            {
                if (string.IsNullOrEmpty(loginUsernameTextBox.Text.Trim()))
                {
                    throw new UsernameIlegalArgumentException("Please enter to valid user name to login ");

                }
                else
                {
                    username = loginUsernameTextBox.Text;
                }
                if (string.IsNullOrEmpty(loginPasswordTextBox.Text.Trim()))
                {
                    throw new PasswordIllegalArgumentException("Please enter a valid password to login");
                }
                else
                {
                    password = loginPasswordTextBox.Text;



                }


                DatabaseManagement dbm = new DatabaseManagement();
                dbm.databaseConnection();

                // Control Operation to login

                DatabaseManagement.connection.Open();
                DatabaseManagement.command.Connection = DatabaseManagement.connection;
                DatabaseManagement.command.CommandText = "SELECT * FROM accounts WHERE username=@username AND password=@password";
                DatabaseManagement.command.Parameters.AddWithValue("username", username);
                DatabaseManagement.command.Parameters.AddWithValue("password", password);

                SqlDataReader reader = DatabaseManagement.command.ExecuteReader();

                if (reader.Read())

                {
                    string dbUsername = reader.GetString(1);
                    string dbPassword = reader.GetString(2);

                    if (dbUsername == username && dbPassword == password)
                    {
                        MessageBox.Show("Welcome, " + username + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
            catch (UsernameIlegalArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Wrong username", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (PasswordIllegalArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPage = new RegisterPage();
            registerPage.Show();



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetPasswordPage = new ResetPasswordPage();
            resetPasswordPage.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) { loginPasswordTextBox.UseSystemPasswordChar = false; }
            if (checkBox1.CheckState == CheckState.Unchecked) { loginPasswordTextBox.UseSystemPasswordChar = true; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}