using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;

namespace RAAMEN.Views.Customer
{
    public partial class Profile2 : System.Web.UI.Page
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
                List<string> u = db.Users.Select(x => x.Gender).Distinct().ToList();
                GenderDropDown.DataSource = u;
                GenderDropDown.DataBind();

                User y = (User)Session["User_Session"];
                User z = db.Users.Find(y.Id);

                UsernameTextBox.Text = z.Username;
                EmailTextBox.Text = z.Email;
                GenderDropDown.Text = z.Gender;
                PasswordTextBox.Text = z.Password;

            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            String Username = UsernameTextBox.Text;
            String Email = EmailTextBox.Text;
            String Gender = GenderDropDown.Text.ToString();
            String Password = PasswordTextBox.Text;

            User y = (User)Session["User_Session"];
            User x = db.Users.Find(y.Id);

            x.Username = Username;
            x.Email = Email;
            x.Gender = Gender;
            x.Password = Password;

            DataBind();
            db.SaveChanges();
            Response.Redirect("Profile1.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile1.aspx");
        }
    }
}