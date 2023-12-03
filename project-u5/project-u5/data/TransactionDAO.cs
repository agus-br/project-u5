using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace project_u5.data
{
    public class TransactionDAO
    {
        public static List<CLSTransaction> GetAll()
        {
            List<CLSTransaction> transactions = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getAllTransactions";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    transactions = new List<CLSTransaction>();
                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSCategory c = new CLSCategory(
                            Convert.ToInt32(fila["cID"]),
                            fila["cName"].ToString(),
                            fila["cDescription"].ToString()
                        );
                        CLSPlace p = new CLSPlace(
                            Convert.ToInt32(fila["pID"]),
                            fila["pName"].ToString(),
                            fila["pCity"].ToString(),
                            fila["pCountry"].ToString()
                        );

                        CLSTransaction transaction = new CLSTransaction(
                            Convert.ToInt32(fila["tID"]),
                            fila["tConcept"].ToString(),
                            Convert.ToDateTime(fila["tDate"]),
                            Convert.ToDouble(fila["tAmount"]),
                            fila["tType"].ToString(),
                            fila["tNotes"].ToString(),
                            c,
                            p
                            );
                        transactions.Add(transaction);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return transactions;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return transactions;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return transactions;
            }
        }

        public static int AddTransaction(CLSTransaction t)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "addTransaction";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("transactionConcept", t.Concept);
                    command.Parameters.AddWithValue("transactionDate", t.Date);
                    command.Parameters.AddWithValue("transactionAmount", t.Amount);
                    command.Parameters.AddWithValue("transactionType", t.Type);
                    command.Parameters.AddWithValue("transactionNotes", t.Notes);
                    command.Parameters.AddWithValue("transactionCategoryID", t.Category.ID);
                    command.Parameters.AddWithValue("transactionPlaceID", t.Place.ID);

                    command.ExecuteNonQuery();
                    command.Dispose();

                    sentence = "select last_insert_id();";
                    command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.Dispose();
                    int id = Convert.ToInt32(command.ExecuteScalar());

                    trans.Commit();
                    return id;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return 0;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return 0;
            }
        }
               
        public static bool UpdateTransaction(CLSTransaction t)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "updateTransaction";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("transactionID", t.ID);
                    command.Parameters.AddWithValue("transactionConcept", t.Concept);
                    command.Parameters.AddWithValue("transactionDate", t.Date);
                    command.Parameters.AddWithValue("transactionAmount", t.Amount);
                    command.Parameters.AddWithValue("transactionType", t.Type);
                    command.Parameters.AddWithValue("transactionNotes", t.Notes);
                    command.Parameters.AddWithValue("transactionCategoryID", t.Category.ID);
                    command.Parameters.AddWithValue("transactionPlaceID", t.Place.ID);

                    command.ExecuteNonQuery();
                    command.Dispose();
                    trans.Commit();

                    return true;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return false;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return false;
            }
        }
               
        public static bool DeleteTransaction(int transactionID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "deleteTransaction";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("transactionID", transactionID);
                    
                    command.ExecuteNonQuery();
                    command.Dispose();
                    trans.Commit();

                    return true;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return false;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return false;
            }
        }

    }
}
