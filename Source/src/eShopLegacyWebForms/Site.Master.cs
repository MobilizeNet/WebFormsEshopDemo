using System;
using System.Web.UI;

namespace eShopLegacyWebForms
{
    public partial class SiteMaster : MasterPage
    {
        /// <summary>
        /// Example legacy usage of a session variable embedded in a MasterPage
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckSession("username"))
            {
                lblUsername.Text = Session["username"].ToString();
            }
            else
            {
                Response.Redirect("~/LogIn.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("~/LogIn.aspx");
        }

        private bool CheckSession(string sessionID)
        {
            return Session[sessionID] != null;
        }
    }
}