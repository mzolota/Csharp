namespace c_Projekt {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxKontakt = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.SlateBlue;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lblIme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIme.Location = new System.Drawing.Point(181, 203);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(45, 23);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.SlateBlue;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrezime.Location = new System.Drawing.Point(144, 260);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(82, 23);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.SlateBlue;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLozinka.Location = new System.Drawing.Point(145, 317);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(78, 23);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.BackColor = System.Drawing.Color.SlateBlue;
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lblKontakt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKontakt.Location = new System.Drawing.Point(148, 370);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(78, 23);
            this.lblKontakt.TabIndex = 3;
            this.lblKontakt.Text = "Kontakt:";
            this.lblKontakt.Click += new System.EventHandler(this.lblKontakt_Click);
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(229, 203);
            this.txtBoxIme.Multiline = true;
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(187, 36);
            this.txtBoxIme.TabIndex = 4;
            // 
            // txtBoxKontakt
            // 
            this.txtBoxKontakt.Location = new System.Drawing.Point(229, 370);
            this.txtBoxKontakt.Multiline = true;
            this.txtBoxKontakt.Name = "txtBoxKontakt";
            this.txtBoxKontakt.Size = new System.Drawing.Size(187, 35);
            this.txtBoxKontakt.TabIndex = 5;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(229, 317);
            this.txtBoxLozinka.Multiline = true;
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(187, 35);
            this.txtBoxLozinka.TabIndex = 6;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(229, 260);
            this.txtBoxPrezime.Multiline = true;
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(187, 35);
            this.txtBoxPrezime.TabIndex = 7;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistracija.Location = new System.Drawing.Point(247, 420);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(149, 47);
            this.btnRegistracija.TabIndex = 8;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.Color.SlateBlue;
            this.lblRegistracija.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistracija.Location = new System.Drawing.Point(230, 70);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(186, 41);
            this.lblRegistracija.TabIndex = 9;
            this.lblRegistracija.Text = "Registracija";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.SlateBlue;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserId.Location = new System.Drawing.Point(151, 153);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(75, 23);
            this.lblUserId.TabIndex = 10;
            this.lblUserId.Text = "User ID:";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(229, 153);
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(187, 35);
            this.txtBoxUsername.TabIndex = 11;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnRegistracija);
            this.bunifuGradientPanel1.Controls.Add(this.lblRegistracija);
            this.bunifuGradientPanel1.Controls.Add(this.lblUserId);
            this.bunifuGradientPanel1.Controls.Add(this.txtBoxUsername);
            this.bunifuGradientPanel1.Controls.Add(this.txtBoxKontakt);
            this.bunifuGradientPanel1.Controls.Add(this.lblIme);
            this.bunifuGradientPanel1.Controls.Add(this.lblPrezime);
            this.bunifuGradientPanel1.Controls.Add(this.lblLozinka);
            this.bunifuGradientPanel1.Controls.Add(this.lblKontakt);
            this.bunifuGradientPanel1.Controls.Add(this.txtBoxLozinka);
            this.bunifuGradientPanel1.Controls.Add(this.txtBoxPrezime);
            this.bunifuGradientPanel1.Controls.Add(this.txtBoxIme);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(709, 563);
            this.bunifuGradientPanel1.TabIndex = 12;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 563);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxKontakt;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}

