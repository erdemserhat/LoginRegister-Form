using LoginRegister.AutomationExceptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginRegister
{
    // (RegisterPage is a (inherits) Form class ) //
    public partial class RegisterPage : Form
    {
        //Defining the attributes for lateinit

        private string username;
        private string email;
        private string phone;
        private string privateQuestion;
        private string privateAnswer;
        private string password;
        private User user = new User();
        private int captchaAnswer;
        private DatabaseManagement databaseManagement = new DatabaseManagement();

        public RegisterPage()
        {
            InitializeComponent();
            registerSendButton.Enabled = false;
            generateCapthca();

        }

        //Generates captcha question 

        public void generateCapthca()
        {
            //Prepare Captcha
            Random random = new Random();

            int randomNumber = random.Next(0, 10 + 1);
            int randomNumber2 = random.Next(0, 20 + 1);

            //Defined answer variable
            captchaAnswer = randomNumber + randomNumber2;

            string question = randomNumber + "+" + randomNumber2 + "= ?";
            captchaQuestionLabel.Text = question;
            capthcaAnswer.Text = "";

        }

        //Validates captca answer
        public bool capthcaValidation(int answerOfUser, int answer)
        {
            if (answer == answerOfUser) return true;
            else return false;


        }

        //Sets default values for components

        public void setDefaultValuesForComponenets()
        {

            registerPrivateAnswerTextBox.BackColor = Color.White;
            registerConfirmPrivateAnswerTextBox.BackColor = Color.White;
            registerConfirmPasswordTextBox.BackColor = Color.White;
            registerPasswordTextBox.BackColor = Color.White;
            capthcaAnswer.BackColor = Color.White;
        }

        //Initalizes and validates user's information for registeration

        public bool validateRegisterForm()
        {
            bool isFormValid = false;
            try
            {
                if (string.IsNullOrEmpty(registerUsernameTextBox.Text.Trim()))
                {
                    throw new UsernameIlegalArgumentException("Please enter a valid username");
                }
                else
                {
                    username = registerUsernameTextBox.Text;
                }

                if (string.IsNullOrEmpty(registerEmailTextBox.Text.Trim()))
                {
                    throw new EmailIllegalArgumentException("Please enter a valid email");
                }
                else
                {
                    email = registerEmailTextBox.Text;
                }

                if (string.IsNullOrEmpty(registerPhoneTextBox.Text.Trim()))
                {
                    throw new PhoneIllegalArgumentException("Please enter a valid phone number");
                }
                else
                {
                    phone = registerPhoneTextBox.Text;
                }

                if (string.IsNullOrEmpty(registerPrivateQuestionTextBox.Text.Trim()))
                {
                    throw new PrivateQuestionIllegalArgumentException("Please enter a valid private question");
                }



                else
                {
                    privateQuestion = registerPrivateQuestionTextBox.Text;
                }

                if (string.IsNullOrEmpty(registerPrivateAnswerTextBox.Text.Trim()))
                {
                    throw new PrivateAnswerIllegalArgumentException("Please enter a valid private answer");
                }
                else
                {
                    privateAnswer = registerPrivateAnswerTextBox.Text;
                }

                if (string.IsNullOrEmpty(registerPasswordTextBox.Text.Trim()))
                {
                    throw new PasswordIllegalArgumentException("Please enter a valid password");
                }
                else if (registerPasswordTextBox.Text.Length < 8)
                {
                    throw new ShortPasswordException("Password is too short. Minimum length is 8 characters.");
                }
                else
                {
                    password = registerPasswordTextBox.Text;
                }

                isFormValid = true;

                //Password and Private Answer Confirmation
                string privateAnswerConfirm = registerConfirmPrivateAnswerTextBox.Text;
                string passwordConfirm = registerConfirmPasswordTextBox.Text;
                bool isValidPassword = user.PasswordValidation(this.password, passwordConfirm);
                bool isValidAnswer = user.PrivateAnswerValidation(this.privateAnswer, privateAnswerConfirm);

                if (!isValidAnswer)
                {
                    throw new NotMatchedPrivateAnswersException("Your private answers don't match");

                }

                if (!isValidPassword)
                {
                    throw new NotMatchedPasswordsAnswersException("Your passwords don't match");
                }



            }
            catch (UsernameIlegalArgumentException ex)
            {
                // Error handling: Username error
                MessageBox.Show(ex.Message, "Invalid Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (PasswordIllegalArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            catch (PrivateQuestionIllegalArgumentException ex)
            {
                // Error handling: Private question error
                MessageBox.Show(ex.Message, "Invalid Private Question  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PrivateAnswerIllegalArgumentException ex)
            {
                // Error handling: Private answer error
                MessageBox.Show(ex.Message, "Invalid Answer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ShortPasswordException ex)
            {
                // Error handling: Short password error
                MessageBox.Show(ex.Message, "Invalid Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Error handling: not matched answers
            catch (NotMatchedPrivateAnswersException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registerConfirmPrivateAnswerTextBox.BackColor = Color.Red;
                registerPrivateAnswerTextBox.BackColor = Color.Red;

            }

            catch (NotMatchedPasswordsAnswersException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registerConfirmPasswordTextBox.BackColor = Color.Red;
                registerPasswordTextBox.BackColor = Color.Red;

            }

            catch (InvalidCaptchaException ex)
            {
                MessageBox.Show(ex.Message, "Wrong Captcha Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capthcaAnswer.BackColor = Color.Red;


            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                captchaCheckBox.Enabled = true;
                capthcaAnswer.Enabled = true;
                generateCapthca();
                captchaCheckBox.CheckState = CheckState.Unchecked;

            }
            return isFormValid;

        }

        public void informAboutRegisteration()
        {
            string registerInfoMessage = "You have successfully registered";
            MessageBox.Show(registerInfoMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
        }



        //When user click the register button

        private void registerSendButton_Click(object sender, EventArgs e)
        {
            //Set default values
            setDefaultValuesForComponenets();


            //Safe attribude assignment
            bool isValidForm = validateRegisterForm();
            //Creating a data model
            user = new User(username, password, email, phone, privateQuestion, privateAnswer);

            if (isValidForm)
            {
                //Inserting the related data model to db
                databaseManagement.insertData(user);

                //makes the user inform about successfull operation
                informAboutRegisteration();

            }


        }


        private void captchaCheckBox_CheckedChanged(object sender, EventArgs e)
        {


            if (captchaCheckBox.CheckState == CheckState.Unchecked)
            {
                registerSendButton.Enabled = false;
                generateCapthca();


            }

            if (captchaCheckBox.CheckState == CheckState.Checked)
            {


                //Captcha Confirmation
                try
                {

                    int answerOfUser = int.Parse(capthcaAnswer.Text);
                    bool isValidCaptcha = capthcaValidation(answerOfUser, captchaAnswer);
                    if (!isValidCaptcha)
                    {
                        throw new InvalidCaptchaException("Your captcha answer was wrong");


                    }

                    registerSendButton.Enabled = true;
                    setDefaultValuesForComponenets();
                    captchaCheckBox.Enabled = false;
                    capthcaAnswer.Enabled = false;

                }
                catch (InvalidCaptchaException ex)
                {

                    MessageBox.Show(ex.Message, "Wrong Captcha Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    capthcaAnswer.BackColor = Color.Red;
                    captchaCheckBox.Checked = false;

                }



                catch (Exception ex)

                {
                    captchaCheckBox.Checked = false;
                    MessageBox.Show("captcha is empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



