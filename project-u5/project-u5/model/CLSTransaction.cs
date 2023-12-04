using System;

namespace project_u5.model
{
    public class CLSTransaction
    {
        // Propiedades
        public int ID { get; set; }
        public String Concept { get; set; }
        public DateTime Date { get; set; }
        public Double Total { get; set; }
        public CLSStore Store { get; set; }

        // Constructor con parámetros
        public CLSTransaction(int id, String concept, DateTime date, Double total, CLSStore place)
        {
            ID = id;
            Concept = concept;
            Date = date;
            Total = total;
            Store = place;
        }

        // Constructor vacío
        public CLSTransaction()
        {
        }
    }
}
