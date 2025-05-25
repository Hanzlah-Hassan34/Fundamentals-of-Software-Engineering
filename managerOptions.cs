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
    public partial class managerOptions : Form
    {
        public managerOptions()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            insert_inventory var = new insert_inventory();
            var.Show();
            this.Hide();
        }

        private void updateinventory_Click(object sender, EventArgs e)
        {

        }
    }
}
