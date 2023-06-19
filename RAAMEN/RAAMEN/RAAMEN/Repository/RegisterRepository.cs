using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Repository
{
    public class RegisterRepository
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public int GenerateUserId()
        {
            int lastId = db.Users.Max(u => u.Id);
            int newId = lastId + 1;
            return newId;
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}