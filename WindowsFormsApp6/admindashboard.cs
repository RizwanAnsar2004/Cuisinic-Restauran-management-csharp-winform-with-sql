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
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
        }

        private void food_Click(object sender, EventArgs e)
        {
            workers1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration_page1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewfeedback1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewapplications1.BringToFront();
        }
    }
}
