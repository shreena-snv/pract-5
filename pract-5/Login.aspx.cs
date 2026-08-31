using System;
using System.Web;

namespace pract_5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = txtUser.Text.Trim();
            string password = txtPwd.Text;

            if (userid == "student" && password == "1234")
            {
                Session["UserID"] = userid;

                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserID");
                    cookie.Value = userid;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid UserID or Password.";
            }
        }
    }
}