namespace Biljke
{
    partial class BiljkaOdaberi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiljkaOdaberi));
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Odaberi_uredu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(337, 1);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(22, 23);
            this.min.TabIndex = 46;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(358, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 45;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Odaberi biljku!";
            // 
            // Odaberi_uredu
            // 
            this.Odaberi_uredu.BackColor = System.Drawing.Color.White;
            this.Odaberi_uredu.FlatAppearance.BorderSize = 0;
            this.Odaberi_uredu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Odaberi_uredu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odaberi_uredu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Odaberi_uredu.Location = new System.Drawing.Point(284, 130);
            this.Odaberi_uredu.Margin = new System.Windows.Forms.Padding(2);
            this.Odaberi_uredu.Name = "Odaberi_uredu";
            this.Odaberi_uredu.Size = new System.Drawing.Size(98, 46);
            this.Odaberi_uredu.TabIndex = 43;
            this.Odaberi_uredu.Text = "U redu ";
            this.Odaberi_uredu.UseVisualStyleBackColor = false;
            this.Odaberi_uredu.Click += new System.EventHandler(this.Odaberi_uredu_Click);
            // 
            // BiljkaOdaberi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biljke.Properties.Resources.images1;
            this.ClientSize = new System.Drawing.Size(384, 178);
            this.Controls.Add(this.min);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odaberi_uredu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiljkaOdaberi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiljkaOdaberi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Odaberi_uredu;
    }
}