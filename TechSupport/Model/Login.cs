using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{

    public class Login
    /// <summary>
    /// Class that will keep the login/password objects for each user
    /// </summary>
    {
        public string UserName { get;  }
        public string Password { get;  }

        /// <summary>
        /// Constructor to create the Login object
        /// </summary>
        /// <param name="UserName"></param>     The username
        /// <param name="Password"></param>     The password
        /// <exception cref="ArgumentNullException"></exception>
        public Login(string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName))
                throw new ArgumentNullException("UserNamecannot be empty", "title");

            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("Password cannot be empty", "title");


            this.UserName = UserName;
            this.Password = Password;

        }

    }
}
