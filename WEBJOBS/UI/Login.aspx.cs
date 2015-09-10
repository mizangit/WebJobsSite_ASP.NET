using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBJOBS.Model;
using WEBJOBS.BLL;

namespace WEBJOBS.UI
{
    public partial class Login : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton2(object sender, EventArgs e)
        {
          

             String Email = emailTextBox.Text;
            String Passwod = passwodTextBox.Text;

            UserInfoModel aUserInfo = aUserManager.login(Email);


            if (aUserInfo != null && aUserInfo.Passwod == Passwod)
            {
                Session["login"] = aUserInfo.Name;
                Response.Redirect("~/UI/Home.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('Unregistered User')", true);

            }

        }
    }
}