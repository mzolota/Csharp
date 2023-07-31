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
    public partial class Racun : Form {
        private string userId;
        private string ime;
        Upravljac upravljac = new Upravljac();
        
        
        public Racun(string userId,string ime) {
            InitializeComponent();
            this.userId = userId;
            this.ime=ime;
            
        }
        
        private void btnUplata_Click(object sender, EventArgs e) {
            decimal amount = decimal.Parse(txtBoxUplata.Text);
            upravljac.Deposit(amount, userId);
            UpdateBalanceLabel();
        }

        private void btnIsplata_Click(object sender, EventArgs e) {
            decimal amount = decimal.Parse(txtBoxIsplata.Text);
            upravljac.Withdraw(amount, userId);
            UpdateBalanceLabel();
        }

        private void Racun_Load(object sender, EventArgs e) {
            UpdateBalanceLabel();
            lblDobrodosli.Text = "dobrodosli " + ime;

        }

        

        private void btnPosalji_Click(object sender, EventArgs e) {
            decimal amount = decimal.Parse(txtBoxPosalji.Text);
            string senderId = txtBoxPosaljiKorisniku.Text;
            upravljac.Transfer(amount, userId, senderId); // Pass the upravljac instance
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel() {
            decimal balance = upravljac.GetBalance(userId);
            lblStanje.Text = "Stanje na racunu: "+balance.ToString();
        }

        private void lblStanje_Click(object sender, EventArgs e) {

        }

        private void txtBoxIspis_Click(object sender, EventArgs e) {
            IspisForma ispisForma = new IspisForma(userId);
            ispisForma.ShowDialog(); // ShowDialog omogucuje da ne zatvorim ili hide-am , nakon toga hideam Ispis Formu
        }
    }
}
