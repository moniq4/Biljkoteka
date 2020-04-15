namespace Biljke
{
    partial class BiljkaDodajcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiljkaDodajcs));
            this.Dodanalbl = new System.Windows.Forms.Label();
            this.Dodaj_uredu = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodanalbl
            // 
            this.Dodanalbl.AutoSize = true;
            this.Dodanalbl.BackColor = System.Drawing.Color.Transparent;
            this.Dodanalbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodanalbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodanalbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Dodanalbl.Location = new System.Drawing.Point(37, 30);
            this.Dodanalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dodanalbl.Name = "Dodanalbl";
            this.Dodanalbl.Size = new System.Drawing.Size(214, 22);
            this.Dodanalbl.TabIndex = 6;
            this.Dodanalbl.Text = "Biljka je uspješno dodana!";
            // 
            // Dodaj_uredu
            // 
            this.Dodaj_uredu.BackColor = System.Drawing.Color.White;
            this.Dodaj_uredu.FlatAppearance.BorderSize = 0;
            this.Dodaj_uredu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dodaj_uredu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_uredu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Dodaj_uredu.Location = new System.Drawing.Point(303, 130);
            this.Dodaj_uredu.Margin = new System.Windows.Forms.Padding(2);
            this.Dodaj_uredu.Name = "Dodaj_uredu";
            this.Dodaj_uredu.Size = new System.Drawing.Size(98, 46);
            this.Dodaj_uredu.TabIndex = 4;
            this.Dodaj_uredu.Text = "U redu ";
            this.Dodaj_uredu.UseVisualStyleBackColor = false;
            this.Dodaj_uredu.Click += new System.EventHandler(this.Dodaj_uredu_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(377, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 41;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(356, 1);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(22, 23);
            this.min.TabIndex = 42;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // BiljkaDodajcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biljke.Properties.Resources.images1;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.min);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Dodanalbl);
            this.Controls.Add(this.Dodaj_uredu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BiljkaDodajcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiljkaDodajcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Dodanalbl;
        private System.Windows.Forms.Button Dodaj_uredu;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button min;
    }
}