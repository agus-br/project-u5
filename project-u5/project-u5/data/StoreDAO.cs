using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_u5.data
{
    public class StoreDAO
    {
        public static List<CLSStore> GetAll()
        {
            List<CLSStore> stores = new List<CLSStore>();
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getAllStore";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.CommandText = sentence;
                    //command.Connection = Connection.CurrentConnection;
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    stores = new List<CLSStore>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSStore store = new CLSStore(
                            Convert.ToInt32(fila["id"]),
                            fila["name"].ToString(),
                            fila["address"].ToString(),
                            fila["contact"].ToString()
                            );
                        stores.Add(store);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return stores;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("aqui");
                    //trans.Rollback();
                    return stores;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return stores;
            }
        }

        public static CLSStore Get(int storeID)
        {
            CLSStore store = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getStore";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("storeID", storeID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        store = new CLSStore(
                            Convert.ToInt32(fila["id"]),
                            fila["name"].ToString(),
                            fila["address"].ToString(),
                            fila["contact"].ToString()
                            );
                    }
                    command.Dispose();
                    //trans.Commit();
                    return store;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return store;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return store;
            }
        }

        public static int AddStore(CLSStore s)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "addStore";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("StoreName", s.Name);
                    command.Parameters.AddWithValue("StoreAddress", s.Address);
                    command.Parameters.AddWithValue("StoreContact", s.Contact);

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

        public static bool UpdateStore(CLSStore s)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "updateStore";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("storeID", s.ID);
                    command.Parameters.AddWithValue("storeName", s.Name);
                    command.Parameters.AddWithValue("storeAddress", s.Address);
                    command.Parameters.AddWithValue("storeContact", s.Contact);

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

        public static int DeleteStore(int storeID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "deleteStore";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("storeID", storeID);

                    command.ExecuteNonQuery();
                    command.Dispose();
                    trans.Commit();

                    return 1;
                }
                catch (MySqlException e)
                {
                    trans.Rollback();
                    return e.Number;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return -1; 
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return -2;
            }
        }

    }
}
