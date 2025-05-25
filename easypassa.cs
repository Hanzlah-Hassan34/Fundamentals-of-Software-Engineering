using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PetApp
{
    public partial class easypassa : Form
    {
        public easypassa()
        {
            InitializeComponent();
        }

        private void easypassa_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            amount.Text = Global_Variables.totalAmount.ToString();
        }
        public static bool IsValidPhoneNumber(string num)
        {

            if (num.Length != 11)
                return false;


            foreach (char c in num)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_button_application_Click(object sender, EventArgs e)
        {
            string Number = phoneNumber.Text.ToString();
            
            if (IsValidPhoneNumber(Number))
            {
                success var = new success();
                var.Show();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(Number))
            {
                MessageBox.Show("No field should be empty or space. ");
            }
            else
            {
                MessageBox.Show("Please Enter Correct Phone Number (It should be 11 character long and all should be digits) ");
            }
        }
    }
}
