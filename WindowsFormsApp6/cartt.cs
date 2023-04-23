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
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace WindowsFormsApp6
{
    public partial class cartt : UserControl
    {

        private SqlDataAdapter adpt;
        private DataTable dt;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ACEO563\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public cartt()
        {
            InitializeComponent();
            adpt = new SqlDataAdapter("SELECT * FROM Bill", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.Clear();
            adpt.Fill(dt);

            timer1 = new Timer();
            timer1.Interval = 1000; // 1 second
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        public void delete()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Bill", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch { MessageBox.Show("AN UNEXPECTED ERROR OCCURED WHILE PRINTING BILL."); }
        }
        public double total()
        {
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    total += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("AN ROW HAS BEEN IGNORED WHILE CALCULATING");
                }
            }
            return total;
        }

        public void print()
        {
            try
            {
                string filename = Path.GetRandomFileName();
                Document pdfDoc = new Document(PageSize.A4, 25, 10, 25, 10);
                PdfWriter.GetInstance(pdfDoc, new FileStream(filename + ".pdf", FileMode.Create));
                pdfDoc.Open();
                Paragraph title = new Paragraph("Cuisinec Japanese Restaurant");
                title.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(title); pdfDoc.Add(new Paragraph(DateTime.Now.ToString()));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        table.AddCell(dataGridView1.Rows[i].Cells[j].FormattedValue.ToString());
                    }
                }
                pdfDoc.Add(table);
                Paragraph totalamount = new Paragraph("TOTAL AMOUNT: PKR" + total());
                totalamount.Alignment = Element.ALIGN_RIGHT;
                pdfDoc.Add(totalamount);
                pdfDoc.Close();
                pdfDoc.Dispose();

                string path = @"C:\Users\User\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\Debug"; // replace with your desired path
                string[] files = Directory.GetFiles(path, "*.pdf", SearchOption.TopDirectoryOnly);

                Array.Sort(files, (a, b) => File.GetCreationTime(b).CompareTo(File.GetCreationTime(a)));

                Process.Start(files[0]);

            }
            catch (Exception)
            { MessageBox.Show("AN ERROR OCCURED WHILE PRINTING BILL"); }
        }
        public void getdata()
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO orders ([order], quantity) SELECT product, quantity FROM Bill", conn);
            sql.ExecuteNonQuery();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt.Clear();
            adpt.Fill(dt);
        }

        public int Cost(int id)
        {

            int price = 0;
            try
      {
                string querry = "SELECT price FROM Bill WHERE id=@uid";
                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.AddWithValue("@uid", id);
                command.Connection = conn;
            conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string v = reader["price"].ToString();
                        price = int.Parse(v);
                    }
                }
                conn.Close();
                return price;
          }
           catch { MessageBox.Show("AN ERROR OCCURED WHILE COMMUNICATING WITH DATABASE\nPLEASE CONTACT WITH ADMIN.");
              return price;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (int.Parse(textBox2.Text) < 20 && int.Parse(textBox2.Text) > 0)
                {
                   
                    SqlCommand cmd = new SqlCommand("UPDATE Bill SET quantity=@number,total=@ttl WHERE id=@uid", conn);
                    int quantity = int.Parse(textBox2.Text);
                    int id = int.Parse(textBox1.Text);
                    int price = Cost(id);
                    int total = price * quantity;
                    cmd.Parameters.AddWithValue("@number", quantity);
                    cmd.Parameters.AddWithValue("@uid", id);
                    cmd.Parameters.AddWithValue("@ttl", total);
                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("UPDATED SUCCESSFULLY");
                    textBox1.Clear();
                    textBox2.Clear();
                    conn.Close();
                }

                else
                { MessageBox.Show("PLEASE CONTACT ADMIN DIRECTLY FOR BIGGER ORDERS");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER VALUES IN BOTH BOXES");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            if (!char.IsDigit(ch)&&ch!=8) { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch)&&ch!=8) { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int id = int.Parse(textBox3.Text);
                try
                {
                    conn.Open();
                    SqlCommand sql = new SqlCommand("DELETE FROM Bill WHERE id=@uid", conn);
                    sql.Parameters.AddWithValue("@uid", id);
                    sql.ExecuteNonQuery();
                    conn.Close();
                    textBox3.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("ID YOU ENTERED DOESNOT EXIST");
                    textBox3.Clear();
                }
            }
            else
            { MessageBox.Show("PLEASE FILL TEXTBOX"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                getdata();
                double x = total();
                print();
                delete();
        }
    }
}