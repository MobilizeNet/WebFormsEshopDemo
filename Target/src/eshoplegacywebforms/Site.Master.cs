using System;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms
{

   [Observable]
   public partial class SiteMaster : Mobilize.Web.UI.Controls.MasterPage
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
            Response.Redirect("eShopLegacyWebForms.LogIn");
         }
     }

     protected void Logout_Click(object sender, EventArgs e)
     {
         Session.Remove("username");
         Response.Redirect("eShopLegacyWebForms.LogIn");
      }

      private bool CheckSession(string sessionID)
      {
          return Session[sessionID] != null;
      }

   }
}