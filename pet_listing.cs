using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO; // To use File.ReadAllBytes
namespace PetApp
{
    public partial class pet_listing : Form
    {
        SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");
        public pet_listing()
        {
            InitializeComponent();
        }

        private void pet_listing_Load(object sender, EventArgs e)
        {

        }
        
        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_button_listing_Click_1(object sender, EventArgs e)
        {
            string name = owner_name.Text;
            string Type = pet_type.Text;
            string pName = pet_name.Text;
            string age = pet_age.Text;
            string Number = owner_contact_number.Text;
            string price = adoption_price.Text;
            string Gender = gender.Text;
            string Description = description.Text;
            string image_path = pet_image_path.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(Type) || string.IsNullOrWhiteSpace(pName) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(Number) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(Gender) || string.IsNullOrWhiteSpace(image_path))
            {
                MessageBox.Show("No feild can be empty or space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(age, out int num) && (num <= 0 || num > 50))
                {
                    MessageBox.Show("Age must be greater than 0 and less than 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(price, out float num2) && (num2 <= 0))
                {
                    MessageBox.Show("Price must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (long.TryParse(Number, out long num3) && (num3 <= 1000 || num3 > 999999))
                {
                    MessageBox.Show("Number must be greater than or equal to 1000 and less than 999999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    using (sql_variable) // USING is used to not wrote line sql_variable.Dispose()
                    {
                        sql_variable.Open();
                        string insert_query = "INSERT INTO pet_detail (owner_name, pet_type, pet_name, pet_age, contact_number, price, gender, pet_description, pet_image) VALUES (@owner, @type, @pname, @age, @number, @price, @gender, @description, @image)";
                        SqlCommand instruction = new SqlCommand(insert_query, sql_variable);

                        byte[] binary_file = File.ReadAllBytes(image_path);
                        instruction.Parameters.AddWithValue("@owner", name);
                        instruction.Parameters.AddWithValue("@type", Type);
                        instruction.Parameters.AddWithValue("@pname", pName);
                        instruction.Parameters.AddWithValue("@age", num);
                        instruction.Parameters.AddWithValue("@number", num3);
                        instruction.Parameters.AddWithValue("@price", num2);
                        instruction.Parameters.AddWithValue("@gender", Gender);
                        instruction.Parameters.AddWithValue("@description", Description);
                        instruction.Parameters.AddWithValue("@image", binary_file);

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

        private void pet_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void owner_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog var = new OpenFileDialog();
            var.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (var.ShowDialog() == DialogResult.OK)
            {
                pet_image.Image = Image.FromFile(var.FileName);
                pet_image_path.Text = var.FileName; // Store the image path
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
