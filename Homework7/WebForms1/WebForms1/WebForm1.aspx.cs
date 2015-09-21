using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace WebForms1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter writer =new System.IO.StreamWriter(@"C:\Users\anna\Documents\Visual Studio 2013\Projects\WebForms1\WebForms1\bin\REGISTER.txt"))
            {
                writer.WriteLine(TextBox1.Text);
                writer.WriteLine(TextBox2.Text);
                writer.WriteLine(TextBox3.Text);
                writer.WriteLine(TextBox4.Text);
                writer.WriteLine(TextBox5.Text);
            }
            Button1.Enabled = false;
        }
    }
}