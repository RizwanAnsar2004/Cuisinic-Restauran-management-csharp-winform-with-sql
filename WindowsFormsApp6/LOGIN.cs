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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = passtxt.Text;
            try
            {
                string querry = "select * from staff where USERNAME= '" + username + "'AND PASSWORD='" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = usertxt.Text;
                    password = passtxt.Text;

                    staffdashboard fm = new staffdashboard();
                    fm.Show();
                    this.Hide();
                    Form1 ds = new Form1();
                    ds.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid Cridentials");
                    usertxt.Clear();
                    passtxt.Clear();
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
