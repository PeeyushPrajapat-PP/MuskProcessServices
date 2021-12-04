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
        private int _userId { get; set; }
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
        public User(int userId, string username, string password, string firstname, string surname, string email, int role, DateTime? updatedAt = null, DateTime? createdAt = null)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _firstname = firstname;
            _surname = surname;
            _email = email;
            _role = role;
            _updatedAt = updatedAt;
            _createdAt = createdAt;
        }
        public static DataSet getAllUsers()
        {
            // Select all users from database 
            string queryExpression = String.Format("SELECT * FROM Users");
            DataSet result = queryExpression.getDataSetFromDB();

            // Creating a temporary column which we can use to display the whole name in the dropdown
            result.Tables[0].Columns.Add("Fullname", typeof(string),
                "Firstname + ' ' + Surname");

            return result;
        }
        public static User getUser(int userId)
        {
            string queryExpression = String.Format("SELECT * FROM Users WHERE UserID='{0}'", userId);
            DataRow result = queryExpression.getDataSetFromDB().Tables[0].Rows[0];

            User user = new User(
                result.Field<int>("UserID"),
                result.Field<string>("Username"),
                result.Field<string>("Password"),
                result.Field<string>("Firstname"),
                result.Field<string>("Surname"),
                result.Field<string>("Email"),
                result.Field<int>("Role")
                );

            return user;
        }

        // Login method - return true if user has been found and create new User object
        public static bool Login(string username, string password)
        {
            string queryExpression = String.Format("SELECT * FROM Users WHERE username='{0}' AND password='{1}'", username, password);
            DataSet result = queryExpression.getDataSetFromDB();

            User currentUser = FormatDataRowToObject(result.Tables[0].Rows[0]);

            if (result.Tables[0].Rows.Count == 1)
            {
                SharedMethods.CurrentUser = currentUser;
                return true;
            } else
            {
                return false;
            }
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

        public int UserId
        {
            get { return _userId; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}