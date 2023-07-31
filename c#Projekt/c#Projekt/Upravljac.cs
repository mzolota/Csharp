using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace c_Projekt {
    internal class Upravljac : Connection {
        private string userId;
        private decimal balance = 0;
        private string typeOfTransaction;
        private decimal amount;
        private DateTime datetime;
        private string ime;
        
        public Upravljac() { }


        public void Deposit(decimal amount, string userId) {

            Connection.GetConnection();
            this.userId = userId;
            this.balance = balance + amount;
            this.typeOfTransaction = "deposit";
            this.amount = amount;
            this.datetime = DateTime.Now;

            using (SqlConnection connection = Connection.GetConnection()) {
                try {
                    connection.Open();

                    string query = "INSERT INTO TransakcijeKorisnika (userId , balance, typeOfTransaction , amount ,datetime ) VALUES (@userId, @balance, @typeOfTransaction, @amount, @datetime)";

                    using (SqlCommand command = new SqlCommand(query, connection)) {

                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@balance", balance);
                        command.Parameters.AddWithValue("@typeOfTransaction", typeOfTransaction);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@datetime", datetime);
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Uspjesna uplata ");
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error depositing: " + ex.Message);
                    MessageBox.Show("Error depositing: " + ex.Message);

                }
            }
        }

        public void Withdraw(decimal amount, string userId) {

            Connection.GetConnection();
            this.userId = userId;
            this.balance = balance - amount;
            this.typeOfTransaction = "withdraw";
            this.amount = amount;
            this.datetime = DateTime.Now;

            using (SqlConnection connection = Connection.GetConnection()) {
                try {
                    connection.Open();
                    if (balance - amount < 0) { MessageBox.Show("Nemate dovoljno novcanih sredstava na raspolaganju"); } else {

                        string query = "INSERT INTO TransakcijeKorisnika (userId , balance, typeOfTransaction , amount ,datetime ) VALUES (@userId, @balance, @typeOfTransaction, @amount, @datetime)";

                        using (SqlCommand command = new SqlCommand(query, connection)) {

                            command.Parameters.AddWithValue("@userId", userId);
                            command.Parameters.AddWithValue("@balance", balance);
                            command.Parameters.AddWithValue("@typeOfTransaction", typeOfTransaction);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@datetime", datetime);
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Transakcija je uspjela ");
                        }
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error withdrawing: " + ex.Message);
                    MessageBox.Show("Error withdrawing: " + ex.Message);

                }
            }
        }


        public decimal GetBalance(string userId) {
            Connection.GetConnection();
            using (SqlConnection connection = Connection.GetConnection()) {
                try {
                    connection.Open();

                    string query = @"
                    SELECT TOP 1 balance
                    FROM TransakcijeKorisnika
                    WHERE userId = @userId
                    ORDER BY datetime DESC";

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@userId", userId);
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal balance)) {
                            return balance;
                        }
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error pri dohvaćanju stanja racuna " + ex.Message);
                }
            }
           

            return 0;
        }

        // AI pomoc , nebi mogao sam
        public void Transfer(decimal amount, string senderId, string receiverId) {
            using (SqlConnection connection = Connection.GetConnection()) {
                connection.Open();

                decimal senderBalance = GetBalance(senderId);
                if (amount > senderBalance) {
                    MessageBox.Show("Nemate dovoljno sredstava na raspolaganju");
                    return;
                }

                // Get the last transaction for sender
                decimal lastSenderBalance = GetLastTransactionBalance(senderId, connection);

                // Calculate the new balance for sender
                decimal newSenderBalance = lastSenderBalance - amount;

                // Insert transaction for sender
                string insertSenderTransactionQuery = "INSERT INTO TransakcijeKorisnika (userId, balance, typeOfTransaction, amount, datetime) " +
                                                      "VALUES (@userId, @balance, 'account transfer', @amount, @datetime)";
                SqlCommand insertSenderTransactionCommand = new SqlCommand(insertSenderTransactionQuery, connection);
                insertSenderTransactionCommand.Parameters.AddWithValue("@userId", senderId);
                insertSenderTransactionCommand.Parameters.AddWithValue("@balance", newSenderBalance);
                insertSenderTransactionCommand.Parameters.AddWithValue("@amount", -amount); // Negative amount for withdrawal
                insertSenderTransactionCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
                insertSenderTransactionCommand.ExecuteNonQuery();

                // Get the last transaction for receiver
                decimal lastReceiverBalance = GetLastTransactionBalance(receiverId, connection);

                // Calculate the new balance for receiver
                decimal newReceiverBalance = lastReceiverBalance + amount;

                // Insert transaction for receiver
                string insertReceiverTransactionQuery = "INSERT INTO TransakcijeKorisnika (userId, balance, typeOfTransaction, amount, datetime) " +
                                                        "VALUES (@userId, @balance, 'account transfer', @amount, @datetime)";
                SqlCommand insertReceiverTransactionCommand = new SqlCommand(insertReceiverTransactionQuery, connection);
                insertReceiverTransactionCommand.Parameters.AddWithValue("@userId", receiverId);
                insertReceiverTransactionCommand.Parameters.AddWithValue("@balance", newReceiverBalance);
                insertReceiverTransactionCommand.Parameters.AddWithValue("@amount", amount); // Positive amount for deposit
                insertReceiverTransactionCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
                insertReceiverTransactionCommand.ExecuteNonQuery();

                string insertFinalSenderTransactionQuery = "INSERT INTO TransakcijeKorisnika (userId, balance, typeOfTransaction, amount, datetime) " +
                                                   "VALUES (@userId, @balance, 'account transfer', @amount, @datetime)";
                SqlCommand insertFinalSenderTransactionCommand = new SqlCommand(insertFinalSenderTransactionQuery, connection);
                insertFinalSenderTransactionCommand.Parameters.AddWithValue("@userId", senderId);
                insertFinalSenderTransactionCommand.Parameters.AddWithValue("@balance", newSenderBalance);
                insertFinalSenderTransactionCommand.Parameters.AddWithValue("@amount", amount); // Positive amount for deposit
                insertFinalSenderTransactionCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
                insertFinalSenderTransactionCommand.ExecuteNonQuery();

                MessageBox.Show("Uspješan prijenos.");
            }
        }

        public decimal GetLastTransactionBalance(string userId, SqlConnection connection) {
            string query = "SELECT TOP 1 balance FROM TransakcijeKorisnika WHERE userId = @userId ORDER BY datetime DESC";
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@userId", userId);
                object result = command.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal balance)) {
                    return balance;
                } else {
                    return 0;
                }
            }
        }
        // 

       








    }
}
    


    


    




    



    