﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class LoginDAL
    {
        private static List<Login> _logins = new List<Login>
        {
            new Login("jane", "1234"),
            new Login("Li", "1234")
        };

        
        public List<Login> GetLoginsAndPasswords()
        {
            return _logins;
        }

    }



}
