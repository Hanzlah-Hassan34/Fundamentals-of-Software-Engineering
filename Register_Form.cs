using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    
    public partial class Register_Form : Form
    {
        private bool IsStrongPassword(string password)
        {
            if (password.Length < 8)
                return false; 

            bool check1 = false, check2 = false, check3 = false, check4 = false;
            string specialString = "@$!%*?&";

            foreach (char a in password)
            {
                if (char.IsLower(a))
                {
                    check1 = true;
                }
                else if (char.IsUpper(a))
                {
                    check2 = true;
                }
                else if (char.IsDigit(a))
                {
                    check3 = true;
                }
                else if (specialString.Contains(a)) 
                {
                    check4 = true;
                }

                
            }
            if (check1 && check2 && check3 && check4)
            {
                return true;
            }

            return false; 
        }

        private bool IsValidEmail(string email)
        {
            int a = email.IndexOf('@');
            int b = email.LastIndexOf('.');

            return a > 0 && b > (a + 1) && b < email.Length - 1;
        }
        private void SaveData(string username, string password, string name, string email)
        {
           

            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");
            using (sql_variable) 
            {
                sql_variable.Open();
                string insert_query = "INSERT INTO Users (Username, Password, Name, Email) VALUES (@Username, @Password, @Name, @Email)";
                SqlCommand instruction = new SqlCommand(insert_query, sql_variable);
                using (instruction)
                {
                    instruction.Parameters.AddWithValue("@Username", username);
                    instruction.Parameters.AddWithValue("@Password", password);
                    instruction.Parameters.AddWithValue("@Name", name);
                    instruction.Parameters.AddWithValue("@Email", email);

                    instruction.ExecuteNonQuery();
                }
            }
        }
        public Register_Form()
        {
            InitializeComponent();
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void register_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Login_button_Click(object sender, EventArgs e)
        {
            Login_Form var1 = new Login_Form();
            var1.Show();
            this.Hide();
        }

        private void Show_Password_register_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Password_register.Checked)
            {
                Password_Register.PasswordChar = '\0';
            }
            else {
                Password_Register.PasswordChar = '*';
            }

        }

        private void show_confirm_Password_register_CheckedChanged(object sender, EventArgs e)
        {
            if (show_confirm_Password_register.Checked)
            {
                Confirm_Password_Register.PasswordChar = '\0';
            }
            else
            {
                Confirm_Password_Register.PasswordChar = '*';
            }
        }

        
        private void register_Button_Click(object sender, EventArgs e)
        {
            string name = FullName_Register.Text;
            string username = UserName_Register.Text;
            string email = email_Register.Text;
            string password = Password_Register.Text;
            string confirm_password = Confirm_Password_Register.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirm_password))
            {
                MessageBox.Show("No feild can be empty or space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (name.All(Char.IsLetter) == false) {
                    MessageBox.Show("Name should contain only alphabets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (password != confirm_password)
                {
                    MessageBox.Show("Password and Confirm Password fields should have same value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email should must contain @ and .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!IsStrongPassword(password))
                {
                    MessageBox.Show("Password should be strong and contain more than or equal to 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Global_Variables.username = username;
                    SaveData(username, password, name, email);
                    MessageBox.Show("Registration successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home_Page var1 = new Home_Page();
                    var1.Show();
                    this.Hide();
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
