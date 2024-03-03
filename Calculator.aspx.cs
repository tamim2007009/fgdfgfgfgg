using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concatenation
{
    public partial class Calculator : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(TextBox1.Text);
            double num2 = int.Parse(TextBox2.Text);
            double result = 0;

            result = num1 + num2;
            Label1.Text=$"{result}";
             
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);
            double result = 0;
            if (num2 == 0)
            {
                Label1.Text = "result";            }
            else {
                result = num1 / num2;

                Label1.Text = $"{result}";


            }


        }

    

        protected void Button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);
            double result = 0;

            result = num1 * num2;
            Label1.Text = $"{result}";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);
            double result = 0;

            result = num1 - num2;
            Label1.Text = $"{result}";


        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Button1.Text = string.Empty;
            Button2.Text=string.Empty;
            Button3.Text=string.Empty;
            Button4.Text=string.Empty;
            

            Label1.Text = string.Empty;

        }
    }
}