using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonLib;

namespace Class2ExampleWeb.Controls
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Convert.ToString(Session["Login"]) == "true")
            {
                Response.Redirect("../Controls/ContentManager.aspx");
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            if(temp.ValidLogin(UserName.Text, Password.Text))
            {
                Session["Login"] = "true";
                Response.Redirect("../Controls/ContentManager.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, this.GetType(),"myalert","alert('UserName or Password is incorrect')",true);
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }
    }
}