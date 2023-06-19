using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;

namespace RAAMEN.Views.Staff
{
    public partial class ManageRamen2 : System.Web.UI.Page
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
                string id = Request["ID"];

                if (id != null)
                {
                    int ramenId = Int32.Parse(id);
                    Raman updateRamen = db.Ramen.Find(ramenId);

                    List<int> listMeatid = (from Type in db.Ramen select Type.Meatid).Distinct().ToList();

                    MeatDropDown.DataSource = listMeatid;
                    MeatDropDown.DataBind();

                    NameTextBox.Text = updateRamen.Name;
                    BrothTextBox.Text = updateRamen.Broth;
                    PriceTextBox.Text = updateRamen.Price;
                }
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            String updateId = Request["ID"];
            String Name = NameTextBox.Text;
            String meatId = MeatDropDown.Text;
            String Broth = BrothTextBox.Text;
            String Price = PriceTextBox.Text;

            int ramenId = Int32.Parse(updateId);
            int selectedMeatId = Int32.Parse(meatId);
            Raman updateRamen = db.Ramen.Find(ramenId);
            Meat selectedMeat = db.Meats.FirstOrDefault(m => m.id == selectedMeatId);

            updateRamen.Name = Name;
            updateRamen.Meat = selectedMeat;
            updateRamen.Broth = Broth;
            updateRamen.Price = Price;

            db.SaveChanges();
            Response.Redirect("ManageRamen1.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen1.aspx");
        }
    }
}