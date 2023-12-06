using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class StoresCatalogue : Form
    {
        public static List<CLSStore> stores;
        public StoresCatalogue()
        {
            InitializeComponent();
            //stores = StoreDAO.GetAll();

            //dgvStores.DataSource = stores;
            //dgvStores.AllowUserToAddRows = false;
            //dgvStores.AllowUserToDeleteRows = false;
            //dgvStores.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dgvStores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dgvStores.Columns["id"].Visible = false;
            //dgvStores.Columns["name"].HeaderText = "Nombre";
            //dgvStores.Columns["address"].HeaderText = "Dirección";
            //dgvStores.Columns["contact"].HeaderText = "Contacto";
            this.StartPosition = FormStartPosition.CenterScreen;
            LlenarTabla();
        }
        private void LlenarTabla()
        {
            stores = StoreDAO.GetAll();

            dgvStores.DataSource = stores;
            dgvStores.AllowUserToAddRows = false;
            dgvStores.AllowUserToDeleteRows = false;
            dgvStores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvStores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvStores.Columns["id"].Visible = false;
            dgvStores.Columns["name"].HeaderText = "Nombre";
            dgvStores.Columns["address"].HeaderText = "Dirección";
            dgvStores.Columns["contact"].HeaderText = "Contacto";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void insertUpdateFormClosed(object sender, FormClosedEventArgs e)
        {
            LlenarTabla();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertUpdateStore insertUpdate = new view.InsertUpdateStore(null);
            insertUpdate.FormClosed += new FormClosedEventHandler(insertUpdateFormClosed);
            insertUpdate.ShowDialog();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStores.SelectedRows.Count > 0)
            {
                int index = dgvStores.CurrentRow.Index;
                CLSStore cS = stores[index];


                InsertUpdateStore insertUpdate = new view.InsertUpdateStore(cS);
                insertUpdate.FormClosed += new FormClosedEventHandler(insertUpdateFormClosed);
                insertUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione la tienda que desea editar");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStores.SelectedRows.Count > 0)
            {
                int index = dgvStores.CurrentRow.Index;
                
                CLSStore cS = stores[index];
                int codigo = StoreDAO.DeleteStore(cS.ID);
                if (codigo == 1) MessageBox.Show("Se elimino la tienda");
                else if(codigo == 1451) MessageBox.Show("Error en eliminar: " + cS.Name + ". Conflicto de referencia");
                LlenarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione la tienda que desea editar");
            }
        }
    }
}
