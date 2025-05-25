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
    public partial class managerAuthentication : Form
    {
        public managerAuthentication()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void okButton_Click(object sender, EventArgs e)
        {
            string username = managerID.Text.ToString();
            if (username == "fahid0088" || username == "hanzlah0088" || username == "awais0088")
            {
                managerOptions var = new managerOptions();
                var.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("You are not aythorized to this feature of app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
