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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void front1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback1.BringToFront();
        }

        private void food_Click(object sender, EventArgs e)
        {
            food11.BringToFront();
        }

        private void drink_Click(object sender, EventArgs e)
        {
            drink11.BringToFront();
        }

        private void cart_Click(object sender, EventArgs e)
        {
            cartt1.BringToFront();

        }
    }
}
