namespace c_Projekt {
    partial class Racun {
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
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblStanje = new System.Windows.Forms.Label();
            this.lblUplata = new System.Windows.Forms.Label();
            this.lblIsplata = new System.Windows.Forms.Label();
            this.lblPosalji = new System.Windows.Forms.Label();
            this.txtBoxUplata = new System.Windows.Forms.TextBox();
            this.txtBoxIsplata = new System.Windows.Forms.TextBox();
            this.txtBoxPosalji = new System.Windows.Forms.TextBox();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnIsplata = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtBoxPosaljiKorisniku = new System.Windows.Forms.TextBox();
            this.lblPosaljiKorisniku = new System.Windows.Forms.Label();
            this.txtBoxIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDobrodosli.Location = new System.Drawing.Point(48, 41);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(230, 34);
            this.lblDobrodosli.TabIndex = 0;
            this.lblDobrodosli.Text = "Dobrodosli---user";
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStanje.Location = new System.Drawing.Point(288, 154);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(239, 25);
            this.lblStanje.TabIndex = 1;
            this.lblStanje.Text = "STANJE NA RACUNU";
            this.lblStanje.Click += new System.EventHandler(this.lblStanje_Click);
            // 
            // lblUplata
            // 
            this.lblUplata.AutoSize = true;
            this.lblUplata.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUplata.Location = new System.Drawing.Point(184, 249);
            this.lblUplata.Name = "lblUplata";
            this.lblUplata.Size = new System.Drawing.Size(94, 21);
            this.lblUplata.TabIndex = 2;
            this.lblUplata.Text = "Uplati iznos:";
            // 
            // lblIsplata
            // 
            this.lblIsplata.AutoSize = true;
            this.lblIsplata.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblIsplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsplata.Location = new System.Drawing.Point(184, 323);
            this.lblIsplata.Name = "lblIsplata";
            this.lblIsplata.Size = new System.Drawing.Size(94, 21);
            this.lblIsplata.TabIndex = 3;
            this.lblIsplata.Text = "Isplati iznos:";
            // 
            // lblPosalji
            // 
            this.lblPosalji.AutoSize = true;
            this.lblPosalji.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblPosalji.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPosalji.Location = new System.Drawing.Point(64, 400);
            this.lblPosalji.Name = "lblPosalji";
            this.lblPosalji.Size = new System.Drawing.Size(98, 21);
            this.lblPosalji.TabIndex = 4;
            this.lblPosalji.Text = "Posalji iznos:";
            // 
            // txtBoxUplata
            // 
            this.txtBoxUplata.Location = new System.Drawing.Point(284, 241);
            this.txtBoxUplata.Multiline = true;
            this.txtBoxUplata.Name = "txtBoxUplata";
            this.txtBoxUplata.Size = new System.Drawing.Size(151, 38);
            this.txtBoxUplata.TabIndex = 5;
            // 
            // txtBoxIsplata
            // 
            this.txtBoxIsplata.Location = new System.Drawing.Point(284, 316);
            this.txtBoxIsplata.Multiline = true;
            this.txtBoxIsplata.Name = "txtBoxIsplata";
            this.txtBoxIsplata.Size = new System.Drawing.Size(151, 36);
            this.txtBoxIsplata.TabIndex = 6;
            // 
            // txtBoxPosalji
            // 
            this.txtBoxPosalji.Location = new System.Drawing.Point(168, 391);
            this.txtBoxPosalji.Multiline = true;
            this.txtBoxPosalji.Name = "txtBoxPosalji";
            this.txtBoxPosalji.Size = new System.Drawing.Size(151, 36);
            this.txtBoxPosalji.TabIndex = 7;
            // 
            // btnUplata
            // 
            this.btnUplata.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUplata.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnUplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUplata.Location = new System.Drawing.Point(466, 240);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(96, 38);
            this.btnUplata.TabIndex = 8;
            this.btnUplata.Text = "Uplati";
            this.btnUplata.UseVisualStyleBackColor = false;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnIsplata
            // 
            this.btnIsplata.BackColor = System.Drawing.Color.SlateBlue;
            this.btnIsplata.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnIsplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIsplata.Location = new System.Drawing.Point(466, 314);
            this.btnIsplata.Name = "btnIsplata";
            this.btnIsplata.Size = new System.Drawing.Size(96, 38);
            this.btnIsplata.TabIndex = 9;
            this.btnIsplata.Text = "Isplati";
            this.btnIsplata.UseVisualStyleBackColor = false;
            this.btnIsplata.Click += new System.EventHandler(this.btnIsplata_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnPosalji.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(597, 391);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(96, 38);
            this.btnPosalji.TabIndex = 10;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtBoxPosaljiKorisniku
            // 
            this.txtBoxPosaljiKorisniku.Location = new System.Drawing.Point(427, 391);
            this.txtBoxPosaljiKorisniku.Multiline = true;
            this.txtBoxPosaljiKorisniku.Name = "txtBoxPosaljiKorisniku";
            this.txtBoxPosaljiKorisniku.Size = new System.Drawing.Size(151, 36);
            this.txtBoxPosaljiKorisniku.TabIndex = 11;
            // 
            // lblPosaljiKorisniku
            // 
            this.lblPosaljiKorisniku.AutoSize = true;
            this.lblPosaljiKorisniku.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblPosaljiKorisniku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPosaljiKorisniku.Location = new System.Drawing.Point(343, 400);
            this.lblPosaljiKorisniku.Name = "lblPosaljiKorisniku";
            this.lblPosaljiKorisniku.Size = new System.Drawing.Size(78, 21);
            this.lblPosaljiKorisniku.TabIndex = 12;
            this.lblPosaljiKorisniku.Text = "Korisniku:";
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.BackColor = System.Drawing.Color.SlateBlue;
            this.txtBoxIspis.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtBoxIspis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxIspis.Location = new System.Drawing.Point(314, 487);
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(167, 60);
            this.txtBoxIspis.TabIndex = 13;
            this.txtBoxIspis.Text = "Ispis Transakcija";
            this.txtBoxIspis.UseVisualStyleBackColor = false;
            this.txtBoxIspis.Click += new System.EventHandler(this.txtBoxIspis_Click);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.lblPosaljiKorisniku);
            this.Controls.Add(this.txtBoxPosaljiKorisniku);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnIsplata);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.txtBoxPosalji);
            this.Controls.Add(this.txtBoxIsplata);
            this.Controls.Add(this.txtBoxUplata);
            this.Controls.Add(this.lblPosalji);
            this.Controls.Add(this.lblIsplata);
            this.Controls.Add(this.lblUplata);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.lblDobrodosli);
            this.Name = "Racun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.Racun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.Label lblUplata;
        private System.Windows.Forms.Label lblIsplata;
        private System.Windows.Forms.Label lblPosalji;
        private System.Windows.Forms.TextBox txtBoxUplata;
        private System.Windows.Forms.TextBox txtBoxIsplata;
        private System.Windows.Forms.TextBox txtBoxPosalji;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnIsplata;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtBoxPosaljiKorisniku;
        private System.Windows.Forms.Label lblPosaljiKorisniku;
        private System.Windows.Forms.Button txtBoxIspis;
    }
}