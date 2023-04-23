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
    public partial class registration_page : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public registration_page()
        {
            InitializeComponent();
        }

        private void registration_page_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" && textBox4.Text != "")
                {

                    conn.Open();
                    string selectSql = "SELECT COUNT(*) FROM staff WHERE USERNAME = @value";
                    using (SqlCommand command = new SqlCommand(selectSql, conn))
                    {
                        command.Parameters.AddWithValue("@value", textBox2.Text);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE staff SET PASSWORD=@pass WHERE USERNAME=@uid", conn);
                            cmd.Parameters.AddWithValue("@pass", textBox4.Text);
                            cmd.Parameters.AddWithValue("@uid", textBox2.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("PASSWORD CHANGED SUCCESSFULLY");
                            textBox2.Clear();
                            textBox4.Clear();
                        }
                        else
                        {
                            MessageBox.Show("THIS USERNAME DOESNOT EXIST");
                            textBox2.Clear();
                            textBox4.Clear();
                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("PLEASE FILL BOTH TEXTBOX");
                    textBox2.Clear();
                    textBox4.Clear();
                }
            }
            catch {
                MessageBox.Show("AN ERROR OCCURED WHILE UPDATING PASSWORD");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text != "" && textBox3.Text != "")
            {

                SqlCommand sql = new SqlCommand("INSERT INTO staff(USERNAME,PASSWORD)VALUES(@value1,@value2)", conn);
                sql.Parameters.AddWithValue("@value1", textBox1.Text);
                sql.Parameters.AddWithValue("@value2", textBox3.Text);
                sql.ExecuteNonQuery();

                MessageBox.Show("NEW MEMBER ADDED SUCCESSFULLY");
                textBox1.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("PLEASE FILL OUT BOTH TEXTBOX");
                textBox1.Clear();
                textBox3.Clear();
            }
            conn.Close();
        }
    }
}


