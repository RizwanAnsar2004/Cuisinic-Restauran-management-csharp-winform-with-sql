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
    public partial class viewapplications : UserControl
    {
        public viewapplications()
        {
            InitializeComponent();
            string folderPath = @"C:\Users\User\source\repos\WindowsFormsApp6\WindowsFormsApp6\applications\";
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                comboBox2.Items.Add(Path.GetFileName(file));
            }
        }

        public void readdata(string name)
        {
            string filePath = @"C:\Users\User\source\repos\WindowsFormsApp6\WindowsFormsApp6\applications\" + name;
            try
            {
                string fileContents = File.ReadAllText(filePath);
                richTextBox1.Text = fileContents;
            }
            catch
            { MessageBox.Show("AN ERROR OCCURED WHILE OPENING FILE"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string name = comboBox2.Text;
                readdata(name);
            }
            else { MessageBox.Show("PLEASE SELECT ANY NAME FROM DROP DOWN LIST"); }
        }
    }
}
