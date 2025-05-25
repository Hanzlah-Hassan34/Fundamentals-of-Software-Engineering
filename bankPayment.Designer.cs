namespace PetApp
{
    partial class bankPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.ComboBox();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.submit_button_application = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 721);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-186, -95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 958);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Location = new System.Drawing.Point(972, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 22);
            this.exit.TabIndex = 15;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(20)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(587, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 72);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bank Transfer";
            // 
            // bank
            // 
            this.bank.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "Habib Bank Limited",
            "United Bank Limited",
            "MCB Bank Limited",
            "Allied Bank Limited",
            "Askari Bank Limited",
            "Bank Alfalah Limited",
            "Faysal Bank Limited",
            "Meezan Bank Limited",
            "Habib Metropolitan Bank Limited"});
            this.bank.Location = new System.Drawing.Point(608, 206);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(339, 29);
            this.bank.TabIndex = 128;
            this.bank.SelectedIndexChanged += new System.EventHandler(this.bank_SelectedIndexChanged);
            // 
            // accountNumber
            // 
            this.accountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.Location = new System.Drawing.Point(608, 325);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(339, 29);
            this.accountNumber.TabIndex = 127;
            this.accountNumber.TextChanged += new System.EventHandler(this.income_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(604, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 24);
            this.label16.TabIndex = 126;
            this.label16.Text = "Enter Account Number:\n";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(604, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 125;
            this.label15.Text = "Select Bank:\n";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // submit_button_application
            // 
            this.submit_button_application.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.submit_button_application.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button_application.FlatAppearance.BorderSize = 0;
            this.submit_button_application.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.submit_button_application.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit_button_application.Location = new System.Drawing.Point(819, 525);
            this.submit_button_application.Name = "submit_button_application";
            this.submit_button_application.Size = new System.Drawing.Size(128, 48);
            this.submit_button_application.TabIndex = 129;
            this.submit_button_application.Text = "OK";
            this.submit_button_application.UseVisualStyleBackColor = false;
            this.submit_button_application.Click += new System.EventHandler(this.submit_button_application_Click);
            // 
            // amount
            // 
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(608, 442);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(339, 29);
            this.amount.TabIndex = 131;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 130;
            this.label2.Text = "Amount:\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bankPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_button_application);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bankPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bankPayment";
            this.Load += new System.EventHandler(this.bankPayment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button submit_button_application;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label2;
    }
}