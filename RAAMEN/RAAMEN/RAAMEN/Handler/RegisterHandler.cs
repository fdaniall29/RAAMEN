using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;
using RAAMEN.Repository;
using RAAMEN.Factory;

namespace RAAMEN.Handler
{
    public class RegisterHandler
    {
        RegisterRepository RR = new RegisterRepository();
        public bool RegisterUser(string username, string email, string gender, string password, string confirmPassword)
        {
            if (username.Length < 5 || username.Length > 15 || !IsAlphaWithSpaces(username))
            {
                return false;
            }

            if (!email.EndsWith(".com"))
            {
                return false;
            }

            if (password != confirmPassword)
            {
                return false;
            }

            int newId = RR.GenerateUserId();
            int roleId = 3;

            User newUser = RegisterFactory.create(newId, roleId, username, email, gender, password);

            RR.AddUser(newUser);

            return true;

            bool IsAlphaWithSpaces(string value)
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}