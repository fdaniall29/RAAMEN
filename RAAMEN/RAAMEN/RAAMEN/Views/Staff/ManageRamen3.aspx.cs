using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;
using RAAMEN.Factory;

namespace RAAMEN.Views.Staff
{
    public partial class ManageRamen3 : System.Web.UI.Page
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }
            if (IsPostBack == false)
            {
                List<String> meatId = (from type in db.Meats select type.name).ToList();

                MeatDropDown.DataSource = meatId;
                MeatDropDown.DataBind();
            }
        }
        protected int generateRamenId()
        {
            int lastId = db.Ramen.Max(r => r.id);
            int newId = lastId + 1;

            return newId;
        }

        protected int GetMeatIdFromName(string meatName)
        {
            Meat meat = db.Meats.FirstOrDefault(m => m.name == meatName);

            if (meat != null)
            {
                return meat.id;
            }

            return 0;
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Raman newRamen = Factory.ManageRamen3Factory.create(generateRamenId(), GetMeatIdFromName(MeatDropDown.SelectedItem.Text), NameTextBox.Text.ToString(), BrothTextBox.Text.ToString(), PriceTextBox.Text.ToString());

            db.Ramen.Add(newRamen);
            db.SaveChanges();

            Response.Redirect("ManageRamen1.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen1.aspx");
        }
    }
}