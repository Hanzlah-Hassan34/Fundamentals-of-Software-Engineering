using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetApp
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
            hide_sub_menu_initialy();
        }

        private void hide_sub_menu_initialy()
        { 
            adopt_a_pet_submenu_panel.Visible = false;
            pet_supplies_submenu_panel.Visible = false;
            pet_health_and_care_submenu_panel.Visible = false;
            
        }

        private void hide_subMenu()
        {
            if (adopt_a_pet_submenu_panel.Visible == true) 
                adopt_a_pet_submenu_panel.Visible = false;
            if (pet_supplies_submenu_panel.Visible == true)
                pet_supplies_submenu_panel.Visible = false;
            if (pet_health_and_care_submenu_panel.Visible == true)
                pet_health_and_care_submenu_panel.Visible = false;
            

        }

        private void show_subMenu(Panel p)
        {

            if (p.Visible == false)
            {
                hide_subMenu();
                p.Visible = true;
            }
            else {
                p.Visible = false;
            }
                
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adopt_a_pet_button_Click(object sender, EventArgs e)
        {
            show_subMenu(adopt_a_pet_submenu_panel);
        }

        private void pet_listing_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            pet_listing var1 = new pet_listing();
            var1.Show();
            this.Hide();
        }

        private void search_pet_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            search_pet var = new search_pet();  
            var.Show();
            this.Hide();    
        }

        private void pet_details_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            pet_detail var1 = new pet_detail(); 
            var1.Show();    
            this.Hide();
        }

        private void adoption_application_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            adoption_application var1 = new adoption_application();
            var1.Show();
            this.Hide();
        }

        private void pet_supplies_button_Click(object sender, EventArgs e)
        {
            show_subMenu(pet_supplies_submenu_panel);
        }

        private void browse_supplies_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            browse_products var = new browse_products();
            var.Show();
            this.Hide();
        }

        private void shopping_cart_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            cart var = new cart();
            var.Show();
            this.Hide();
        }

        private void treatment_recommendation_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            treatment var = new treatment();
            var.Show();
            this.Hide();
        }

        private void pet_care_tips_button_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            Tips var1 = new Tips();
            var1.Show();
            this.Hide();
        }

        private void pet_health_and_care_button_Click(object sender, EventArgs e)
        {
            show_subMenu(pet_health_and_care_submenu_panel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            applications_form var = new applications_form();
            var.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //managerAuthentication var = new managerAuthentication();
            //var.Show();
            if (Global_Variables.username == "fahid0088" || Global_Variables.username == "hanzlah0088" || Global_Variables.username == "awais0088")
            {
                managerOptions var = new managerOptions();
                var.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("You are not aythorized to this feature of app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hide_subMenu();
            managerAuthentication var = new managerAuthentication();
            var.Show();
        }

        private void updateInventory_Click(object sender, EventArgs e)
        {
            managerAuthentication var = new managerAuthentication();
            var.Show();
        }

        private void pet_supplies_submenu_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
