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
using System.Windows.Forms;


namespace cb011382
{
    public partial class Deleteitem : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Deleteitem()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard adf = new dashboard();
            adf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Stock_item where stock_code=" + Convert.ToInt32(txtcode.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtname.Text = dr["stock_name"].ToString();
                    txtquantity.Text = dr["stock_quantity"].ToString();

                }
                else
                {
                    MessageBox.Show("Invalid ID", "Stock Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you need to delete this Stock Item ", "Stock Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    
                    string sql = "DELETE FROM Stock_item WHERE stock_code=" + Convert.ToInt32(txtcode.Text.ToString());
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Item deleted Successfully", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Deleteitem_Load(object sender, EventArgs e)
        {

        }
    }
}
