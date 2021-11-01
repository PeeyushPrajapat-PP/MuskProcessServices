using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    public class AuthState
    {
        public static User _currentUser { get; set; }

        public static User CurrentUser
        {
            get { return _currentUser; }   // get method
            set { _currentUser = value; }  // set method
        }
    }
}
