using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;
using RAAMEN.Repository;
using RAAMEN.Handler;
using RAAMEN.Factory;

namespace RAAMEN.Views.Admin
{
    public partial class Home2 : System.Web.UI.Page
    {
        Home2Handler homeHandler;
        public Home2()
        {
            this.homeHandler = new Home2Handler(new Home2Repository(), new Home2Factory());
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }

            if (!IsPostBack)
            {
                string Id = Request["ID"].ToString();
                int userId = Int32.Parse(Id);
                User updateUser = homeHandler.GetUser(userId);

                List<string> listType = homeHandler.GetDistinctGenders();

                GenderDropDown.DataSource = listType;
                GenderDropDown.DataBind();

                UsernameTextBox.Text = updateUser.Username;
                EmailTextBox.Text = updateUser.Email;
                GenderDropDown.SelectedValue = updateUser.Gender;
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            String updateId = Request["ID"];
            String Username = UsernameTextBox.Text;
            String Email = EmailTextBox.Text;
            String Gender = GenderDropDown.Text.ToString();

            int userId = Int32.Parse(updateId);
            homeHandler.UpdateUser(userId, Username, Email, Gender);
            Response.Redirect("Home1.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home1.aspx");
        }
    }
}