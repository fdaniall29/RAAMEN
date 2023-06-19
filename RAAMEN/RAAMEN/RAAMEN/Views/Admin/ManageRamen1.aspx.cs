using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN.Models;
using RAAMEN.Repository;
using RAAMEN.Handler;

namespace RAAMEN.Views.Admin
{
    public partial class ManageRamen1 : System.Web.UI.Page
    {
        private Handler.ManageRamen1Handler handler = new Handler.ManageRamen1Handler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Session"] == null)
            {
                Response.Redirect("../Landing/Login.aspx");
            }

            if (IsPostBack == false)
            {
                List<Raman> list = handler.GetAllRamen();
                ManageRamenGridView.DataSource = list;
                ManageRamenGridView.DataBind();
            }
        }

        protected void ManageRamenGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ManageRamenGridView.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("ManageRamen2.aspx?ID=" + id);
        }

        protected void ManageRamenGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ManageRamenGridView.Rows[e.RowIndex];
            string Id = row.Cells[0].Text.ToString();

            int ramenId = Int32.Parse(Id);

            handler.DeleteRamen(ramenId);

            ManageRamenGridView.DataSource = handler.GetAllRamen();
            ManageRamenGridView.DataBind();
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen3.aspx");
        }
    }
}