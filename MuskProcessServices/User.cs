using System;
using System.Data;
using System.Windows.Forms;

namespace MuskProcessServices {
    enum Role
    {
        Admin = 0,
        Employee = 1,
        Viewer = 2
    }

    public class User
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _firstname { get; set; }
        private string _surname { get; set; }
        private string _email { get; set; }
        private int _role { get; set; }
        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        public User()
        {
        }

        // Constructor that includes all properties;
        public User(string username, string password, string firstname, string surname, string email, int role, DateTime? updatedAt = null, DateTime? createdAt = null)
        {
            _username = username;
            _password = password;
            _firstname = firstname;
            _surname = surname;
            _email = email;
            _role = role;
            _updatedAt = updatedAt;
            _createdAt = createdAt;
        }

        // Login method - return true if user has been found and create new User object
        public static bool Login(string username, string password)
        {
            string queryExpression = String.Format("SELECT * FROM Users WHERE username='{0}' AND password='{1}'", username, password);
            DataSet result = queryExpression.getDataSetFromDB();

            string outputta = string.Join(",", result.Tables[0].Rows[0]);

            //MessageBox.Show(result.Tables[0].Rows[0].Field<string>("Email"));
            User currentUser = FormatDataRowToObject(result.Tables[0].Rows[0]);
            AuthState.CurrentUser = currentUser;

            //MessageBox.Show(currentUser._email);

            return result.Tables[0].Rows.Count == 1 ? true : false;
        }

        private static User FormatDataRowToObject(DataRow datarow)
        {
            User user = new User();

            user._email = datarow.Field<string>("Email");
            user._firstname = datarow.Field<string>("Firstname");
            user._surname = datarow.Field<string>("Surname");
            user._username = datarow.Field<string>("Username");
            user._password = datarow.Field<string>("Password");
            user._role = datarow.Field<int>("Role");

            return user;
        }


        public string Username
        {
            get { return _username; }   // get method
            set { _username = value; }  // set method
        }
    }
}