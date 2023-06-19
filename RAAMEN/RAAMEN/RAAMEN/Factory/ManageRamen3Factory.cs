using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;

namespace RAAMEN.Factory
{
    public class ManageRamen3Factory
    {
        public static Raman create(int id, int Meatid, string Name, string Broth, string Price)
        {
            Raman viewRamen = new Raman();

            viewRamen.id = id;
            viewRamen.Meatid = Meatid;
            viewRamen.Name = Name;
            viewRamen.Broth = Broth;
            viewRamen.Price = Price;

            return viewRamen;
        }
    }
}