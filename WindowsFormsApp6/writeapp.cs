using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class writeapp : UserControl
    {
        public writeapp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string filePath = @"C:\Users\User\source\repos\WindowsFormsApp6\WindowsFormsApp6\applications\" + Path.GetRandomFileName() + ".txt";
                string text = richTextBox1.Text;
                try
                {
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Dispose();
                    }
                    File.WriteAllText(filePath, text);
                    MessageBox.Show("YOUR APPLICATION HAS BEEN SUBMITTED SUCCESSFULLY");
                    richTextBox1.Clear();
                }
                catch
                { MessageBox.Show("ERROR OCCURED WHILE SUBMITTING APPLICATION"); }
            }
            else
            { MessageBox.Show("PLEASE WRITE APPLICATION\nEMPTY TEXT BOX CANNOT BE SUBMITTED"); }
        }
    }
}

