using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project_u5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /* GETTING TEST
            List<CLSPlace> places = PlaceDAO.GetAll();
            List<CLSCategory> categories = CategoryDAO.GetAll();
            List<CLSTransaction> transactions = TransactionDAO.GetAll();

            foreach (CLSPlace item in places)
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.City);
            }
            foreach (CLSCategory item in categories)
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.Description);
            }
            foreach (CLSTransaction item in transactions)
            {
                Console.WriteLine(item.ID + " " + item.Concept + " " + item.Amount + " " + item.Category.ID + " " + item.Place.ID);
            }
            */


            /* INSERTION TEST
            CLSCategory c = new CLSCategory(0,"Categoria nueva", "Es solo un test");
            c.ID = CategoryDAO.AddCategory(c);
            //if (c.ID != 0) MessageBox.Show("Categoria creada");

            CLSPlace p = new CLSPlace(0, "Lugar nuevo", "YURRR", "Mexiso");
            p.ID = PlaceDAO.AddPlace(p);
            //if(p.ID != 0) MessageBox.Show("Place creada");

            CLSTransaction t = new CLSTransaction(0,"Transaccion nueva", DateTime.Now, 25.25, "Ingreso", "Es solo un test", c, p);
            t.ID = TransactionDAO.AddTransaction(t);
            //if (t.ID != 0) MessageBox.Show("Transacccion creada");
            */

            /*UPDATING TEST
            CLSCategory c = new CLSCategory(3, "Categoria nueva", "Es solo un test");
            c.Name = "Updating test Category";
            c.Description = "Updating new description";
            if (CategoryDAO.UpdateCategory(c)) MessageBox.Show("Categoria Actualizada");
             
            CLSPlace p = new CLSPlace(1, "Lugar nuevo", "YURRR", "Mexiso");
            p.Name = "Updating Test Place";
            p.City = "Updating City";
            if(PlaceDAO.UpdatePlace(p)) MessageBox.Show("Lugar Actualizado");

            CLSCategory c = new CLSCategory(3, "Categoria nueva", "Es solo un test");
            CLSPlace p = new CLSPlace(1, "Lugar nuevo", "YURRR", "Mexiso");
            CLSTransaction t = new CLSTransaction(3, "Transaccion nueva", DateTime.Now, 25.25, "Ingreso", "Es solo un test", c, p);
            t.Concept = "Updating Transaction";
            t.Amount = 50.45;
            t.Type = "Gasto";
            t.Notes = "Updating test";
            if (TransactionDAO.UpdateTransaction(t)) MessageBox.Show("Transacccion Actualizada");
            */


            /*DELETE TEST
            int categorID = 1;
            //if (CategoryDAO.DeleteCategory(categorID)) MessageBox.Show("Categoria Eliminada");
             
            int placeID = 1;
            //if(PlaceDAO.DeletePlace(placeID)) MessageBox.Show("Lugar Eliminado");

            int transactionID = 1;
            if (TransactionDAO.DeleteTransaction(transactionID)) MessageBox.Show("Transacccion Eliminada");
            */

        }
    }
}
