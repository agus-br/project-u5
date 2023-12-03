using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace project_u5.data
{
    public class CategoryDAO
    {
        public static List<CLSCategory> GetAll()
        {
            List<CLSCategory> categories = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getAllCategories";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    categories = new List<CLSCategory>();
                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSCategory category = new CLSCategory(
                            Convert.ToInt32(fila["id"]),
                            fila["name"].ToString(),
                            fila["description"].ToString()
                            );
                        categories.Add(category);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return categories;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return categories;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return categories;
            }
        }

        public static int AddCategory(CLSCategory c)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "addCategory";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("categoryName", c.Name);
                    command.Parameters.AddWithValue("categoryDescription", c.Description);

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

        public static bool UpdateCategory(CLSCategory c)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "updateCategory";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("categoryID", c.ID);
                    command.Parameters.AddWithValue("categoryName", c.Name);
                    command.Parameters.AddWithValue("categoryDescription", c.Description);

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

        public static bool DeleteCategory(int categoryID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "deleteCategory";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("categoryID", categoryID);

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
