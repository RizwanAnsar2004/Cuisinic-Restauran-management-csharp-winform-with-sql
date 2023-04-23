using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class view_orders : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");

        public SqlDataAdapter adpt;
        public DataTable dt;
        public view_orders()
        {
            InitializeComponent();
            try
            {
                adpt = new SqlDataAdapter("SELECT * FROM orders", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Clear();
                adpt.Fill(dt);

                timer1 = new Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURED WHILE DISPLAYING ORDERS");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM orders WHERE id = @uid", conn);
                    cmd.Parameters.AddWithValue("@uid", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    textBox2.Clear();
                    MessageBox.Show("ORDER COMPLETED SUCCESSFULLY");
                }
                catch
                {
                    MessageBox.Show("AN ERROR OCCURED WHILE REGISTERING PRODUCT IN COMPLETED");
                }
            }
            else { MessageBox.Show("PLEASE FILL GIVEN FIELDS"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt.Clear();
            adpt.Fill(dt);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }
        }
    }
}
