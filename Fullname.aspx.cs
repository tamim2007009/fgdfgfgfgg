using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concatenation
{
    public partial class Fullname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B1_Click(object sender, EventArgs e)
        {
            // Concatenate the first name and last name and display the result
            string firstName = TextBox1.Text;
            string lastName = TextBox2.Text;
            string fullName = $"{firstName} {lastName}";

            // Set the text of the label to the full name
            FullNameLabel.Text = $" {fullName}";
        }

        protected void B2_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            TextBox1.Text = "";
            TextBox2.Text = "";
            FullNameLabel.Text=string.Empty;
        }
    }
}
