using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; // For using File.exist function (Reading a file)

namespace PetApp
{
    public partial class Login_Form : Form
    {
        private bool UserValidation(string username, string password)
        {
            //if (!File.Exists("D:\\Documents\\Semester4\\Software Engineering\\Projects\\Data_files\\User_file.csv"))
            //{
            //    return false;
            //}

            //foreach (string row in File.ReadAllLines("D:\\Documents\\Semester4\\Software Engineering\\Projects\\Data_files\\User_file.csv"))
            //{
            //    string[] arr = row.Split(',');
            //    if (arr[0] == username && arr[1] == password)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");
            using (sql_variable)
            {
                sql_variable.Open();
                string check_query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand instruction = new SqlCommand(check_query, sql_variable);
                using (instruction)
                {
                    instruction.Parameters.AddWithValue("@Username", username);
                    instruction.Parameters.AddWithValue("@Password", password);

                    int count = (int)instruction.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            Register_Form var1 = new Register_Form();
            var1.Show();
            this.Hide();
        }

        private void userName_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Show_Password_Login_CheckedChanged(object sender, EventArgs e)
        {
            Password_Login.PasswordChar = Show_Password_Login.Checked ? '\0' : '*';

            if (Show_Password_Login.Checked)
            {
                Password_Login.PasswordChar = '\0';
            }
            else
            {
                Password_Login.PasswordChar = '*';
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string username = userName_Login.Text;
            string password = Password_Login.Text;

            if (!UserValidation(username, password))
            {
                MessageBox.Show("Your account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global_Variables.username = username;
                Home_Page var1 = new Home_Page();
                var1.Show();
                this.Hide();
            }
        }
    }
}
