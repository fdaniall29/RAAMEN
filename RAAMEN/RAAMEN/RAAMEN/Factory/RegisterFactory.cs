using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Factory
{
    public class RegisterFactory
    {
        public static User create(int Id, int Roleid, string Username, string Email, string Gender, string Password)
        {
            User newUser = new User();

            newUser.Id = Id;
            newUser.Roleid = Roleid;
            newUser.Username = Username;
            newUser.Email = Email;
            newUser.Gender = Gender;
            newUser.Password = Password;

            return newUser;
        }
    }
}