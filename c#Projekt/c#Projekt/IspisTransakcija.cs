using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace c_Projekt {
    internal class IspisTransakcija : Connection {
        public string ime;
        public string prezime;
        public decimal balance;
        public string tip_transakcije;
        public decimal amount;
        public string datetime;
        public string userId;
        

        public IspisTransakcija() { ; }

        public IspisTransakcija(string userId) {
            this.userId = userId;
        }
        public IspisTransakcija(string ime, string prezime, decimal balance, string tip_transakcije, decimal amount, string datetime) {
            this.ime = ime;
            this.prezime = prezime;
            this.balance = balance;
            this.tip_transakcije = tip_transakcije;
            this.amount = amount;
            this.datetime = datetime;

        }

        public IEnumerable<IspisTransakcija> Ispis(string userId) {
            using (SqlConnection connection = Connection.GetConnection()) {
                connection.Open();


                string query = "SELECT nk.ime, nk.prezime, tk.balance, tk.typeOfTransaction, tk.amount, tk.datetime " +
               "FROM NasiKorisnici nk " +
               "JOIN TransakcijeKorisnika tk ON nk.userId = tk.userId " +
               "WHERE nk.userId = @userId";

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            yield return new IspisTransakcija {
                                ime = reader.GetString(0),
                                prezime = reader.GetString(1),
                                balance = reader.GetDecimal(2),
                                tip_transakcije = reader.GetString(3),
                                amount = reader.GetDecimal(4),
                                datetime = reader.GetDateTime(5).ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<IspisTransakcija> IspisUplata(string userId) {
            using (SqlConnection connection = Connection.GetConnection()) {
                connection.Open();


                string query = "SELECT nk.ime, nk.prezime, tk.balance, tk.typeOfTransaction, tk.amount, tk.datetime " +
               "FROM NasiKorisnici nk " +
               "JOIN TransakcijeKorisnika tk ON nk.userId = tk.userId " +
               "WHERE nk.userId = @userId";

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            yield return new IspisTransakcija {
                                ime = reader.GetString(0),
                                prezime = reader.GetString(1),
                                balance = reader.GetDecimal(2),
                                tip_transakcije = reader.GetString(3),
                                amount = reader.GetDecimal(4),
                                datetime = reader.GetDateTime(5).ToString()
                            };
                        }
                    }
                }
            }
        }


        public async Task RunIspisNotepad(string userId) {
            await Task.Run(() => IspisNotepad(userId));
        }

        public void IspisNotepad(string userId) {
            FileInfo zapis = new FileInfo(@"C:\\Users\\Korisnik\\source\\repos\\c#Projekt\\ispis.txt");

            // Get the data using the Ispis function
            IEnumerable<IspisTransakcija> lista = Ispis(userId);

            // Open the text file for writing
            using (StreamWriter sw = zapis.CreateText()) {
                foreach (IspisTransakcija i in lista) {
                    // Write each data item to the text file
                    sw.WriteLine("balance: " + i.balance + " tip transakcije: " + i.tip_transakcije + " amount: " + i.amount + " datum: " + i.datetime);
                }
            }
            MessageBox.Show("ispis uspjesan , u novom threadu");
        }
       

























    }
    }

