using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.MasterPage
{
    public partial class Staff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/Home1.aspx");
        }

        protected void ManageRamenButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen1.aspx");
        }

        protected void OrderQueueButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/OrderQueue1.aspx");
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/Profile1.aspx");
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../Landing/Login.aspx");
        }
    }
}