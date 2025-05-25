using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PetApp
{
    public partial class applications_form : Form
    {
        public applications_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void applications_form_Load(object sender, EventArgs e)
        {
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sql_variable.Open();
                string select_query = "select ad.AName as adopter_name, ad.Age as adopter_age, ad.Phone_Number as adopter_number,ad.Email_Address as adopter_email, ad.City as adopter_city, ad.Town as adopter_town, ad.Street_no as adopter_street, ad.House_no as adopter_house, ad.number_of_children as adopter_children,ad.has_other_pets as adopter_pets, ad.home_type as adopter_homeType,ad.home_status as adopter_homeStatus, ad.reason_for_adoption as adopter_reason,ad.income as adopter_income, a.Application_ID as AID,a.application_date as aDate,a.application_status as Status,p.pet_name as PetName, p.pet_id as PID from application_form as a join pet_detail as p on a.pet_id = p.pet_id join adopter as ad on a.AName = ad.AName;";
                SqlCommand instruction = new SqlCommand(select_query, sql_variable);
                SqlDataReader sql_file_reader = instruction.ExecuteReader();

                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "petPanel",
                        Size = new Size(748, 250),
                        BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle
                    };

  


                   
                    Button accept_Button = new Button()
                    {
                        Name = "acceptButton",
                        Location = new Point(570, 185),
                        Size = new Size(150, 45),
                        Font = new Font("Tahoma", 12, FontStyle.Bold),
                        BackColor = Color.FromArgb(57, 24, 9),
                        ForeColor = Color.White,
                    };
                    int application_number = Convert.ToInt32(sql_file_reader["AID"]);
                    int pet_number = Convert.ToInt32(sql_file_reader["PID"]);
                    accept_Button.Tag = new Tuple<int, int>(application_number, pet_number);
                    // tag 1 object ke property ha

                    if (Convert.ToInt32(sql_file_reader["Status"]) == 0)
                    {
                        accept_Button.Text = "Accept";
                        accept_Button.Click += Accept_Button_Click;
                        // accept button click ho ga to Accept_Button_Click function call ho ga


                    }
                    else
                    {
                        accept_Button.Text = "Accepted";
                        accept_Button.Enabled = false;
                    }
                    string str = sql_file_reader["adopter_name"].ToString() + ", a " + sql_file_reader["adopter_age"].ToString() + " - year - old resident of Springfield, has submitted an adoption application for a pet. He currently lives in a " + sql_file_reader["adopter_homeType"].ToString() + " that he " + sql_file_reader["adopter_homeStatus"].ToString() + " and resides at Street No. " + sql_file_reader["adopter_street"].ToString() + ", House No. " + sql_file_reader["adopter_house"].ToString() + ", in " + sql_file_reader["adopter_city"].ToString() + "'s " + sql_file_reader["adopter_town"].ToString() + " area. " + sql_file_reader["adopter_name"].ToString() + " has " + sql_file_reader["adopter_children"].ToString() + " children. The reason of adoption for " + sql_file_reader["adopter_name"].ToString() + " is \"" + sql_file_reader["adopter_reason"].ToString() + "\". His monthly income is $" + sql_file_reader["adopter_income"].ToString() + ", ensuring financial stability to care for the pet. His contact details include Phone: " + sql_file_reader["adopter_number"].ToString() + " and Email: " + sql_file_reader["adopter_email"].ToString() + ".His application, submitted on " + sql_file_reader["aDate"].ToString() + ", is currently under review.If approved, he will be adopting " + sql_file_reader["PetName"].ToString() + ", with Pet ID " + sql_file_reader["PID"].ToString() + ".";


                    
                    TextBox textBox1 = new TextBox()
                    {
                        Text = str,
                        Location = new Point(30, 30),
                        Size = new Size(500, 200),  
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Multiline = true,  
                        ReadOnly = true,   
                        WordWrap = true,   
                        ScrollBars = ScrollBars.Vertical,  
                        BackColor = Color.FromArgb(183, 149, 111),  
                        BorderStyle = BorderStyle.None
                    };
                    textBox1.TabStop = false;


                    sub_panel.Controls.Add(textBox1);
                    
                    sub_panel.Controls.Add(accept_Button);

                    flowLayoutPanel1.Controls.Add(sub_panel);

                }

                sql_file_reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sql_variable.Close();
            }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            Button Button_clicked = (Button) sender; // type cast (button) parameter ko type cast kr rha ha

            Tuple<int, int> required_data = (Tuple<int, int>)Button_clicked.Tag;
            int application_Id = required_data.Item1;
            int pet_Id = required_data.Item2;

            
            SqlConnection sqlVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sqlVar.Open();
                string upadte_query = "update application_form set application_status = 1 where Application_ID = @ApplicationId";
                SqlCommand instruction = new SqlCommand(upadte_query, sqlVar);
                instruction.Parameters.AddWithValue("@ApplicationId", application_Id);
                instruction.ExecuteNonQuery(); // ya is lia kuon ka ya querry koi data return ni krti

                string updateQuery2 = "update pet_detail set pet_status = 1 where pet_id = @PetId";

                SqlCommand instruction2 = new SqlCommand(updateQuery2, sqlVar);
                instruction2.Parameters.AddWithValue("@PetId", pet_Id);
                instruction2.ExecuteNonQuery();

                Button_clicked.Text = "Accepted";
                Button_clicked.Enabled = false;

                MessageBox.Show("Application accepted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlVar.Close();
            }
        }
    }
}
