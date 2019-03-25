using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonLib;

namespace Class2ExampleWeb.Controls
{
    public partial class ContentManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Convert.ToString(Session["Login"])!= "true")
            {
                Response.Redirect("../Controls/Login.aspx");
            }
            try
            {
                Person temp = (Person)Session["Person"];
                TableRow row = new TableRow();
                PropertyInfo[] properties = temp.GetType().GetProperties();
                for(int counter = 0; counter < properties.Length; counter++)
                {
                    TableCell cell = new TableCell
                    {
                        Text = properties[counter].GetValue(temp).ToString()
                    };
                    row.Cells.Add(cell);
                }
                TableCell edit = AddEdit();
                row.Cells.Add(edit);
                TableCell delete = AddDelete();
                row.Cells.Add(delete);
                Table1.Rows.Add(row);
            }
            catch (Exception)
            {
                
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session["Login"] = "";
            Response.Redirect("../Controls/Login.aspx");
        }
        protected TableCell AddEdit()
        {
            TableCell edit = new TableCell();
            Button btnEdit = new Button();
            btnEdit.ID = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.Click += new EventHandler(Btn_edit);
            edit.Controls.Add(btnEdit);
            return edit;
        }
        protected TableCell AddDelete()
        {
            TableCell delete = new TableCell();
            Button btnDelete = new Button();
            btnDelete.ID = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.Click += new EventHandler(Btn_Delete);
            delete.Controls.Add(btnDelete);
            return delete;
        }
        protected void Btn_Delete(object sender, EventArgs e)
        {
            Session["Person"] = "";
            Response.Redirect("../Controls/ContentManager.aspx");
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Response.Redirect("../Controls/EditContent.aspx");
        }
    }
}