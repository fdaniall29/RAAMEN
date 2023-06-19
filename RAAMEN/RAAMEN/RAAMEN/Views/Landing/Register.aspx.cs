using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;
using RAAMEN.Factory;
using RAAMEN.Handler;


namespace RAAMEN.Views.Landing
{
    public partial class Register : System.Web.UI.Page
    {
        RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        private RegisterHandler registerHandler;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<string> listGenderid = (from Type in db.Users select Type.Gender).Distinct().ToList();

                GenderDropDown.DataSource = listGenderid;
                GenderDropDown.DataBind();
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            registerHandler = new RegisterHandler();

            bool isRegistered = registerHandler.RegisterUser(
                UsernameTextBox.Text.Trim(),
                EmailTextBox.Text.Trim(),
                GenderDropDown.SelectedValue,
                PasswordTextBox.Text,
                ConfirmTextBox.Text);

            if (isRegistered)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                ErrorLabel.Text = "Registration failed. Please check your input.";
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}