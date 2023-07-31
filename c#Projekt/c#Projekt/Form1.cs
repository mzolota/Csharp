using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_Projekt {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e) {
            try {
                string userIdInput = txtBoxUsername.Text;
                int userId = int.Parse(userIdInput);

                Connection.Registracija(txtBoxUsername.Text, txtBoxIme.Text, txtBoxPrezime.Text, txtBoxKontakt.Text, txtBoxLozinka.Text);
                Racuni novi = new Racuni(txtBoxIme.Text, txtBoxPrezime.Text, txtBoxKontakt.Text, txtBoxLozinka.Text, txtBoxUsername.Text);
                novi.UserId = txtBoxUsername.Text;
                string test = novi.GetIme();

                Racun racun = new Racun(txtBoxUsername.Text, txtBoxIme.Text); // Pass the userId here
                racun.Show();
                this.Hide();
            }
            catch (FormatException) { MessageBox.Show("Molim Vas unesite samo  broj", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           

        }

        private void lblKontakt_Click(object sender, EventArgs e) {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
