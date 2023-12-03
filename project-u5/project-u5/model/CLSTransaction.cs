using System;

namespace project_u5.model
{
    public class CLSTransaction
    {
        // Propiedades
        public int ID { get; set; }
        public String Concept { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public String Type { get; set; }
        public String Notes { get; set; }
        public CLSCategory Category { get; set; }
        public CLSPlace Place { get; set; }

        // Constructor con parámetros
        public CLSTransaction(int id, String concept, DateTime date, Double amount, String type, String notes, CLSCategory category, CLSPlace place)
        {
            ID = id;
            Concept = concept;
            Date = date;
            Amount = amount;
            Type = type;
            Notes = notes;
            Category = category;
            Place = place;
        }

        // Constructor vacío
        public CLSTransaction()
        {
        }
    }
}
