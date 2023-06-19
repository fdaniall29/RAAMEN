using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Repository
{
    public class Home2Repository
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();

        public User FindUser(int id)
        {
            return db.Users.Find(id);
        }

        public List<string> GetDistinctGenders()
        {
            return (from Type in db.Users select Type.Gender).Distinct().ToList();
        }

        public void UpdateUser(User user)
        {
            db.SaveChanges();
        }
    }
}