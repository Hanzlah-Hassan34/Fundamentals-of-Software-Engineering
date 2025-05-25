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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetApp
{
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void makePanel()
        {
            cart_panel.Controls.Clear();
            SqlConnection sqlVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sqlVar.Open();
                string username = Global_Variables.username;
                string selectQuery = "SELECT cart_id FROM cart WHERE userid = @username";
                SqlCommand instruction1 = new SqlCommand(selectQuery, sqlVar);
                instruction1.Parameters.AddWithValue("@username", username);

                object Obj = instruction1.ExecuteScalar();

                if (Obj == null)
                {
                    MessageBox.Show("No cart found for user.");
                    return;
                }

                int cart_id = (int)Obj;
                string selectQuery2 = @"
                SELECT p.product_id as ID ,p.product_name as pname, c.quantity as pquantity, p.price as pprice, (c.quantity * p.price) AS total_price
                FROM cartitem as c
                JOIN petproduct as p ON c.product_id = p.product_id
                WHERE c.cart_id = @cart_id";

                SqlCommand instruction3 = new SqlCommand(selectQuery2, sqlVar);
                instruction3.Parameters.AddWithValue("@cart_id", cart_id);

                SqlDataReader reader = instruction3.ExecuteReader();

                cart_panel.Controls.Clear();
                Label label1 = new Label()
                {
                    Text = "Product Name",
                    Location = new Point(30, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };

                Label label2 = new Label()
                {
                    Text = "Quantity",
                    Location = new Point(180, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };

                Label label3 = new Label()
                {
                    Text = "Price",
                    Location = new Point(330, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };

                Label label4 = new Label()
                {
                    Text = "Total Price",
                    Location = new Point(480, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };
                Label label15 = new Label()
                {
                    Text = "Remove",
                    Location = new Point(630, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };
                cart_panel.Controls.Add(label1);
                cart_panel.Controls.Add(label2);
                cart_panel.Controls.Add(label3);
                cart_panel.Controls.Add(label4);
                cart_panel.Controls.Add(label15);

                int count = 60;
                decimal grandTotal = 0;
                while (reader.Read())
                {
                    grandTotal += Convert.ToDecimal(reader["total_price"]);
                    string productName = reader["pname"].ToString();
                    int quantity = Convert.ToInt32(reader["pquantity"]);
                    decimal price = Convert.ToDecimal(reader["pprice"]);
                    decimal total = Convert.ToDecimal(reader["total_price"]);
                    Label label5 = new Label()
                    {
                        Text = reader["pname"].ToString(),
                        Location = new Point(30, count),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label6 = new Label()
                    {
                        Text = reader["pquantity"].ToString(),
                        Location = new Point(180, count),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label7 = new Label()
                    {
                        Text = "$ " + reader["pprice"].ToString(),
                        Location = new Point(330, count),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                    Label label8 = new Label()
                    {
                        Text = "$ " + reader["total_price"].ToString(),
                        Location = new Point(480, count),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5),
                        BackColor = Color.Transparent
                    };

                  

                    Button remove_Button = new Button()
                    {
                        Name = "remove_Button",
                        Text = "-",
                        Location = new Point(660, count),
                        Size = new Size(20, 20),
                        Font = new Font("Tahoma", 12, FontStyle.Bold),
                        BackColor = Color.FromArgb(57, 24, 9),
                        ForeColor = Color.White,
                    };

                    remove_Button.Tag = Convert.ToInt32(reader["ID"].ToString());

                    count += 30;
                    remove_Button.Click += Remove_Button_Click;
                    cart_panel.Controls.Add(label5);
                    cart_panel.Controls.Add(label6);
                    cart_panel.Controls.Add(label7);
                    cart_panel.Controls.Add(label8);
                    cart_panel.Controls.Add(remove_Button);

                }
                Label label11 = new Label()
                {
                    Text = "Grand Total:",
                    Location = new Point(480, count+30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };
                Label label12 = new Label()
                {
                    Text = "$ "+grandTotal.ToString(),
                    Location = new Point(630, count + 30),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };
                Global_Variables.totalAmount = grandTotal;
                Button pay_Button = new Button()
                {
                    Name = "pay_Button",
                    Text = "Pay",
                    Location = new Point(570, count + 90),
                    Size = new Size(150, 45),
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    BackColor = Color.FromArgb(57, 24, 9),
                    ForeColor = Color.White,
                };

                pay_Button.Click += Pay_Button_Click;
                cart_panel.Controls.Add(pay_Button);
                cart_panel.Controls.Add(label11);
                cart_panel.Controls.Add(label12);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void cart_Load(object sender, EventArgs e)
        {
            makePanel();
        }

        private void Pay_Button_Click(object sender, EventArgs e)
        {
            paymentMethod var = new paymentMethod();
            var.Show();
            this.Hide();
        }
        private void Remove_Button_Click(object sender, EventArgs e)
        {
            Button Button_clicked = (Button)sender;
            int product_id = Convert.ToInt32(Button_clicked.Tag); 
            string username = Global_Variables.username;

            SqlConnection sqlVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahid\OneDrive\Documents\pet_listing.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                sqlVar.Open();

                
                string selectQuery4 = "SELECT cart_id FROM cart WHERE userid = @username";
                SqlCommand instruction5 = new SqlCommand(selectQuery4, sqlVar);
                instruction5.Parameters.AddWithValue("@username", username);
                object cart_var = instruction5.ExecuteScalar();

                if (cart_var == null)
                {
                    MessageBox.Show("No cart found for user.");
                    return;
                }

                int cart_id = (int)cart_var;

               
                string selectQuery5 = "SELECT quantity FROM cartitem WHERE cart_id = @cart_id AND product_id = @product_id";
                SqlCommand instruction6 = new SqlCommand(selectQuery5, sqlVar);
                instruction6.Parameters.AddWithValue("@cart_id", cart_id);
                instruction6.Parameters.AddWithValue("@product_id", product_id);

                object Obj = instruction6.ExecuteScalar();

                if (Obj == null)
                {
                    MessageBox.Show("Item not found in cart.");
                    return;
                }

                int cQuantity = Convert.ToInt32(Obj);

                if (cQuantity > 1)
                {
                    
                    string updateQuery1 = "UPDATE cartitem SET quantity = quantity - 1 WHERE cart_id = @cart_id AND product_id = @product_id";
                    SqlCommand instruction7 = new SqlCommand(updateQuery1, sqlVar);
                    instruction7.Parameters.AddWithValue("@cart_id", cart_id);
                    instruction7.Parameters.AddWithValue("@product_id", product_id);
                    instruction7.ExecuteNonQuery();
                }
                else
                {
                    
                    string deleteQuery = "DELETE FROM cartitem WHERE cart_id = @cart_id AND product_id = @product_id";
                    SqlCommand instruction8 = new SqlCommand(deleteQuery, sqlVar);
                    instruction8.Parameters.AddWithValue("@cart_id", cart_id);
                    instruction8.Parameters.AddWithValue("@product_id", product_id);
                    instruction8.ExecuteNonQuery();
                }

                // Increase product quantity in petproduct table
                string updateQuery = "UPDATE petproduct SET quantity = quantity + 1 WHERE product_id = @product_id";
                SqlCommand instruction9 = new SqlCommand(updateQuery, sqlVar);
                instruction9.Parameters.AddWithValue("@product_id", product_id);
                instruction9.ExecuteNonQuery();

                MessageBox.Show("Item removed from cart.");
                makePanel();
                
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
    }
}
