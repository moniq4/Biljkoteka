namespace Biljke
{
    partial class button
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(button));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.prijavab = new System.Windows.Forms.Button();
            this.registr = new System.Windows.Forms.Button();
            this.labelVratise = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 147);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Biljke.Properties.Resources.novo;
            this.pictureBox1.Location = new System.Drawing.Point(320, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka*";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(101, 30);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(159, 20);
            this.Email.TabIndex = 4;
            // 
            // Lozinka
            // 
            this.Lozinka.Location = new System.Drawing.Point(101, 80);
            this.Lozinka.Margin = new System.Windows.Forms.Padding(2);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.PasswordChar = '*';
            this.Lozinka.Size = new System.Drawing.Size(159, 20);
            this.Lozinka.TabIndex = 5;
            // 
            // prijavab
            // 
            this.prijavab.BackColor = System.Drawing.Color.ForestGreen;
            this.prijavab.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.prijavab.FlatAppearance.BorderSize = 0;
            this.prijavab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavab.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavab.Location = new System.Drawing.Point(135, 104);
            this.prijavab.Margin = new System.Windows.Forms.Padding(2);
            this.prijavab.Name = "prijavab";
            this.prijavab.Size = new System.Drawing.Size(158, 31);
            this.prijavab.TabIndex = 6;
            this.prijavab.Text = "Prijavi se";
            this.prijavab.UseVisualStyleBackColor = false;
            this.prijavab.Click += new System.EventHandler(this.Prijava_Click);
            // 
            // registr
            // 
            this.registr.BackColor = System.Drawing.Color.ForestGreen;
            this.registr.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.registr.FlatAppearance.BorderSize = 0;
            this.registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registr.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registr.Location = new System.Drawing.Point(432, 377);
            this.registr.Margin = new System.Windows.Forms.Padding(2);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(158, 31);
            this.registr.TabIndex = 7;
            this.registr.Text = "Registriraj se";
            this.registr.UseVisualStyleBackColor = false;
            this.registr.Click += new System.EventHandler(this.registr_Click);
            // 
            // labelVratise
            // 
            this.labelVratise.AutoSize = true;
            this.labelVratise.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVratise.Location = new System.Drawing.Point(324, 383);
            this.labelVratise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVratise.Name = "labelVratise";
            this.labelVratise.Size = new System.Drawing.Size(105, 18);
            this.labelVratise.TabIndex = 8;
            this.labelVratise.Text = "Nemaš profil? ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.Lozinka);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.prijavab);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Location = new System.Drawing.Point(296, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 135);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(14, 489);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Polja označena * su obavezna!";
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = global::Biljke.Properties.Resources.cards_falling_png_7;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelVratise);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "button";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.Button prijavab;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.Label labelVratise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}