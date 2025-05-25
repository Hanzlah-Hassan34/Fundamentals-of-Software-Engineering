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

namespace PetApp
{
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void Tips_Load(object sender, EventArgs e)
        {
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sql_variable.Open();
                string select_query = "SELECT Tip_Name, Description, Pet_Type FROM Tips";

                SqlCommand instruction = new SqlCommand(select_query, sql_variable);
                SqlDataReader sql_file_reader = instruction.ExecuteReader();

                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "treatmentPanel",
                        Size = new Size(748, 200),
                        // BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackgroundImage = Image.FromFile("D:\\Documents\\Semester4\\Software Engineering\\Projects\\images\\back4.png"),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };



                    Label label1 = new Label()
                    {
                        Text = sql_file_reader["Tip_Name"].ToString() + ":",
                        Location = new Point(30, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };



                    TextBox textBox1 = new TextBox()
                    {
                        Text = sql_file_reader["Description"].ToString(),
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
                        Text = "For: ",
                        Location = new Point(30, 130),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };
                   

                    Label label2 = new Label()
                    {
                        Text = " " + sql_file_reader["Pet_Type"].ToString(),
                        Location = new Point(80, 130),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };
                    

                    sub_panel.Controls.Add(textBox1);
                    sub_panel.Controls.Add(label1);

                    sub_panel.Controls.Add(label2);
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
                string tip = search_tips.Text.Trim();
                string select_query = ""; 
                if (tip == "All Tips")
                {
                    select_query = "SELECT Tip_Name, Description, Pet_Type FROM Tips";
                }
                else
                {
                    select_query = "SELECT Tip_Name, Description, Pet_Type FROM Tips where Pet_Type = @pType";
                }

                SqlCommand instruction = new SqlCommand(select_query, sql_variable);

                if (tip != "All Tips")
                {
                    instruction.Parameters.AddWithValue("@pType", tip);
                }
                SqlDataReader sql_file_reader = instruction.ExecuteReader();
                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "treatmentPanel",
                        Size = new Size(748, 200),
                        // BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackgroundImage = Image.FromFile("D:\\Documents\\Semester4\\Software Engineering\\Projects\\images\\back4.png"),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };



                    Label label1 = new Label()
                    {
                        Text = sql_file_reader["Tip_Name"].ToString() + ":",
                        Location = new Point(30, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };



                    TextBox textBox1 = new TextBox()
                    {
                        Text = sql_file_reader["Description"].ToString(),
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
                        Text = "For: ",
                        Location = new Point(30, 130),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };


                    Label label2 = new Label()
                    {
                        Text = " " + sql_file_reader["Pet_Type"].ToString(),
                        Location = new Point(80, 130),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };


                    sub_panel.Controls.Add(textBox1);
                    sub_panel.Controls.Add(label1);

                    sub_panel.Controls.Add(label2);
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
