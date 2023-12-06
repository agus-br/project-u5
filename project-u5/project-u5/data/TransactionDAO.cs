using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;

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
                        CLSStore s = new CLSStore(
                            Convert.ToInt32(fila["sID"]),
                            fila["sName"].ToString(),
                            fila["sAddress"].ToString(),
                            fila["sContact"].ToString()
                        );

                        CLSTransaction transaction = new CLSTransaction(
                            Convert.ToInt32(fila["tID"]),
                            fila["tConcept"].ToString(),
                            Convert.ToDateTime(fila["tDate"]),
                            Convert.ToDouble(fila["tTotal"]),
                            s
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

        public static List<CLSTransaction> GetAllTransactionsByDate(int year, int month)
        {
            List<CLSTransaction> transactions = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getTransactionsByDate";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("yyyy", year);
                    command.Parameters.AddWithValue("mm", month);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    transactions = new List<CLSTransaction>();
                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSStore s = new CLSStore(
                            fila["sID"] == DBNull.Value ? 0 : Convert.ToInt32(fila["sID"]),
                            fila["sName"] == DBNull.Value ? "" : fila["sName"].ToString(),
                            fila["sAddress"] == DBNull.Value ? "" : fila["sAddress"].ToString(),
                            fila["sContact"] == DBNull.Value ? "" :fila["sContact"].ToString()
                        );

                        CLSTransaction transaction = new CLSTransaction(
                            Convert.ToInt32(fila["tID"]),
                            fila["tConcept"].ToString(),
                            Convert.ToDateTime(fila["tDate"]),
                            Convert.ToDouble(fila["tTotal"]),
                            s
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


        public static CLSTransaction Get(int transactionID)
        {
            CLSTransaction transaction = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getTransaction";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("transactionID", transactionID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSStore p = new CLSStore(
                            Convert.ToInt32(fila["pID"]),
                            fila["pName"].ToString(),
                            fila["pCity"].ToString(),
                            fila["pCountry"].ToString()
                        );

                        transaction = new CLSTransaction(
                            Convert.ToInt32(fila["tID"]),
                            fila["tConcept"].ToString(),
                            Convert.ToDateTime(fila["tDate"]),
                            Convert.ToDouble(fila["tTotal"]),
                            p
                            );
                    }
                    command.Dispose();
                    //trans.Commit();
                    return transaction;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return transaction;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return transaction;
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
                    command.Parameters.AddWithValue("transactionTotal", t.Total);
                    command.Parameters.AddWithValue("transactionStoreID", t.Store.ID);

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
                    command.Parameters.AddWithValue("transactionTotal", t.Total);
                    command.Parameters.AddWithValue("transactionStoreID", t.Store.ID);

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
