using System;
using System.Web.UI;

namespace eShopLegacyWebForms
{
    public partial class LogIn : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("~/Home.aspx");
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!CheckUsername(username))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Username, please try again.";
            }
            else if (!CheckPassword(password))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Password, please try again.";
            }
            else
            {
                Session["username"] = username;
                Response.Redirect("~/Home.aspx");
            }
        }

        private bool CheckPassword(string password)
        {
            return password.Equals("123");
        }

        private bool CheckUsername(string username)
        {
            return username.Equals("admin");
        }
    }
}