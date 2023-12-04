using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace project_u5.data
{
    public class PlaceDAO
    {
        public static List<CLSPlace> GetAll()
        {
            List<CLSPlace> places = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getAllPlaces";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    places = new List<CLSPlace>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSPlace place = new CLSPlace(
                            Convert.ToInt32(fila["id"]),
                            fila["name"].ToString(),
                            fila["city"].ToString(),
                            fila["country"].ToString()
                            );
                        places.Add(place);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return places;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return places;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return places;
            }
        }

        public static CLSPlace Get(int placeID)
        {
            CLSPlace place = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "getPlace";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("placeID", placeID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        place = new CLSPlace(
                            Convert.ToInt32(fila["id"]),
                            fila["name"].ToString(),
                            fila["city"].ToString(),
                            fila["country"].ToString()
                            );
                    }
                    command.Dispose();
                    //trans.Commit();
                    return place;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return place;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return place;
            }
        }

        public static int AddPlace(CLSPlace p)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "addPlace";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("placeName", p.Name);
                    command.Parameters.AddWithValue("placeCity", p.City);
                    command.Parameters.AddWithValue("placeCountry", p.Country);

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

        public static bool UpdatePlace(CLSPlace p)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "updatePlace";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("placeID", p.ID);
                    command.Parameters.AddWithValue("placeName", p.Name);
                    command.Parameters.AddWithValue("placeCity", p.City);
                    command.Parameters.AddWithValue("placeCountry", p.Country);

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

        public static bool DeletePlace(int placeID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "deletePlace";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("placeID", placeID);

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
