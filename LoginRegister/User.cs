using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LoginRegister
{
    internal class User
    {
        private string username;
        private string password;
        private string email;
        private string phone;
        private string privateQuestion;
        private string privateAnswer;



        public User()
        {

        }

        public User(string username, string password, string email, string phone, string privateQuestion, string privateAnswer)
        {

            this.username = username;
            this.password = password;
            this.email = email;
            this.phone = phone;
            this.privateQuestion = privateQuestion;
            this.privateAnswer = privateAnswer;
        }

        public string UserName{ get { return username; }} 
        public string Password { get { return password; } }
        public string Email { get { return email; } }
        public string Phone { get { return phone; } }
        public string PrivateQuestion { get {  return privateQuestion; } }
        public string PrivateAnswer { get {  return privateAnswer; } }




        public void Register(User user)
        {


        }

        public void Login(User user)
        {


        }

        public void ResetPassword(User user)
        {


        }

        public void IsRobot(User user)
        {


        }

        public bool PasswordValidation(string password, string confPassword)
        {
            if(password==confPassword)
                return true;
            else return false;


        }

        public bool PrivateAnswerValidation(string answer, string confAnswer)
        {
            if (answer == confAnswer)
                return true;
            else return false;


        }

        

        public void Login(String username, String password)
        {

            DatabaseManagement dbm = new DatabaseManagement();
            dbm.databaseConnection();
            (new User()).Login(username, password);
         

        }




    }

   
}
