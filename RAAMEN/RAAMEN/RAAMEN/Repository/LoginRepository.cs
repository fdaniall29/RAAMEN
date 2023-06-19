using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Repository
{
    public class LoginRepository
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public User GetUser(string username, string password)
        {
            return (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();
        }
    }
}