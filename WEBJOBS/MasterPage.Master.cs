using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBJOBS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                loginLabel.Text = "Welcome " + Session["login"].ToString();
                loginLabel.Visible = true;
                logLinkButton.Text = "Logout";
                registerLinkButton.Visible = false;
                
            }
            else
            {
                loginLabel.Visible = false;
                logLinkButton.Text = "Login";
                registerLinkButton.Visible = true;
                registerLinkButton.Text = "Register";
            }
        }

        protected void logLinkButton_Click(object sender, EventArgs e)
        {
            if (logLinkButton.Text == "Login")
            {
                Response.Redirect("~/UI/Login.aspx");
            }
            else
            {
                Session.Clear();
                Response.Redirect("~/UI/Home.aspx");

            }
        }

        protected void registerLinkButton_Click(object sender, EventArgs e)
        {
            if (registerLinkButton.Text == "Register")
            {
                Response.Redirect("~/UI/Register.aspx");
            }
        }
    }
}