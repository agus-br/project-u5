using MySql.Data.MySqlClient;
using project_u5.model;
using System;

namespace project_u5.data
{
    public class PlaceDAO
    {
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
