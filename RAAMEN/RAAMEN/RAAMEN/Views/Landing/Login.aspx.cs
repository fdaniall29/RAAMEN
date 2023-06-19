using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;
using RAAMEN.Handler;

namespace RAAMEN.Views.Landing
{
    public partial class Login : System.Web.UI.Page
    {
        LoginHandler loginHandler = new LoginHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["User_Cookie"];
            if (Cookie != null)
            {
                UsernameTextBox.Text = Cookie.Values["Username"];
                PasswordTextBox.Text = Cookie.Values["Password"];
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text;
            bool isRemember = RememberMe.Checked;

            var User = loginHandler.ValidateUser(Username, Password);
            if (User != null)
            {
                if (isRemember)
                {
                    HttpCookie Cookie = new HttpCookie("User_Cookie");
                    Cookie.Values["Username"] = Username;
                    Cookie.Values["Password"] = Password;
                    Cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(Cookie);
                }
                Session["User_Session"] = User;

                switch (User.Roleid)
                {
                    case 1:
                        Response.Redirect("../Admin/Home1.aspx");
                        break;
                    case 2:
                        Response.Redirect("../Staff/Home1.aspx");
                        break;
                    case 3:
                        Response.Redirect("../Customer/Home1.aspx");
                        break;
                    default:
                        ErrorLabel.Text = "Invalid role!";
                        ErrorLabel.ForeColor = System.Drawing.Color.Red;
                        break;
                }
            }
            else
            {
                ErrorLabel.Text = "User not found !";
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}