using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetApp
{
    public partial class bankPayment : Form
    {
        public bankPayment()
        {
            InitializeComponent();
        }

        private void income_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        public static bool IsValidAccountNumber(string num)
        {
           
            if (num.Length != 13)
                return false;

           
            foreach (char c in num)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        private void bankPayment_Load(object sender, EventArgs e)
        {
            amount.Text = Global_Variables.totalAmount.ToString();
        }

        private void submit_button_application_Click(object sender, EventArgs e)
        {
            string Number = accountNumber.Text.ToString();
            string b = bank.Text.ToString();
            if (IsValidAccountNumber(Number)) {
                success var = new success();
                var.Show();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(b) || string.IsNullOrWhiteSpace(Number))
            {
                MessageBox.Show("No field should be empty or space. ");
            }
            else
            {
                MessageBox.Show("Please Enter Correct Account Number (It should be 13 character long and all should be digits) ");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
