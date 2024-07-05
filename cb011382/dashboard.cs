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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Additem aif = new Additem();
            aif.Show();
            this.Hide();
        }

        private void delete_item_Click(object sender, EventArgs e)
        {
            Deleteitem dif = new Deleteitem();
            dif.Show();
            this.Hide();
        }
    }
}
