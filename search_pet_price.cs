using System;
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
    public partial class search_pet_price : Form
    {
        public search_pet_price()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
            var.Show();
            this.Close();
        }

        private void Adopt_Button_Click(object sender, EventArgs e)
        {
            adoption_application var = new adoption_application();
            var.Show();
            this.Hide();
        }
        private void search_type_Button_Click(object sender, EventArgs e)
        {
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                flowLayoutPanel1.Controls.Clear();
                sql_variable.Open();
                string pet_type = search_type.Text.Trim();
                string select_query = "SELECT owner_name, pet_type, pet_name, pet_age, contact_number, price, pet_image, pet_description, gender, pet_status, pet_id FROM pet_detail WHERE price < @PetType";
                SqlCommand instruction = new SqlCommand(select_query, sql_variable);
                float.TryParse(pet_type, out float num);

                instruction.Parameters.AddWithValue("@PetType", num);

                //instruction.Parameters.AddWithValue("@PetType", pet_type.toInt32());
                SqlDataReader sql_file_reader = instruction.ExecuteReader();
                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "petPanel",
                        Size = new Size(748, 270),
                        BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new Point(25, 25);


                    if (!sql_file_reader.IsDBNull(6))  // Check if image is not null
                    {
                        byte[] binary_file = (byte[])sql_file_reader["pet_image"];
                        MemoryStream var = new MemoryStream(binary_file);
                        pictureBox.Image = Image.FromStream(var);
                    }

                    Button adopt_Button = new Button()
                    {
                        Name = "adoptButton",
                        Location = new Point(500, 190),
                        Size = new Size(150, 45),
                        Font = new Font("Tahoma", 12, FontStyle.Bold),
                        BackColor = Color.FromArgb(57, 24, 9),
                        ForeColor = Color.White,
                    };

                    if (Convert.ToInt32(sql_file_reader["pet_status"]) == 0)
                    {
                        adopt_Button.Text = "Adopt";
                        adopt_Button.Click += Adopt_Button_Click;
                    }
                    else
                    {
                        adopt_Button.ForeColor = Color.White;
                        adopt_Button.Text = "Adopted";
                        adopt_Button.Enabled = false;
                    }


                    Label label1 = new Label()
                    {
                        Text = "Name: ",
                        Location = new Point(260, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };
                    Label label2 = new Label()
                    {
                        Text = sql_file_reader["pet_name"].ToString(),
                        Location = new Point(340, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label3 = new Label()
                    {
                        Text = "Type: ",
                        Location = new Point(260, 60),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label4 = new Label()
                    {
                        Text = sql_file_reader["pet_type"].ToString(),
                        Location = new Point(340, 60),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label5 = new Label()
                    {
                        Text = "Contact: ",
                        Location = new Point(260, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label6 = new Label()
                    {
                        Text = sql_file_reader["contact_number"].ToString(),
                        Location = new Point(340, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };
                    Label label7 = new Label()
                    {
                        Text = "Price: ",
                        Location = new Point(480, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label8 = new Label()
                    {
                        Text = "$ " + sql_file_reader["price"].ToString(),
                        Location = new Point(560, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label9 = new Label()
                    {
                        Text = "Age: ",
                        Location = new Point(480, 60),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label10 = new Label()
                    {
                        Text = sql_file_reader["pet_age"].ToString(),
                        Location = new Point(560, 60),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label11 = new Label()
                    {
                        Text = "Gender: ",
                        Location = new Point(480, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label12 = new Label()
                    {
                        Text = sql_file_reader["gender"].ToString(),
                        Location = new Point(560, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label13 = new Label()
                    {
                        Text = "Description: ",
                        Location = new Point(260, 120),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label14 = new Label()
                    {
                        Text = sql_file_reader["pet_description"].ToString(),
                        Location = new Point(260, 150),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };
                    Label label15 = new Label()
                    {
                        Text = "Pet ID: ",
                        Location = new Point(260, 180),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label16 = new Label()
                    {
                        Text = sql_file_reader["pet_id"].ToString(),
                        Location = new Point(340, 180),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };
                    sub_panel.Controls.Add(pictureBox);
                    sub_panel.Controls.Add(label1);
                    sub_panel.Controls.Add(label2);
                    sub_panel.Controls.Add(label3);
                    sub_panel.Controls.Add(label4);
                    sub_panel.Controls.Add(label5);
                    sub_panel.Controls.Add(label6);
                    sub_panel.Controls.Add(label7);
                    sub_panel.Controls.Add(label8);
                    sub_panel.Controls.Add(label9);
                    sub_panel.Controls.Add(label10);
                    sub_panel.Controls.Add(label11);
                    sub_panel.Controls.Add(label12);
                    sub_panel.Controls.Add(label13);
                    sub_panel.Controls.Add(label14);
                    sub_panel.Controls.Add(label15);
                    sub_panel.Controls.Add(label16);
                    sub_panel.Controls.Add(adopt_Button);

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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
