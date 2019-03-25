using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassOne
{
    public partial class ExampleOne : System.Web.UI.Page
    {
        Boolean ifClick = false;
        Boolean ifNeg = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Btn1_Click(object sender, EventArgs e)
        {
            LCD.Text += "1";
        }
        protected void Btn2_Click(object sender, EventArgs e)
        {
            LCD.Text += "2";
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            LCD.Text += "3";
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Session["num1"] = LCD.Text;
            Session["Op"] = "+";
            LCD.Text = "";
            LCDfStore.Text = Convert.ToString(Session["Op"]);
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            LCD.Text += "4";
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            LCD.Text += "5";
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            LCD.Text += "6";
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            Session["num1"] = LCD.Text;
            Session["Op"] = "-";
            LCD.Text = "";
            LCDfStore.Text = Convert.ToString(Session["Op"]);
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            LCD.Text += "7";
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            LCD.Text += "8";
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            LCD.Text += "9";
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            Session["num1"] = LCD.Text;
            Session["Op"] = "*";
            LCD.Text = "";
            LCDfStore.Text = Convert.ToString(Session["Op"]);
        }

        protected void BtnEq_Click(object sender, EventArgs e)
        {
            double num1, num2, num3 = 0;
            String operand = Convert.ToString(Session["Op"]);
            num1 = Convert.ToDouble(Session["num1"]);
            num2 = Convert.ToDouble(LCD.Text);
            switch(operand)
            {
                case "+":
                    num3 = num1 + num2;
                    break;

                case "-":
                    num3 = num1 - num2;
                    break;

                case "*":
                    num3 = num1 * num2;
                    break;
                case "/":
                    num3 = num1 / num2;
                    break;
            }
            LCD.Text = Convert.ToString(num3);
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            LCD.Text = "";
            Session["num1"] = "";
            Session["Op"] = "";
            Session["MS"] = "";
            LCDfStore.Text = "";
            LCDmStore.Text = "";
        }

        protected void BtnMR_Click(object sender, EventArgs e)
        {
            LCD.Text = Convert.ToString(Session["MS"]);
        }

        protected void BtnMS_Click(object sender, EventArgs e)
        {
            Session["MS"] = LCD.Text;
            LCDmStore.Text = Convert.ToString(Session["MS"]);
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            Session["num1"] = LCD.Text;
            Session["Op"] = "/";
            LCD.Text = "";
            LCDfStore.Text = Convert.ToString(Session["Op"]);
        }


        protected void Btn_Click(object sender, EventArgs e)
        {
            if (ifNeg == false)
            {
                double holder = Convert.ToDouble(LCD.Text);
                holder = holder * (-1);
                LCD.Text = Convert.ToString(holder);
                ifNeg = true;
            }
            else
            {
                double holder = Convert.ToDouble(LCD.Text);
                Math.Abs(holder);
                LCD.Text = Convert.ToString(holder);
                ifNeg = false;
            }
        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            LCD.Text += "0";
        }

        protected void BtnDec_Click(object sender, EventArgs e)
        {
            if (ifClick == false)
            {
                LCD.Text += ".";
                ifClick = true;
            }
        }
    }
}