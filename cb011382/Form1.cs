using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cb011382
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals("admin") && txtpassword.Text.Equals("1234"))
            {
                dashboard adf = new dashboard();
                adf.Show();
                this.Hide();
            }
            else
            {
                lblerror.Text = "Invalid username or password";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {



            txtusername.Text = "";
            txtpassword.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
