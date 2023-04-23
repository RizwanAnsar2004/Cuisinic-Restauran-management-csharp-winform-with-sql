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
    public partial class workers : UserControl
    {
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public workers()
        {
            InitializeComponent();
            try
            {
                adpt = new SqlDataAdapter("SELECT USERNAME FROM staff", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;

                timer1 = new Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
            }
            catch 
            {
                MessageBox.Show("AN ERROR OCCURED WHILE DISPLAYING WORKERS");
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    string uid = textBox2.Text;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM staff WHERE USERNAME=@name", conn);
                    cmd.Parameters.AddWithValue("@name", uid);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("MEMBER DELETED SUCCESSFULLY");
                    textBox2.Clear();
                }
                catch
                {
                    MessageBox.Show("AN ERROR OCCURED WHILE DELETING RECORD");
                    textBox2.Clear();
                }
            }
            else { MessageBox.Show("PLEASE FILL GIVEN FIELDS"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt.Clear();
            adpt.Fill(dt);
        }
    }
}
