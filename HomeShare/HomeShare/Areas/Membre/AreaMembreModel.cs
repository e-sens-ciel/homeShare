using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeShare.Areas.Membre
{

    public class AreaMembreModel
    {

        private string _idMembre, _nom, _prenom, _email, /*_pays, */_telephone, _login, _password, _confirmPassword;
        private int _pays;


        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public int Pays
        {
            get
            {
                return _pays;
            }

            set
            {
                _pays = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }


        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }

            set
            {
                _confirmPassword = value;
            }

        }
    }
}