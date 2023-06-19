using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Factory
{
    public class Home2Factory
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public User CreateUser(string username, string email, string gender)
        {
            return new User
            {
                Username = username,
                Email = email,
                Gender = gender
            };
        }
    }
}