using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;

namespace RAAMEN.Views.Staff
{
    public partial class Profile1 : System.Web.UI.Page
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["User_Session"] != null)
                {
                    User u = (User)Session["User_Session"];
                    User x = db.Users.Find(u.Id);

                    UsernameTextBox.Text = x.Username;
                    EmailTextBox.Text = x.Email;
                    GenderTextBox.Text = x.Gender;
                    PasswordTextBox.Text = x.Password;
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile2.aspx");
        }
    }
}