using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_2
{
    public partial class apply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if(Firstname.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('First Name is not filled in.')", true);
            }
            else if(LastName.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('Last name is not filled in')", true);
            }
            else if(AddressOne.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('Address One is not filled in.')", true);
            }
            else if(Zip.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('Zip Code is not filled in')", true);
            }
            else if(Email.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('Email is not filled in')", true);
            }
            else if(PhoneNumber.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('Phone Number is not filled in')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myalert", "alert('" + Firstname.Text + " " + LastName.Text + "\\n" + AddressOne.Text + " " + AddressTwo.Text + "\\n" + City.Text + " " + DropDownList1.SelectedItem + " " + Zip.Text + "\\n" + Email.Text + "\\n" + PhoneNumber.Text +"\\n" + Comments.Text + "')", true);
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Firstname.Text = "";
            LastName.Text = "";
            AddressOne.Text = "";
            AddressTwo.Text = "";
            City.Text = "";
            DropDownList1.SelectedIndex = 0;
            Zip.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";
            Comments.Text = "";
        }
    }
}