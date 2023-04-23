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
    public partial class food1 : UserControl
    {
        public food1()
        {
            InitializeComponent();
            int cost = Cost("Hiyaykko Chilled Tofu");
            button1.Text = cost.ToString();
            cost = Cost("Inari Sushi");
            button2.Text = cost.ToString();
            cost = Cost(" Japanese Chicken Katsu Curry");
            button3.Text = cost.ToString();
            cost = Cost("Okonomiyaki Japanese");
            button4.Text = cost.ToString();
            cost = Cost("Ponzu beef donburi rice bowl");
            button5.Text = cost.ToString();
            cost = Cost("Takoyaki");
            button6.Text = cost.ToString();
            cost = Cost("Tamagoyak Japanese");
            button7.Text = cost.ToString();
            cost = Cost("Tempura");
            button8.Text = cost.ToString();
            cost = Cost("Sashimi");
            button9.Text = cost.ToString();
            cost = Cost("Yakitori");
            button10.Text = cost.ToString();
            cost = Cost("Zaru Soba Chilled Noodles");
            button11.Text = cost.ToString();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        
        // Function to get price of dish
        public int Cost(string fname)
        {
            int price = 0;
            try
            {
                
                conn.Open();
                string querry = "SELECT price FROM foods WHERE food=@name";
                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.AddWithValue("@name", fname);
                command.Connection = conn;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string v = reader["price"].ToString();
                        price = int.Parse(v);
                    }
                }
                return price;
            }
            catch 
            {
                MessageBox.Show("AN ERROR OCCURED WHILE READING PRICE");
                return price;
            }
            finally
            {
                conn.Close();
            }
        }

        public void add_sql(string fname,int cost,int quantity,int total_price)
        {
            conn.Open();
            try
            {
                string sql = "INSERT INTO Bill (product,quantity,price,total) VALUES (@fname, @number, @cost,@total)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@number", quantity);
                    command.Parameters.AddWithValue("@cost", cost);
                    command.Parameters.AddWithValue("@total", total_price);
                    command.ExecuteNonQuery();
                }
            }
            catch { MessageBox.Show("An ERROR OCCURED WHILE ADDING TO CART\n PLEASE CONTACT ADMIN"); }
            finally {
                MessageBox.Show("ADDED TO CART SUCCESSFULLY.");
                conn.Close(); }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = "Hiyaykko Chilled Tofu";
                int quantity = int.Parse(comboBox1.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox1.Text="1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = "Inari Sushi";
             int quantity = int.Parse(comboBox2.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox2.Text = "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fname = " Japanese Chicken Katsu Curry";
            int quantity = int.Parse(comboBox3.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox3.Text = "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fname = "Okonomiyaki Japanese";
                int quantity = int.Parse(comboBox4.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fname = "Ponzu beef donburi rice bowl";
               int quantity = int.Parse(comboBox5.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox5.Text = "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fname = "Takoyaki";
                int quantity = int.Parse(comboBox6.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox6.Text = "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fname = "Tamagoyak Japanese";
                int quantity = int.Parse(comboBox7.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox7.Text = "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fname = "Tempura";
                int quantity = int.Parse(comboBox8.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox8.Text = "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fname = "Zaru Soba Chilled Noodles";
                int quantity = int.Parse(comboBox11.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox11.Text = "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fname = "Sashimi";
                int quantity = int.Parse(comboBox9.Text);
            if (quantity <= 20 && quantity > 0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox9.Text = "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fname = "Yakitori";
                int quantity = int.Parse(comboBox10.Text);
            if (quantity <= 20&&quantity>0)
            {
                int price = Cost(fname);
                int total_price = quantity * price;
                add_sql(fname, price, quantity, total_price);
            }
            else
            {
                MessageBox.Show("PLEASE DIRECTLY CONTACT ADMIN FOR LARGER ORDERS");
                comboBox10.Text = "1";
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }
    }

}

