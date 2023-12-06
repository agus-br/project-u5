using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Media;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_u5.view
{
    public partial class frmAddUpdateTransaction : Form
    {

        private List<CLSStore> stores;
        CLSTransaction transaction;

        public frmAddUpdateTransaction(CLSTransaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
            
        }

        private void LoadData()
        {
            stores = StoreDAO.GetAll();
            cboStores.DataSource = stores;
            cboStores.DisplayMember = "name";
            cboStores.SelectedItem = null;
            if (transaction != null)
            {
                txtConcept.Text = transaction.Concept;
                txtYear.Text = transaction.Date.Year.ToString();
                cboMonth.SelectedIndex = transaction.Date.Month - 1;
                txtDay.Text = transaction.Date.Day.ToString();
                txtTotal.Text = transaction.Total.ToString();
                
                stores = StoreDAO.GetAll();
                cboStores.DataSource = stores;
                cboStores.DisplayMember = "name";
                foreach (CLSStore cLSStore in stores)
                {
                    if (cLSStore.ID == transaction.Store.ID)
                    {
                        cboStores.SelectedItem = cLSStore;
                    }
                }
                return;
            }
            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }



       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtConcept.Text, "[\\w]+([\\s][\\w]+)*"))
            {
                error.SetError(txtConcept, "Formato de concepto incorrecto");
                return;
            }
            if (cboMonth.SelectedItem == null)
            {
                error.SetError(cboMonth, "Por favor, selecciones un mes");
                return;
            }
            if (!Regex.IsMatch(txtTotal.Text, "[0-9]+((.)[0-9]+)?"))
            {
                error.SetError(txtTotal, "Formato de precio incorrecto");
                return;
            }
            if (cboStores.SelectedItem == null)
            {
                error.SetError(cboStores, "Por favor, seleccione una tienda");
                return;
            }

            int year = Convert.ToInt32(txtYear.Text);
            int day = Convert.ToInt32(txtDay.Text);
            if (year < 1900 || year > DateTime.Today.Year)
            {
                error.SetError(txtYear, "El año no es correcto");
                return;
            }
            if (day < 1 || day > 31)
            {
                error.SetError(txtYear, "El día no es correcto");
                return;
            }

            DateTime dt = DateTime.Parse(year + "-" + (cboMonth.SelectedIndex+1).ToString() + "-" + day);
            CLSStore s = (CLSStore)cboStores.SelectedItem;
            if (transaction == null)
            {
                CLSTransaction t = new CLSTransaction(0,
                txtConcept.Text.Trim(), dt, Convert.ToDouble(txtTotal.Text.Trim()), s);
                if (TransactionDAO.AddTransaction(t) != 0) MessageBox.Show("Transacción agregada");
                transaction = null;
                txtConcept.Text = "";
                txtYear.Text = "";
                cboMonth.SelectedItem = null;
                txtDay.Text = "";
                txtTotal.Text = "";
                cboStores.SelectedItem = null;
            }
            else
            {
                transaction = new CLSTransaction(transaction.ID, txtConcept.Text.Trim(), dt, Convert.ToDouble(txtTotal.Text.Trim()), s);
                if (TransactionDAO.UpdateTransaction(transaction)) MessageBox.Show("Transacción modificada");
            }
        }

        private void txtTotal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9.]") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtConcept_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtYear_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && (int)e.KeyChar != (int)Keys.Back || txtYear.Text.Length > 4)
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && (int)e.KeyChar != (int)Keys.Back || txtDay.Text.Length > 2)
            {
                e.Handled = true;
            }
        }
    }
}
