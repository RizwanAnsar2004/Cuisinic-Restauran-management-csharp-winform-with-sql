using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void staff_Click(object sender, EventArgs e)
        {
            LOGIN fm = new LOGIN();
            fm.Show();
            
        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminlogin fm = new adminlogin();
            fm.Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            dashboard fm = new dashboard();
            fm.Show();
        }
    }
}
