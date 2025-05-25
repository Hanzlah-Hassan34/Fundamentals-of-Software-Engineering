namespace PetApp
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.login_exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName_Login = new System.Windows.Forms.TextBox();
            this.Password_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_Password_Login = new System.Windows.Forms.CheckBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(18)))), ((int)(((byte)(5)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(34, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 772);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(13)))), ((int)(((byte)(6)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.signup_button);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(81, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 772);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(91, 58);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 8, 4, 10);
            this.label5.Size = new System.Drawing.Size(341, 54);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pet Care and Adoption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(159, 591);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(8);
            this.label6.Size = new System.Drawing.Size(192, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Register Your Account";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(71)))), ((int)(((byte)(35)))));
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signup_button.Location = new System.Drawing.Point(64, 649);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(383, 51);
            this.signup_button.TabIndex = 10;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 881);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(13)))), ((int)(((byte)(4)))));
            this.panel3.Location = new System.Drawing.Point(40, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 772);
            this.panel3.TabIndex = 0;
            // 
            // login_exit
            // 
            this.login_exit.AutoSize = true;
            this.login_exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_exit.Location = new System.Drawing.Point(992, 9);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(20, 22);
            this.login_exit.TabIndex = 1;
            this.login_exit.Text = "X";
            this.login_exit.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:\r\n";
            // 
            // userName_Login
            // 
            this.userName_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_Login.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_Login.Location = new System.Drawing.Point(631, 295);
            this.userName_Login.Name = "userName_Login";
            this.userName_Login.Size = new System.Drawing.Size(320, 29);
            this.userName_Login.TabIndex = 5;
            this.userName_Login.TextChanged += new System.EventHandler(this.userName_Login_TextChanged);
            // 
            // Password_Login
            // 
            this.Password_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_Login.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Login.Location = new System.Drawing.Point(631, 390);
            this.Password_Login.Margin = new System.Windows.Forms.Padding(6);
            this.Password_Login.Name = "Password_Login";
            this.Password_Login.PasswordChar = '*';
            this.Password_Login.Size = new System.Drawing.Size(320, 29);
            this.Password_Login.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:\r\n";
            // 
            // Show_Password_Login
            // 
            this.Show_Password_Login.AutoSize = true;
            this.Show_Password_Login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Password_Login.Location = new System.Drawing.Point(821, 425);
            this.Show_Password_Login.Name = "Show_Password_Login";
            this.Show_Password_Login.Size = new System.Drawing.Size(133, 22);
            this.Show_Password_Login.TabIndex = 8;
            this.Show_Password_Login.Text = "Show_Password";
            this.Show_Password_Login.UseVisualStyleBackColor = true;
            this.Show_Password_Login.CheckedChanged += new System.EventHandler(this.Show_Password_Login_CheckedChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Button.Location = new System.Drawing.Point(630, 482);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(128, 48);
            this.Login_Button.TabIndex = 9;
            this.Login_Button.Text = "LOGIN";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Show_Password_Login);
            this.Controls.Add(this.Password_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName_Login;
        private System.Windows.Forms.TextBox Password_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Show_Password_Login;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

