using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Repository
{
    public class ManageRamen1Repository
    {
        private RaamenDatabaseEntities db = new RaamenDatabaseEntities();

        public List<Raman> GetAllRamen()
        {
            return db.Ramen.ToList();
        }

        public Raman GetRamenById(int id)
        {
            return db.Ramen.Find(id);
        }

        public void DeleteRamen(Raman ramen)
        {
            db.Ramen.Remove(ramen);
            db.SaveChanges();
        }
    }
}