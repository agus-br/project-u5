using project_u5.data;
using project_u5.model;
using System;
using System.Windows.Forms;

namespace project_u5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /* INSERTION TEST
            CLSCategory c = new CLSCategory("Categoria nueva", "Es solo un test");
            c.ID = CategoryDAO.AddCategory(c);
            if (c.ID != 0) MessageBox.Show("Categoria creada");

            CLSPlace p = new CLSPlace("Lugar nuevo", "YURRR", "Mexiso");
            p.ID = PlaceDAO.AddPlace(p);
            if(p.ID != 0) MessageBox.Show("Place creada");

            CLSTransaction t = new CLSTransaction("Transaccion nueva", DateTime.Now, 25.25, "Ingreso", "Es solo un test", c, p);
            if(TransactionDAO.AddTransaction(t) != 0) MessageBox.Show("Transacccion creada");
            */

            /*UPDATING TEST
            CLSCategory c = new CLSCategory("Categoria nueva", "Es solo un test");
            c.ID = 3;
            c.Name = "Updating test Category";
            c.Description = "Updating new description";
            if (CategoryDAO.UpdateCategory(c)) MessageBox.Show("Categoria Actualizada");
             
            CLSPlace p = new CLSPlace("Lugar nuevo", "YURRR", "Mexiso");
            p.ID = 1;
            p.Name = "Updating Test Place";
            p.City = "Updating City";
            if(PlaceDAO.UpdatePlace(p)) MessageBox.Show("Lugar Actualizado");

            CLSCategory c = new CLSCategory("Categoria nueva", "Es solo un test");
            c.ID = 3;
            CLSPlace p = new CLSPlace("Lugar nuevo", "YURRR", "Mexiso");
            p.ID = 1;
            CLSTransaction t = new CLSTransaction("Transaccion nueva", DateTime.Now, 25.25, "Ingreso", "Es solo un test", c, p);
            t.ID = 3;
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
