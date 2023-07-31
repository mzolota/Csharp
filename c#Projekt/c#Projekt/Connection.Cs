using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Projekt {
    internal class Connection {

        private static string connectionString = @"Data Source=DESKTOP-RGBACNO\SQLEXPRESS;Initial Catalog=BazaPodataka;Integrated Security=True";
        public static SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }

        public static bool Registracija(string userId, string ime, string prezime, string lozinka, string kontakt) {
                

                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    try {
                        connection.Open();

                        string query = "INSERT INTO NasiKorisnici (userId , ime, prezime, lozinka, kontakt ) VALUES (@userId, @ime, @prezime, @lozinka, @kontakt)";

                        using (SqlCommand command = new SqlCommand(query, connection)) {
                            command.Parameters.AddWithValue("@userId", userId);
                            command.Parameters.AddWithValue("@ime", ime);
                            command.Parameters.AddWithValue("@prezime", prezime);
                            command.Parameters.AddWithValue("@lozinka", lozinka);
                            command.Parameters.AddWithValue("@kontakt", kontakt);
                          

                            int rowsAffected = command.ExecuteNonQuery();

                            return rowsAffected > 0;
                        }
                    } catch (Exception ex) {
                        Console.WriteLine("Error registering user: " + ex.Message);
                        return false;
                    }
                }
            }



        }
    }


