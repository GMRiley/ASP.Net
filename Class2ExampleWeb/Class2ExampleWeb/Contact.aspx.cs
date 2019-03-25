using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonLib;

namespace Class2ExampleWeb
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
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
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError","alert('Success!');", true);
            }
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