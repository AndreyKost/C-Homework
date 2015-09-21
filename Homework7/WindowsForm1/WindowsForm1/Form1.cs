using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.Text = "Andrey";

        }

        private void label2_Click(object sender, EventArgs e)
        {

            label2.Text = "Kostadinov";
        }

        private void label3_Click(object sender, EventArgs e)
        {

            label3.Text = "anddy8@gmail.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter writer = new StreamWriter("Names.txt"))
            {
                writer.WriteLine(label1.Text);
                writer.WriteLine(label2.Text);
                writer.WriteLine(label3.Text);
            }
            button1.Enabled = false;
        }

    }
}
