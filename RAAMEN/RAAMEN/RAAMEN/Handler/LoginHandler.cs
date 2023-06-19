using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;
using RAAMEN.Repository;

namespace RAAMEN.Handler
{
    public class LoginHandler
    {
        LoginRepository userRepository = new LoginRepository();
        public User ValidateUser(string username, string password)
        {
            return userRepository.GetUser(username, password);
        }
    }
}