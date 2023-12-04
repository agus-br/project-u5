using System;

namespace project_u5.model
{
    public class CLSStore
    {
        // Propiedades
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Contact { get; set; }

        // Constructor con parámetros
        public CLSStore(int id, String name, String city, String country)
        {
            ID = id;
            Name = name;
            Address = city;
            Contact = country;
        }

        // Constructor vacío
        public CLSStore()
        {
        }
    }
}
