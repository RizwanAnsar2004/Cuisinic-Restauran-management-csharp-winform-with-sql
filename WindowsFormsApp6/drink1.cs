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
    public partial class drink1 : UserControl
    {
        public drink1()
        {
            InitializeComponent();
            int cost = price("Kochi iced Yuzu drink");
            button1.Text =  cost.ToString();
            cost = price("Suntory Boss unsweetened black");
            button2.Text =  cost.ToString();
            cost = price("Georgia Coffee original ");
            button3.Text =  cost.ToString();
            cost = price("Doutor Drives instant cup of coffee");
            button4.Text =  cost.ToString();
            cost = price("Pokka Sapporo Aromax Black");
            button5.Text =  cost.ToString();
            cost = price("Kirin Fire Smoked Coffee Black ");
            button6.Text =  cost.ToString();
            cost = price("Georgia Emerald Mountain Blend Black");
            button7.Text =  cost.ToString();
            cost = price("Snow Brand Megumiruku Snow Brand Coffee");
            button8.Text =  cost.ToString();
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        //to get price of drink
        public int price(string dname)
        {
            int price = 0;
            conn.Open();
            try
            {
                string query = "SELECT price FROM drinks WHERE drinks=@name";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@name", dname);
                sql.Connection = conn;
                using (SqlDataReader reader = sql.ExecuteReader())
                    while (reader.Read())
                    {
                        string u = reader["price"].ToString();
                        price = int.Parse(u);
                    }
                
                return price;
            }
            catch
            { MessageBox.Show("AN ERROR OCCURED WHILE INTERACTING WITH DATABASE");
                return price;
            }
            finally { conn.Close(); }
        }

        // save new values in billing table in database.
        public void add_sql(string name, int cost, int quantity, int total_cost)
        {
            conn.Open();
            try
            {
                string query = "INSERT INTO Bill(product,quantity,price,total) VALUES(@name,@number,@cost,@ttl)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@number", quantity);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@ttl", total_cost);
                cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("AN ERROR OCCURED WHILE ADDING TO CART\n PLEASE CONTACT ADMIN"); }
            finally {
                MessageBox.Show("ADDED TO CART SUCCESSFULLY.");
                conn.Close();
            }
        }

        // main method calling 
        private void button4_Click(object sender, EventArgs e)
        {
            string name = "Doutor Drives instant cup of coffee";
            int quantity = int.Parse(comboBox4.Text);
            if (quantity > 0 && quantity <=20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Georgia Coffee original ";
            int quantity = int.Parse(comboBox3.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = "Georgia Emerald Mountain Blend Black";
            int quantity = int.Parse(comboBox7.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Kochi iced Yuzu drink";
            int quantity = int.Parse(comboBox1.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = "Pokka Sapporo Aromax Black";
            int quantity = int.Parse(comboBox5.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = "Snow Brand Megumiruku Snow Brand Coffee";
            int quantity = int.Parse(comboBox8.Text);
            if (quantity > 0 && quantity <=20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Suntory Boss unsweetened black";
            int quantity = int.Parse(comboBox2.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = "Kirin Fire Smoked Coffee Black ";
            int quantity = int.Parse(comboBox6.Text);
            if (quantity > 0 && quantity <= 20)
            {
                int cost = price(name);
                int total_price = quantity * cost;
                add_sql(name, cost, quantity, total_price);
            }
            else { MessageBox.Show("PLEASE CONTACT ADMIN FOR BIG ORDERS");
                comboBox4.Text = "1";
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }

        }
    }
}

