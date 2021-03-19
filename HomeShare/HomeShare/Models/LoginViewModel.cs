using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class LoginViewModel
    {
        private LoginModel LoginModel;

        public LoginModel LoginModel1
        {
            get
            {
                return LoginModel;
            }

            set
            {
                LoginModel = value;
            }
        }
    }
}