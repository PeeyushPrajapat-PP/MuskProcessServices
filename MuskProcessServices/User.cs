using System;
using System.Data;

namespace MuskProcessServices {
    enum Role
    {
        Admin = 0,
        Employee = 1,
        Viewer = 2
    }

    public class User
    {
        private string _username;
        private string _password;
        private string _firstname;
        private string _surname;
        private string _email;
        private Role _role;
        private DateTime _updatedAt;
        private DateTime _createdAt;

        // Login method - return true
        public static bool Login(string username, string password)
        {
            string queryExpression = String.Format("SELECT * FROM Users WHERE username='{0}' AND password='{1}'", username, password);
            DataSet result = queryExpression.ConnectToDB();

            return result.Tables[0].Rows.Count == 1 ? true : false;
        }
    }
}