using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Login Data Access Layer (LoginDAL)
    /// </summary>
    public class LoginController
    {
        private LoginDAL loginSource;

        public LoginController()
        {
            this.loginSource = new LoginDAL();
        }

        public List<Login> getLoginsAndPasswords()
        {
            return this.loginSource.getLoginsAndPasswords();
        }
    }
}
