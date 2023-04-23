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
    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string filePath = @"C:\Users\User\source\repos\WindowsFormsApp6\WindowsFormsApp6\feedback\" + Path.GetRandomFileName() + ".txt";
                string text = richTextBox1.Text;
                try
                {
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Dispose();
                    }
                    File.WriteAllText(filePath, text);
                    MessageBox.Show("YOUR FEEDBACK HAVE BEEN SUBMITTED SUCCESSFULLY \n YOUR FEEDBACK WOULD BE APPRECIATED");
                    richTextBox1.Clear();
                }
                catch 
                { MessageBox.Show("ERROR OCCURED WHILE SUBMITTING FEEDBACK"); }
            }
            else 
            { MessageBox.Show("PLEASE ENTER FEEDBACK\nEMPTY TEXT BOX CANNOT BE SUBMITTED"); }
        }

    }
}
