using System;

namespace project_u5.model
{
    public class CLSPlace
    {
        // Propiedades
        public int ID { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

        // Constructor con parámetros
        public CLSPlace(int id, String name, String city, String country)
        {
            ID = id;
            Name = name;
            City = city;
            Country = country;
        }

        // Constructor vacío
        public CLSPlace()
        {
        }
    }
}
