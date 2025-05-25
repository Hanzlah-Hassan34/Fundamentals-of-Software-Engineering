using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // To use File.ReadAllBytes

namespace PetApp
{
    public partial class insert_inventory : Form
    {
        public insert_inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog var = new OpenFileDialog();
            var.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (var.ShowDialog() == DialogResult.OK)
            {
                product_image.Image = Image.FromFile(var.FileName);
                product_image_path.Text = var.FileName; // Store the image path
            }
        }

        private void add_button_product_Click(object sender, EventArgs e)
        {
            string name = product_name.Text;
            string Type = product_pet_type.Text;
            string prices = price.Text;
            string quantitys = quantity.Text;
            string Description = description.Text;
            string image_path = product_image_path.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(Type) || string.IsNullOrWhiteSpace(quantitys) || string.IsNullOrWhiteSpace(prices) ||  string.IsNullOrWhiteSpace(image_path))
            {
                MessageBox.Show("No feild can be empty or space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (float.TryParse(prices, out float num2) && (num2 <= 0))
                {
                    MessageBox.Show("Price must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (int.TryParse(quantitys, out int num1) && (num1 < 0))
                {
                    MessageBox.Show("Quantity must be a non negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    using (sql_variable) 
                    {
                        sql_variable.Open();
                        string insert_query = "INSERT INTO petproduct (product_name, description, pet_type, price, quantity, product_image) VALUES (@A, @B, @C, @D, @E, @F)";
                        SqlCommand instruction = new SqlCommand(insert_query, sql_variable);

                        byte[] binary_file = File.ReadAllBytes(image_path);
                        instruction.Parameters.AddWithValue("@A", name);
                        instruction.Parameters.AddWithValue("@C", Type);
                        instruction.Parameters.AddWithValue("@B", Description);
                        instruction.Parameters.AddWithValue("@D", num2);
                        instruction.Parameters.AddWithValue("@E", num1);
                        
                        instruction.Parameters.AddWithValue("@F", binary_file);

                        int no_of_rows_affected_by_querry = instruction.ExecuteNonQuery();

                        if (no_of_rows_affected_by_querry > 0)
                        {
                            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
    
}
