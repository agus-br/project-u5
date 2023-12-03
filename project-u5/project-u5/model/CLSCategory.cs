using System;

namespace project_u5.model
{
    public class CLSCategory
    {
        // Propiedades
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        // Constructor con parámetros
        public CLSCategory(int id, String name, String description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        // Constructor vacío
        public CLSCategory()
        {
        }
    }
}
