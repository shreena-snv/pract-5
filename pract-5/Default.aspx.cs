using System;

namespace pract_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }

                lblWelcome.Text = "Welcome, " +
                    Session["UserID"].ToString();
            }
        }

        protected void calleave_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = calleave.SelectedDate;

            lblSelectedDate.Text = "Selected Date: " +
                dt.ToString("dd/MM/yyyy");

            Session["Leave"] = dt;
        }

        protected void btnLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leave.aspx");
        }
    }
}