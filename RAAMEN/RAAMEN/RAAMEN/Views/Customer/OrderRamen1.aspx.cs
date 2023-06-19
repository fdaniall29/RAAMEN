using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;

namespace RAAMEN.Views.Customer
{
    public partial class OrderRamen1 : System.Web.UI.Page
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }
            List<Raman> list = (db.Ramen).ToList();
            RamenGridView.DataSource = list;
            RamenGridView.DataBind();
        }
    }
}