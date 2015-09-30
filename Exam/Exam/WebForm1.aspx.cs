using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

namespace Exam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
                {
                }
                onLoad.Text = "Welcome!";
            }
            catch (Exception)
            {
                onLoad.Text = "File not loaded!";
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            Data toAdd = new Data();
            toAdd.Country = countrylText.Text;
            toAdd.Capital = capitalText.Text;
            toAdd.Population = int.Parse(populationText.Text);
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(toAdd);
            }
            
        }

        protected void secondClick(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
            
        }

    }
}