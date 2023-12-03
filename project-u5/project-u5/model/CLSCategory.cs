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
        public CLSCategory(String name, String description)
        {
            Name = name;
            Description = description;
        }

        // Constructor vacío
        public CLSCategory()
        {
        }
    }
}
