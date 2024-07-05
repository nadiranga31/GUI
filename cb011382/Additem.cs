using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;



namespace cb011382
{
    public partial class Additem : Form
    {
        DataTable table = new DataTable("table");

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Additem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string regdate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); //assigning the date from the date time picker
                string status = "Item Added";
                string sql = "INSERT INTO Stock_item (stock_code, stock_name, stock_quantity, date)VALUES(" + txtcode.Text + ", '" + txtname.Text + "', " + txtquantity.Text + ", '" + regdate + "')";
                string sql1 = "INSERT INTO Transaction_log (stock_code, stock_name, stock_quantity, stock_regdate, stock_status)VALUES(" + txtcode.Text + ", '" + txtname.Text + "', " + txtquantity.Text + ",'" + regdate + "' ,'" + status + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Item Added Successfully", " Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Details", " Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                conn.Close();
            }

            table.Rows.Add(txtcode.Text, txtname.Text, txtquantity.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleteitem dif = new Deleteitem();
            dif.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dashboard adf = new dashboard();
            adf.Show();
            this.Hide();
        }

        private void Additem_Load(object sender, EventArgs e)
        {
            table.Columns.Add("stock_code", Type.GetType("System.Int32"));
            table.Columns.Add("stock_name", Type.GetType("System.String"));
            table.Columns.Add("stock_quantity", Type.GetType("System.Int32"));
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }
    }
}
