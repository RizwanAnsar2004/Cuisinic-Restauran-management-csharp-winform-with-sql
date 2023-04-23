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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = textBox1.Text;
            try 
            {
                string querry ="SELECT * from adminlogin where Name='"+username+"'AND password='"+password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    username = usertxt.Text;
                    password = textBox1.Text;
                    admindashboard fm = new admindashboard();
                    fm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("INVALID CRIDENTIALS");
                    usertxt.Clear();
                    textBox1.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
