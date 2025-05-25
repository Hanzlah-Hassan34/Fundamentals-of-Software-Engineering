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
    public partial class search_pet : Form
    {
        public search_pet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Search_pet_type var = new Search_pet_type();
            var.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Home_label_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            search_pet_age var = new search_pet_age();
            var.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            search_pet_price var = new search_pet_price();
            var.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            search_pet_gender var = new search_pet_gender();
            var.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_pet_age var = new search_pet_age();
            var.Show();
            this.Close();
        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            Search_pet_type var = new Search_pet_type();
            var.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_pet_price var = new search_pet_price();
            var.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_pet_gender var = new search_pet_gender();
            var.Show();
            this.Close();
        }
    }
}
