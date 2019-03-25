using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonLib;

namespace Class2ExampleWeb.Controls
{
    public partial class EditContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["Login"]) != "true")
            {
                Response.Redirect("../Controls/Login.aspx");
            }
        }

        protected void Fill_Click(object sender, EventArgs e)
        {
            Person temp = (Person)Session["Person"];
            FirstName.Text = temp.FirstName;
            LastName.Text = temp.LastName;
            Street1.Text = temp.StreetOne;
            Street2.Text = temp.StreetTwo;
            City.Text = temp.City;
            State.Text = temp.State;
            Zip.Text = temp.ZipCode;
            Email.Text = temp.Email;
            PhoneNumber.Text = temp.Phone;

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.FirstName = FirstName.Text;
            temp.LastName = LastName.Text;
            temp.StreetOne = Street1.Text;
            temp.StreetTwo = Street2.Text;
            temp.City = City.Text;
            temp.State = State.Text;
            temp.ZipCode = Zip.Text;
            temp.Email = Email.Text;
            temp.Phone = PhoneNumber.Text;
            Session["Person"] = temp;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert('Success!');", true);
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Street1.Text = "";
            Street2.Text = "";
            City.Text = "";
            State.SelectedIndex = 0;
            Zip.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";
            Notes.Text = "";
        }
    }
}