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
    public partial class Register : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerButton_Click(object sender, EventArgs e)
        {
            RegisterInsert();
        }

        public void RegisterInsert()
        {
            UserInfoModel aUserInfo = new UserInfoModel();

            aUserInfo.Name = nameTextBox.Text;
            aUserInfo.Email = emailTextBox.Text;
            aUserInfo.Passwod = passwordTextBox.Text;

            String message = aUserManager.InsertUserInfo(aUserInfo);

            if (message == "Successfully Registered")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('" + message + "')", true);
                Response.Redirect("~/UI/Login.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('" + message + "')", true);
            }


        }
    }
}