using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class paymentMethod : Form
    {
        public paymentMethod()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Global_Variables.totalAmount > 0)
            {
                bankPayment var = new bankPayment();
                var.Show();
                this.Hide();
            }
             
            else {
                MessageBox.Show("Your cart is empty. Add something in cart.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            easypassa var = new easypassa();
            var.Show();
            this.Hide();
        }
    }
}
