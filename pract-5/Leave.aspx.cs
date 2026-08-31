using System;
using System.Web;

namespace pract_5
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                if (Request.Cookies["UserID"] != null)
                {
                    Session["UserID"] =
                        Request.Cookies["UserID"].Value;
                }
                else
                {
                    Response.Redirect("Login.aspx");
                    return;
                }
            }

            if (!IsPostBack)
            {
                if (Request.Cookies["StudentName"] != null)
                    txtName.Text =
                        Request.Cookies["StudentName"].Value;

                if (Session["Leave"] != null)
                {
                    DateTime dt =
                        (DateTime)Session["Leave"];

                    txtSelectedDate.Text =
                        dt.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtSelectedDate.Text =
                        "No date selected";
                }
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblMessage.Text =
                    "Please enter your name.";
                return;
            }

            if (ddlLeaveType.SelectedValue == "0")
            {
                lblMessage.Text =
                    "Please select leave type.";
                return;
            }

            if (Session["Leave"] == null)
            {
                lblMessage.Text =
                    "Please select a date.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLeaveReason.Text))
            {
                lblMessage.Text =
                    "Please enter reason.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDays.Text))
            {
                lblMessage.Text =
                    "Please enter days.";
                return;
            }

            Session["StudentName"] = txtName.Text;
            Session["LeaveType"] =
                ddlLeaveType.SelectedItem.Text;
            Session["LeaveReason"] =
                txtLeaveReason.Text;
            Session["LeaveDays"] = txtDays.Text;

            Response.Cookies["StudentName"].Value =
                txtName.Text;
            Response.Cookies["StudentName"].Expires =
                DateTime.Now.AddDays(7);

            DateTime leaveDate =
                (DateTime)Session["Leave"];

            lblMessage.Text =
                "<b>Leave Applied Successfully!</b><br/><br/>" +
                "Name : " + Server.HtmlEncode(txtName.Text) +
                "<br/>Type : " +
                ddlLeaveType.SelectedItem.Text +
                "<br/>Date : " +
                leaveDate.ToString("dd/MM/yyyy") +
                "<br/>Reason : " +
                Server.HtmlEncode(txtLeaveReason.Text) +
                "<br/>Days : " +
                Server.HtmlEncode(txtDays.Text);
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            if (Request.Cookies["UserID"] != null)
            {
                HttpCookie cookie =
                    new HttpCookie("UserID");
                cookie.Expires =
                    DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("Login.aspx");
        }
    }
}