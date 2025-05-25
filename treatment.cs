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
using System.Xml.Linq;

namespace PetApp
{
    public partial class treatment : Form
    {
        public treatment()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void treatment_Load(object sender, EventArgs e)
        {
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

                try
                {
                    sql_variable.Open();
                    string select_query = "SELECT D_name, D_description, Solution1, Solution2, Solution3, Solution4 FROM Disease";
                
                    SqlCommand instruction = new SqlCommand(select_query, sql_variable);
                    SqlDataReader sql_file_reader = instruction.ExecuteReader();

                    while (sql_file_reader.Read())
                    {

                        Panel sub_panel = new Panel()
                        {
                            Name = "treatmentPanel",
                            Size = new Size(748, 350),
                            // BackColor = Color.FromArgb(183, 149, 111),
                            BorderStyle = BorderStyle.FixedSingle,
                            BackgroundImage = Image.FromFile("D:\\Documents\\Semester4\\Software Engineering\\Projects\\images\\back4.png"), 
                            BackgroundImageLayout = ImageLayout.Stretch
                        };

                    

                        Label label1 = new Label()
                        {
                            Text =   sql_file_reader["D_name"].ToString() + ":",
                            Location = new Point(30, 30),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            Padding = new Padding(5),
                            BackColor = Color.Transparent
                        };

                       

                        TextBox textBox1 = new TextBox()
                        {
                            Text = sql_file_reader["D_description"].ToString(),
                            Location = new Point(30, 60),
                            Size = new Size(700, 60),
                            Font = new Font("Arial", 12, FontStyle.Regular),
                            Multiline = true,
                            ReadOnly = true,
                            WordWrap = true,
                            ScrollBars = ScrollBars.Vertical,
                            //BackColor = Color.Transparent,

                            BackColor = Color.FromArgb(251, 217, 174),
                            BorderStyle = BorderStyle.None
                        };
                        textBox1.TabStop = false;

                        Label label10 = new Label()
                        {
                            Text = "Solutions: ",
                            Location = new Point(30, 150),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            Padding = new Padding(5),
                            BackColor = Color.Transparent
                        };
                        Label label2 = new Label()
                        {
                            Text = "1: ",
                            Location = new Point(30, 180),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            Padding = new Padding(5),
                            BackColor = Color.Transparent
                        };

                        Label label3 = new Label()
                        {
                            Text = " " + sql_file_reader["Solution1"].ToString(),
                            Location = new Point(60, 180),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Regular),
                            Padding = new Padding(5),
                            BackColor = Color.Transparent
                        };
                    Label label4 = new Label()
                    {
                        Text = "2: ",
                        Location = new Point(30, 210),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label5 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution2"].ToString(),
                        Location = new Point(60, 210),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label6 = new Label()
                    {
                        Text = "3: ",
                        Location = new Point(30, 240),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label7 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution3"].ToString(),
                        Location = new Point(60, 240),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label8 = new Label()
                    {
                        Text = "4: ",
                        Location = new Point(30, 270),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label9 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution4"].ToString(),
                        Location = new Point(60, 270),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    sub_panel.Controls.Add(textBox1);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page var = new Home_Page();
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
                string disease = search_disease.Text.Trim();
                string select_query = "";
                if (disease == "All")
                {
                    select_query = "SELECT D_name, D_description, Solution1, Solution2, Solution3, Solution4 FROM Disease";
                }
                else {
                    select_query = "SELECT D_name, D_description, Solution1, Solution2, Solution3, Solution4 FROM Disease where D_name = @dType";
                }
                
                SqlCommand instruction = new SqlCommand(select_query, sql_variable);

                if (disease != "All")
                {
                    instruction.Parameters.AddWithValue("@dType", disease);
                }
                SqlDataReader sql_file_reader = instruction.ExecuteReader();

                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "treatmentPanel",
                        Size = new Size(748, 350),
                        // BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackgroundImage = Image.FromFile("D:\\Documents\\Semester4\\Software Engineering\\Projects\\images\\back4.png"),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };



                    Label label1 = new Label()
                    {
                        Text = sql_file_reader["D_name"].ToString() + ":",
                        Location = new Point(30, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };



                    TextBox textBox1 = new TextBox()
                    {
                        Text = sql_file_reader["D_description"].ToString(),
                        Location = new Point(30, 60),
                        Size = new Size(700, 60),
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Multiline = true,
                        ReadOnly = true,
                        WordWrap = true,
                        ScrollBars = ScrollBars.Vertical,
                        //BackColor = Color.Transparent,

                        BackColor = Color.FromArgb(251, 217, 174),
                        BorderStyle = BorderStyle.None
                    };
                    textBox1.TabStop = false;

                    Label label10 = new Label()
                    {
                        Text = "Solutions: ",
                        Location = new Point(30, 150),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };
                    Label label2 = new Label()
                    {
                        Text = "1: ",
                        Location = new Point(30, 180),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label3 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution1"].ToString(),
                        Location = new Point(60, 180),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };
                    Label label4 = new Label()
                    {
                        Text = "2: ",
                        Location = new Point(30, 210),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label5 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution2"].ToString(),
                        Location = new Point(60, 210),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label6 = new Label()
                    {
                        Text = "3: ",
                        Location = new Point(30, 240),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label7 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution3"].ToString(),
                        Location = new Point(60, 240),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label8 = new Label()
                    {
                        Text = "4: ",
                        Location = new Point(30, 270),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label9 = new Label()
                    {
                        Text = " " + sql_file_reader["Solution4"].ToString(),
                        Location = new Point(60, 270),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    sub_panel.Controls.Add(textBox1);
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
    }
}
