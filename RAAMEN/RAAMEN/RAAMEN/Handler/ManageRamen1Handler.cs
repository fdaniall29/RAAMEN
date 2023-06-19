using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;
using RAAMEN.Repository;

namespace RAAMEN.Handler
{
    public class ManageRamen1Handler
    {
        private ManageRamen1Repository repository = new ManageRamen1Repository();

        public List<Raman> GetAllRamen()
        {
            return repository.GetAllRamen();
        }

        public Raman GetRamenById(int id)
        {
            return repository.GetRamenById(id);
        }

        public void DeleteRamen(int id)
        {
            Raman ramen = GetRamenById(id);
            repository.DeleteRamen(ramen);
        }
    }
}