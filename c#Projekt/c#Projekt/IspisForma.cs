using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class IspisForma : Form {
        private string userId;
        IspisTransakcija ispisTransakcija = new IspisTransakcija();
        

        public IspisForma(string userId) {
            InitializeComponent();
            this.userId = userId;
            ispisTransakcija = new IspisTransakcija(userId);
            
            listView1.View = View.Details;
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Balance");
            listView1.Columns.Add("TypeOfTransaction");
            listView1.Columns.Add("Amount");
            listView1.Columns.Add("Datetime");


        }

        private void btnPovratak_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnPrikazTransakcija_Click(object sender, EventArgs e) {

            listView1.Items.Clear();
            IEnumerable<IspisTransakcija> transactions = ispisTransakcija.Ispis(userId);

            foreach (IspisTransakcija transakcija in transactions) {
                ListViewItem item = new ListViewItem(new[] {
                transakcija.ime,
                transakcija.prezime,
                transakcija.balance.ToString(),
                transakcija.tip_transakcije,
                transakcija.amount.ToString(),
                transakcija.datetime
            });

                listView1.Items.Add(item);
            }
            DisplayTransactionsInChart(transactions);
        }

        // za display na chartu , re-used nema sanse da opet radim s bazom
        /* jel je ok takve stvari radit ? ili bi se svaka metoda brinila za sebe ? da nisam preuzeo ispunjeni IE moramo bi ponovno dohvatit sve iz baze
        i pisati kod ? povecana efikasnost? */
        // ty chat for writing me how 2 display in that thing
        /* htio probati implementirati da se metoda izvrsi u posebnom threadu , savijet chata : treba biti oprezan kada se share resoursi i mjenjaju
        UI elementi forme --> znaci 0 bodova*/
        private void DisplayTransactionsInChart(IEnumerable<IspisTransakcija> transactions) {
            Chart.Series.Clear();
            ColumnSeries columnSeries = new ColumnSeries {
                Title = "Transaction Amount", // Set the title of the series
                Values = new ChartValues<decimal>(), // Create a new collection for the values
            };
            foreach (IspisTransakcija transakcija in transactions) {
                columnSeries.Values.Add(transakcija.amount); 
            }
            Chart.Series.Add(columnSeries);
        }



        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnSamoDeposit_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            IEnumerable<IspisTransakcija> transactions = ispisTransakcija.Ispis(userId);
            IEnumerable<IspisTransakcija> uplate =  from uplata in transactions where uplata.tip_transakcije=="deposit" select uplata;

            foreach (IspisTransakcija uplata in uplate) {
                ListViewItem item = new ListViewItem(new[] {
                uplata.ime,
                uplata.prezime,
                uplata.balance.ToString(),
                uplata.tip_transakcije,
                uplata.amount.ToString(),
                uplata.datetime
            });

                listView1.Items.Add(item);

            }
        }

        private async void btnIspisNotepad_Click(object sender, EventArgs e) {
            await ispisTransakcija.RunIspisNotepad(userId);

        }


    }
}