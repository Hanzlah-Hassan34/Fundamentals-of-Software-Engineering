using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetApp
{
    public partial class adoption_application : Form
    {
        public adoption_application()
        {
            InitializeComponent();
        }

        private void submit_button_application_Click(object sender, EventArgs e)
        {
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");


            string Name = adopter_name.Text;
            string Age = adopter_age.Text;
            string Number = adopter_number.Text;
            string Email = adopter_email.Text;
            string City= adopter_city.Text;
            string Town = adopter_town.Text;
            string Street = adopter_street_number.Text;
            string House = adopter_house_number.Text;
            string Children = number_of_children.Text;
            string other_pet = other_pets.Text;
            string Home_type = home_type.Text;
            string Home_status = home_status.Text;
            string Income = income.Text;
            string Reason = reason_for_adoption.Text;
            string Pet_ID = adopter_pet_id.Text;

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Age) || string.IsNullOrWhiteSpace(Number)  || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Town) || string.IsNullOrWhiteSpace(Street) || string.IsNullOrWhiteSpace(House) || string.IsNullOrWhiteSpace(Children) || string.IsNullOrWhiteSpace(other_pet) || string.IsNullOrWhiteSpace(Home_type) || string.IsNullOrWhiteSpace(Home_status) || string.IsNullOrWhiteSpace(Income) || string.IsNullOrWhiteSpace(Reason) || string.IsNullOrWhiteSpace(Pet_ID))
            {
                MessageBox.Show("No feild can be empty or space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(Age, out int num) && (num <= 0 || num > 99))
                {
                    MessageBox.Show("Age must be greater than 0 and less than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(Street, out int num1) && (num1 <= 0))
                {
                    MessageBox.Show("Street number must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(House, out int num2) && (num2 <= 0))
                {
                    MessageBox.Show("House number must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(Children, out int num3) && (num3 < 0 || num3 > 5))
                {
                    MessageBox.Show("Number 0f Children must be greater than or equal to 0 and less than 6.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(Income, out float num4) && (num4 <= 0))
                {
                    MessageBox.Show("Income must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(Pet_ID, out int num5) && (num5 < 0))
                {
                    MessageBox.Show("Pet ID must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {

                    using (sql_variable) // USING is used to not wrote line sql_variable.Dispose()
                    {
                        sql_variable.Open();
                        string check_Query = "select pet_status from pet_detail where pet_id = @Id";
                        SqlCommand instruction1 = new SqlCommand(check_Query, sql_variable);
                        
                        instruction1.Parameters.AddWithValue("@Id", num5);

                        object check = instruction1.ExecuteScalar(); // Ya sirf 1 record return krta ha

                        
                        if (check == null)
                        {
                            MessageBox.Show("Pet with ID " + Pet_ID + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int petStatus = Convert.ToInt32(check);
                        if (petStatus == 1)
                        {
                            MessageBox.Show("Sorry, this pet has already been adopted.", "Pet Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                        string check_Query2 = "select AName from adopter where AName = @adopter";
                        SqlCommand instruction2 = new SqlCommand(check_Query2, sql_variable);
                        instruction2.Parameters.AddWithValue("@adopter", Name);

                        object check2 = instruction2.ExecuteScalar(); 


                        if (check2 == null)
                        {
                            string insert_query = "INSERT INTO adopter (AName, Age, Phone_Number, Email_Address, City, Town, Street_no, House_no, number_of_children, has_other_pets, home_type, home_status, reason_for_adoption, income ) VALUES (@AName, @Age, @Phone_Number, @Email_Address, @City, @Town, @Street_no, @House_no, @number_of_children, @has_other_pets, @home_type, @home_status, @reason_for_adoption, @income )";
                            SqlCommand instruction = new SqlCommand(insert_query, sql_variable);

                            instruction.Parameters.AddWithValue("@AName", Name);
                            instruction.Parameters.AddWithValue("@Age", num);
                            instruction.Parameters.AddWithValue("@Phone_Number", Number);
                            instruction.Parameters.AddWithValue("@Email_Address", Email);
                            instruction.Parameters.AddWithValue("@City", City);
                            instruction.Parameters.AddWithValue("@Town", Town);
                            instruction.Parameters.AddWithValue("@Street_no", num1);
                            instruction.Parameters.AddWithValue("@House_no", num2);
                            instruction.Parameters.AddWithValue("@number_of_children", num3);
                            instruction.Parameters.AddWithValue("@home_type", Home_type);
                            instruction.Parameters.AddWithValue("@home_status", Home_status);
                            instruction.Parameters.AddWithValue("@reason_for_adoption", Reason);
                            instruction.Parameters.AddWithValue("@income", num4);
                            if (other_pet == "No")
                                instruction.Parameters.AddWithValue("@has_other_pets", 0);
                            else
                                instruction.Parameters.AddWithValue("@has_other_pets", 1);
                            instruction.ExecuteNonQuery();
                        }

                        
           


                        




                        string insert_query3 = "INSERT INTO application_form ( AName ,pet_id  ) VALUES ( @AName2 ,@pet_id2 )";
                        SqlCommand instruction3 = new SqlCommand(insert_query3, sql_variable);
                        instruction3.Parameters.AddWithValue("@AName2", Name);
                        instruction3.Parameters.AddWithValue("@pet_id2", num5);
                        

                       
                        int no_of_rows_affected_by_querry = instruction3.ExecuteNonQuery();

                        if ( no_of_rows_affected_by_querry > 0)
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

        private void adopter_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
