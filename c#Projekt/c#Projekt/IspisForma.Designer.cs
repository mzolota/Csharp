namespace c_Projekt {
    partial class IspisForma {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IspisForma));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnIspisNotepad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSamoDeposit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPovratak = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrikazTransakcija = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Chart = new LiveCharts.WinForms.CartesianChart();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Chart);
            this.bunifuGradientPanel1.Controls.Add(this.btnIspisNotepad);
            this.bunifuGradientPanel1.Controls.Add(this.btnSamoDeposit);
            this.bunifuGradientPanel1.Controls.Add(this.btnPovratak);
            this.bunifuGradientPanel1.Controls.Add(this.btnPrikazTransakcija);
            this.bunifuGradientPanel1.Controls.Add(this.listView1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.GhostWhite;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkSlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1086, 602);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btnIspisNotepad
            // 
            this.btnIspisNotepad.Activecolor = System.Drawing.Color.Transparent;
            this.btnIspisNotepad.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIspisNotepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIspisNotepad.BorderRadius = 0;
            this.btnIspisNotepad.ButtonText = "Ispis";
            this.btnIspisNotepad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspisNotepad.DisabledColor = System.Drawing.Color.Gray;
            this.btnIspisNotepad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspisNotepad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIspisNotepad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIspisNotepad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIspisNotepad.Iconimage")));
            this.btnIspisNotepad.Iconimage_right = null;
            this.btnIspisNotepad.Iconimage_right_Selected = null;
            this.btnIspisNotepad.Iconimage_Selected = null;
            this.btnIspisNotepad.IconMarginLeft = 0;
            this.btnIspisNotepad.IconMarginRight = 0;
            this.btnIspisNotepad.IconRightVisible = true;
            this.btnIspisNotepad.IconRightZoom = 0D;
            this.btnIspisNotepad.IconVisible = true;
            this.btnIspisNotepad.IconZoom = 90D;
            this.btnIspisNotepad.IsTab = false;
            this.btnIspisNotepad.Location = new System.Drawing.Point(47, 474);
            this.btnIspisNotepad.Margin = new System.Windows.Forms.Padding(4);
            this.btnIspisNotepad.Name = "btnIspisNotepad";
            this.btnIspisNotepad.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnIspisNotepad.OnHovercolor = System.Drawing.Color.MediumPurple;
            this.btnIspisNotepad.OnHoverTextColor = System.Drawing.Color.GhostWhite;
            this.btnIspisNotepad.selected = false;
            this.btnIspisNotepad.Size = new System.Drawing.Size(122, 51);
            this.btnIspisNotepad.TabIndex = 4;
            this.btnIspisNotepad.Text = "Ispis";
            this.btnIspisNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspisNotepad.Textcolor = System.Drawing.Color.White;
            this.btnIspisNotepad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisNotepad.Click += new System.EventHandler(this.btnIspisNotepad_Click);
            // 
            // btnSamoDeposit
            // 
            this.btnSamoDeposit.Activecolor = System.Drawing.Color.Transparent;
            this.btnSamoDeposit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSamoDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSamoDeposit.BorderRadius = 0;
            this.btnSamoDeposit.ButtonText = "Prikazi Uplate";
            this.btnSamoDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSamoDeposit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSamoDeposit.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSamoDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSamoDeposit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSamoDeposit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSamoDeposit.Iconimage")));
            this.btnSamoDeposit.Iconimage_right = null;
            this.btnSamoDeposit.Iconimage_right_Selected = null;
            this.btnSamoDeposit.Iconimage_Selected = null;
            this.btnSamoDeposit.IconMarginLeft = 0;
            this.btnSamoDeposit.IconMarginRight = 0;
            this.btnSamoDeposit.IconRightVisible = true;
            this.btnSamoDeposit.IconRightZoom = 0D;
            this.btnSamoDeposit.IconVisible = true;
            this.btnSamoDeposit.IconZoom = 90D;
            this.btnSamoDeposit.IsTab = false;
            this.btnSamoDeposit.Location = new System.Drawing.Point(47, 369);
            this.btnSamoDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSamoDeposit.Name = "btnSamoDeposit";
            this.btnSamoDeposit.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnSamoDeposit.OnHovercolor = System.Drawing.Color.MediumPurple;
            this.btnSamoDeposit.OnHoverTextColor = System.Drawing.Color.GhostWhite;
            this.btnSamoDeposit.selected = false;
            this.btnSamoDeposit.Size = new System.Drawing.Size(177, 51);
            this.btnSamoDeposit.TabIndex = 3;
            this.btnSamoDeposit.Text = "Prikazi Uplate";
            this.btnSamoDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSamoDeposit.Textcolor = System.Drawing.Color.White;
            this.btnSamoDeposit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSamoDeposit.Click += new System.EventHandler(this.btnSamoDeposit_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Activecolor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPovratak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPovratak.BorderRadius = 0;
            this.btnPovratak.ButtonText = "Povratak";
            this.btnPovratak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPovratak.DisabledColor = System.Drawing.Color.Gray;
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPovratak.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPovratak.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.Iconimage")));
            this.btnPovratak.Iconimage_right = null;
            this.btnPovratak.Iconimage_right_Selected = null;
            this.btnPovratak.Iconimage_Selected = null;
            this.btnPovratak.IconMarginLeft = 0;
            this.btnPovratak.IconMarginRight = 0;
            this.btnPovratak.IconRightVisible = true;
            this.btnPovratak.IconRightZoom = 0D;
            this.btnPovratak.IconVisible = true;
            this.btnPovratak.IconZoom = 90D;
            this.btnPovratak.IsTab = false;
            this.btnPovratak.Location = new System.Drawing.Point(906, 528);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnPovratak.OnHovercolor = System.Drawing.Color.White;
            this.btnPovratak.OnHoverTextColor = System.Drawing.Color.SlateBlue;
            this.btnPovratak.selected = false;
            this.btnPovratak.Size = new System.Drawing.Size(147, 51);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPovratak.Textcolor = System.Drawing.Color.White;
            this.btnPovratak.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnPrikazTransakcija
            // 
            this.btnPrikazTransakcija.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrikazTransakcija.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPrikazTransakcija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrikazTransakcija.BorderRadius = 0;
            this.btnPrikazTransakcija.ButtonText = "Prikazi transakcije";
            this.btnPrikazTransakcija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikazTransakcija.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrikazTransakcija.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazTransakcija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrikazTransakcija.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrikazTransakcija.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrikazTransakcija.Iconimage")));
            this.btnPrikazTransakcija.Iconimage_right = null;
            this.btnPrikazTransakcija.Iconimage_right_Selected = null;
            this.btnPrikazTransakcija.Iconimage_Selected = null;
            this.btnPrikazTransakcija.IconMarginLeft = 0;
            this.btnPrikazTransakcija.IconMarginRight = 0;
            this.btnPrikazTransakcija.IconRightVisible = true;
            this.btnPrikazTransakcija.IconRightZoom = 0D;
            this.btnPrikazTransakcija.IconVisible = true;
            this.btnPrikazTransakcija.IconZoom = 90D;
            this.btnPrikazTransakcija.IsTab = false;
            this.btnPrikazTransakcija.Location = new System.Drawing.Point(458, 287);
            this.btnPrikazTransakcija.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazTransakcija.Name = "btnPrikazTransakcija";
            this.btnPrikazTransakcija.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnPrikazTransakcija.OnHovercolor = System.Drawing.Color.MediumPurple;
            this.btnPrikazTransakcija.OnHoverTextColor = System.Drawing.Color.GhostWhite;
            this.btnPrikazTransakcija.selected = false;
            this.btnPrikazTransakcija.Size = new System.Drawing.Size(216, 51);
            this.btnPrikazTransakcija.TabIndex = 1;
            this.btnPrikazTransakcija.Text = "Prikazi transakcije";
            this.btnPrikazTransakcija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazTransakcija.Textcolor = System.Drawing.Color.White;
            this.btnPrikazTransakcija.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazTransakcija.Click += new System.EventHandler(this.btnPrikazTransakcija_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(511, 0);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(574, 267);
            this.Chart.TabIndex = 5;
            this.Chart.Text = "cartesianChart1";
            // 
            // IspisForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 602);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "IspisForma";
            this.Text = "IspisForma";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ListView listView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrikazTransakcija;
        private Bunifu.Framework.UI.BunifuFlatButton btnPovratak;
        private Bunifu.Framework.UI.BunifuFlatButton btnSamoDeposit;
        private Bunifu.Framework.UI.BunifuFlatButton btnIspisNotepad;
        private LiveCharts.WinForms.CartesianChart Chart;
    }
}