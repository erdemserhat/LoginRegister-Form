using System.Data.SqlClient;

namespace LoginRegister
{

    internal class DatabaseManagement
    {
       public static SqlConnection connection;
        public static SqlCommand command;
        public DatabaseManagement()
        {
           
        }

        public void databaseConnection()
        {
            connection = new SqlConnection("Data Source=DESKTOP-9UD3KA7;Initial Catalog=maindb;Integrated Security=True");
            command = new SqlCommand();
        }

        public void insertData(User user)
        {
            try
            {
                //Destructure of the given user object's attribute to add user database...

                string username = user.UserName;
                string password= user.Password;
                string email = user.Email;
                string phone = user.Phone;
                string privateQuestion=user.PrivateQuestion;
                string privateAnswer = user.PrivateAnswer;

                databaseConnection();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO accounts (username,password,email,phone,privateQuestion,privateAnswer)" +
                    " VALUES (@username,@password,@email,@phone,@privateQuestion,@privateAnswer)";
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("phone", phone);
                command.Parameters.AddWithValue("privateQuestion", privateQuestion);
                command.Parameters.AddWithValue("privateAnswer", privateAnswer);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex) { }
        }

        void updateData()
        {


        }

      
    }
 }
