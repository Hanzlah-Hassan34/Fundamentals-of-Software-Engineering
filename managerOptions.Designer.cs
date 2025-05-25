namespace PetApp
{
    partial class managerOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerOptions));
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.managerinventory_Button = new System.Windows.Forms.Button();
            this.updateinventory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(992, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 22);
            this.exit.TabIndex = 64;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-167, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // managerinventory_Button
            // 
            this.managerinventory_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.managerinventory_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerinventory_Button.FlatAppearance.BorderSize = 0;
            this.managerinventory_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.managerinventory_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerinventory_Button.Location = new System.Drawing.Point(666, 258);
            this.managerinventory_Button.Name = "managerinventory_Button";
            this.managerinventory_Button.Size = new System.Drawing.Size(300, 48);
            this.managerinventory_Button.TabIndex = 19;
            this.managerinventory_Button.Text = "Manage Inventory";
            this.managerinventory_Button.UseVisualStyleBackColor = false;
            this.managerinventory_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // updateinventory
            // 
            this.updateinventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(24)))), ((int)(((byte)(9)))));
            this.updateinventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateinventory.FlatAppearance.BorderSize = 0;
            this.updateinventory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.updateinventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateinventory.Location = new System.Drawing.Point(666, 361);
            this.updateinventory.Name = "updateinventory";
            this.updateinventory.Size = new System.Drawing.Size(300, 48);
            this.updateinventory.TabIndex = 66;
            this.updateinventory.Text = "Update Inventory";
            this.updateinventory.UseVisualStyleBackColor = false;
            this.updateinventory.Click += new System.EventHandler(this.updateinventory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 768);
            this.panel1.TabIndex = 67;
            // 
            // managerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateinventory);
            this.Controls.Add(this.managerinventory_Button);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "managerOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerOptions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button managerinventory_Button;
        private System.Windows.Forms.Button updateinventory;
        private System.Windows.Forms.Panel panel1;
    }
}