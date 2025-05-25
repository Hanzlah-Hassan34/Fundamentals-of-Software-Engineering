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
    public partial class browse_products : Form
    {
        public browse_products()
        {
            InitializeComponent();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void insert_panels( bool check)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection sql_variable = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");
            string select_query = "";
            if (check) {
                select_query = "select product_id ,product_name ,description ,pet_type ,price ,quantity ,product_image from petproduct;";
            }
            else
            {
                select_query = "select product_id ,product_name ,description ,pet_type ,price ,quantity ,product_image from petproduct where pet_type = @type;";

            }


            try
            {
                sql_variable.Open();
                
                SqlCommand instruction = new SqlCommand(select_query, sql_variable);
                if (check != true)
                {
                    instruction.Parameters.AddWithValue("@type", search_type.Text.ToString());
                }
                    SqlDataReader sql_file_reader = instruction.ExecuteReader();

                while (sql_file_reader.Read())
                {

                    Panel sub_panel = new Panel()
                    {
                        Name = "productPanel",
                        Size = new Size(748, 320),
                        BackColor = Color.FromArgb(183, 149, 111),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new Point(25, 45);


                    if (!sql_file_reader.IsDBNull(6))  // Check if image is not null
                    {
                        byte[] binary_file = (byte[])sql_file_reader["product_image"];
                        MemoryStream var = new MemoryStream(binary_file);
                        pictureBox.Image = Image.FromStream(var);
                    }

                    Button add_Button = new Button()
                    {
                        Name = "addCart",
                        Text = "Add To Cart",
                        Location = new Point(500, 250),
                        Size = new Size(200, 45),
                        Font = new Font("Tahoma", 12, FontStyle.Bold),
                        BackColor = Color.FromArgb(57, 24, 9),
                        ForeColor = Color.White,
                    };

                    add_Button.Tag = (Convert.ToInt32(sql_file_reader["product_id"].ToString()));



                    Label label1 = new Label()
                    {
                        Text = "Product Name: ",
                        Location = new Point(260, 30),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };
                    Label label2 = new Label()
                    {
                        Text = sql_file_reader["product_name"].ToString(),
                        Location = new Point(360, 30),
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
                        Location = new Point(360, 60),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label5 = new Label()
                    {
                        Text = "Price: ",
                        Location = new Point(260, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label6 = new Label()
                    {
                        Text = "$ " + sql_file_reader["price"].ToString(),
                        Location = new Point(360, 90),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };
                    Label label7 = new Label()
                    {
                        Text = "Quantity: ",
                        Location = new Point(260, 120),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label8 = new Label()
                    {
                        Text = sql_file_reader["quantity"].ToString(),
                        Location = new Point(360, 120),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label11 = new Label()
                    {
                        Text = "Product ID: ",
                        Location = new Point(260, 150),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label12 = new Label()
                    {
                        Text = sql_file_reader["product_id"].ToString(),
                        Location = new Point(360, 150),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    Label label13 = new Label()
                    {
                        Text = "Description: ",
                        Location = new Point(260, 180),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                    };

                    Label label14 = new Label()
                    {
                        Text = sql_file_reader["description"].ToString(),
                        Location = new Point(260, 210),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                    };

                    add_Button.Click += add_Button_Click;
                    sub_panel.Controls.Add(pictureBox);
                    sub_panel.Controls.Add(label1);
                    sub_panel.Controls.Add(label2);
                    sub_panel.Controls.Add(label3);
                    sub_panel.Controls.Add(label4);
                    sub_panel.Controls.Add(label5);
                    sub_panel.Controls.Add(label6);
                    sub_panel.Controls.Add(label7);
                    sub_panel.Controls.Add(label8);
                    sub_panel.Controls.Add(label11);
                    sub_panel.Controls.Add(label12);
                    sub_panel.Controls.Add(label13);
                    sub_panel.Controls.Add(label14);
                    sub_panel.Controls.Add(add_Button);

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
        private void browse_products_Load(object sender, EventArgs e)
        {
            insert_panels(true);
        }
        private void add_Button_Click(object sender, EventArgs e)
        {
            Button Button_clicked = (Button)sender;

            int product_id = Convert.ToInt32(Button_clicked.Tag);
            string username = Global_Variables.username;

            SqlConnection sqlVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sqlVar.Open();

               
                string selectQuery = "select quantity from petproduct where product_id = @product_id";
                SqlCommand instruction1 = new SqlCommand(selectQuery, sqlVar);
                instruction1.Parameters.AddWithValue("@product_id", product_id);

                object Obj = instruction1.ExecuteScalar();
                int Quantity;
                if (Obj != null)
                    Quantity = Convert.ToInt32(Obj); 
                else
                    Quantity = 0;

                if (Quantity <= 0)
                {
                    MessageBox.Show("This product is out of stock!");
                    return;
                }

                
                string selectQuery2 = "select cart_id from cart where userid = @username";
                SqlCommand instruction2 = new SqlCommand(selectQuery2, sqlVar);
                instruction2.Parameters.AddWithValue("@username", username);

                object cart_var = instruction2.ExecuteScalar();
                int cart_id;

                if (cart_var == null)
                {
                    string insertQuery = "insert into cart (userid) output inserted.cart_id values (@username)";
                    SqlCommand instruction3 = new SqlCommand(insertQuery, sqlVar);
                    instruction3.Parameters.AddWithValue("@username", username);
                    cart_id = (int)instruction3.ExecuteScalar();
                }
                else
                {
                    cart_id = (int)cart_var;
                }

                
                string insertQuery2 = @"
            if exists (
                select 1 from cartitem 
                where cart_id = @cart_id and product_id = @product_id
            )
            begin
                update cartitem 
                set quantity = quantity + 1 
                where cart_id = @cart_id and product_id = @product_id
            end
            else
            begin
                insert into cartitem (cart_id, product_id, quantity) 
                values (@cart_id, @product_id, 1)
            end
        ";

                SqlCommand instruction4 = new SqlCommand(insertQuery2, sqlVar);
                instruction4.Parameters.AddWithValue("@cart_id", cart_id);
                instruction4.Parameters.AddWithValue("@product_id", product_id);
                instruction4.ExecuteNonQuery();

                
                string updateQuery2 = "update petproduct set quantity = quantity - 1 where product_id = @product_id";
                SqlCommand instruction5 = new SqlCommand(updateQuery2, sqlVar);
                instruction5.Parameters.AddWithValue("@product_id", product_id);
                instruction5.ExecuteNonQuery();

                MessageBox.Show("Product added to cart successfully!");

                
                insert_panels(true);
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

        private void search_type_Button_Click(object sender, EventArgs e)
        {
            if (search_type.Text.ToString() == "All" || search_type.Text.ToString() == "all")
            {
                insert_panels(true);
            }
            else
            {
                insert_panels(false);
                
            }
        }
        
    }
}
