namespace PetApp
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Register_Login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_Register = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password_Register = new System.Windows.Forms.TextBox();
            this.Show_Password_register = new System.Windows.Forms.CheckBox();
            this.register_Button = new System.Windows.Forms.Button();
            this.FullName_Register = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName_Register = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.show_confirm_Password_register = new System.Windows.Forms.CheckBox();
            this.Confirm_Password_Register = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 10;
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
            this.panel4.Controls.Add(this.Register_Login_button);
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
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(95, 54);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 8, 4, 10);
            this.label5.Size = new System.Drawing.Size(337, 61);
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
            this.label6.Size = new System.Drawing.Size(169, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login Your Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Register_Login_button
            // 
            this.Register_Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(71)))), ((int)(((byte)(35)))));
            this.Register_Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Login_button.FlatAppearance.BorderSize = 0;
            this.Register_Login_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register_Login_button.Location = new System.Drawing.Point(64, 649);
            this.Register_Login_button.Name = "Register_Login_button";
            this.Register_Login_button.Size = new System.Drawing.Size(383, 51);
            this.Register_Login_button.TabIndex = 10;
            this.Register_Login_button.Text = "Login";
            this.Register_Login_button.UseVisualStyleBackColor = false;
            this.Register_Login_button.Click += new System.EventHandler(this.Register_Login_button_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Register Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email:\r\n";
            // 
            // email_Register
            // 
            this.email_Register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_Register.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Register.Location = new System.Drawing.Point(630, 334);
            this.email_Register.Name = "email_Register";
            this.email_Register.Size = new System.Drawing.Size(320, 29);
            this.email_Register.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:\r\n";
            // 
            // Password_Register
            // 
            this.Password_Register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_Register.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Register.Location = new System.Drawing.Point(631, 433);
            this.Password_Register.Name = "Password_Register";
            this.Password_Register.PasswordChar = '*';
            this.Password_Register.Size = new System.Drawing.Size(320, 29);
            this.Password_Register.TabIndex = 16;
            // 
            // Show_Password_register
            // 
            this.Show_Password_register.AutoSize = true;
            this.Show_Password_register.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Password_register.Location = new System.Drawing.Point(821, 468);
            this.Show_Password_register.Name = "Show_Password_register";
            this.Show_Password_register.Size = new System.Drawing.Size(130, 22);
            this.Show_Password_register.TabIndex = 17;
            this.Show_Password_register.Text = "Show Password";
            this.Show_Password_register.UseVisualStyleBackColor = true;
            this.Show_Password_register.CheckedChanged += new System.EventHandler(this.Show_Password_register_CheckedChanged);
            // 
            // register_Button
            // 
            this.register_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.register_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_Button.FlatAppearance.BorderSize = 0;
            this.register_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.register_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_Button.Location = new System.Drawing.Point(627, 604);
            this.register_Button.Name = "register_Button";
            this.register_Button.Size = new System.Drawing.Size(128, 48);
            this.register_Button.TabIndex = 18;
            this.register_Button.Text = "SIGNUP";
            this.register_Button.UseVisualStyleBackColor = false;
            this.register_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // FullName_Register
            // 
            this.FullName_Register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullName_Register.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName_Register.Location = new System.Drawing.Point(630, 157);
            this.FullName_Register.Name = "FullName_Register";
            this.FullName_Register.Size = new System.Drawing.Size(320, 29);
            this.FullName_Register.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Full Name:\r\n";
            // 
            // UserName_Register
            // 
            this.UserName_Register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_Register.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Register.Location = new System.Drawing.Point(631, 243);
            this.UserName_Register.Name = "UserName_Register";
            this.UserName_Register.Size = new System.Drawing.Size(320, 29);
            this.UserName_Register.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Username:\r\n";
            // 
            // show_confirm_Password_register
            // 
            this.show_confirm_Password_register.AutoSize = true;
            this.show_confirm_Password_register.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_confirm_Password_register.Location = new System.Drawing.Point(821, 568);
            this.show_confirm_Password_register.Name = "show_confirm_Password_register";
            this.show_confirm_Password_register.Size = new System.Drawing.Size(130, 22);
            this.show_confirm_Password_register.TabIndex = 25;
            this.show_confirm_Password_register.Text = "Show Password";
            this.show_confirm_Password_register.UseVisualStyleBackColor = true;
            this.show_confirm_Password_register.CheckedChanged += new System.EventHandler(this.show_confirm_Password_register_CheckedChanged);
            // 
            // Confirm_Password_Register
            // 
            this.Confirm_Password_Register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Confirm_Password_Register.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_Register.Location = new System.Drawing.Point(631, 533);
            this.Confirm_Password_Register.Name = "Confirm_Password_Register";
            this.Confirm_Password_Register.PasswordChar = '*';
            this.Confirm_Password_Register.Size = new System.Drawing.Size(320, 29);
            this.Confirm_Password_Register.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Confirm Password:\r\n";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(992, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 22);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.register_exit_Click);
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.show_confirm_Password_register);
            this.Controls.Add(this.Confirm_Password_Register);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserName_Register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FullName_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_Button);
            this.Controls.Add(this.Show_Password_register);
            this.Controls.Add(this.Password_Register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Form";
            this.Load += new System.EventHandler(this.Register_Form_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Register_Login_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_Register;
        private System.Windows.Forms.CheckBox Show_Password_register;
        private System.Windows.Forms.Button register_Button;
        private System.Windows.Forms.TextBox FullName_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName_Register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox show_confirm_Password_register;
        private System.Windows.Forms.TextBox Confirm_Password_Register;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label exit;
    }
}