using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;

namespace RAAMEN.Views.Staff
{
    public partial class Home1 : System.Web.UI.Page
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }
            var CurrentUser = (User)Session["User_Session"];

            CurrentUser.Roleid = 2;

            using (var db = new RaamenDatabaseEntities())
            {
                var Customer = db.Users.Where(u => u.Roleid == 3).ToList();

                StaffGridView.DataSource = Customer;
                StaffGridView.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = StaffGridView.Rows[e.NewEditIndex];
            string Id = row.Cells[0].Text.ToString();
            Response.Redirect("Home2.aspx?ID=" + Id);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = StaffGridView.Rows[e.RowIndex];
            string Id = row.Cells[0].Text.ToString();

            int userId = Int32.Parse(Id);

            User u = (db.Users.Find(userId));
            db.Users.Remove(u);
            db.SaveChanges();

            StaffGridView.DataSource = db.Users.Where(x => x.Roleid == 3).ToList();
            StaffGridView.DataBind();
        }
    }
}