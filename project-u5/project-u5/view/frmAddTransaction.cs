using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Media;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class frmAddTransaction : Form
    {

        private List<CLSStore> places;

        public frmAddTransaction()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            places = new StoreDAO().GetAll();
            cboStores.DataSource = places;
            cboStores.DisplayMember = "name";
            cboStores.SelectedItem = null;
        }

        private void txtConcept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && (int)e.KeyChar != (int)Keys.Back || txtYear.Text.Length > 4)
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && (int)e.KeyChar != (int)Keys.Back || txtDay.Text.Length > 2)
            {
                e.Handled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtConcept.Text, "[A-Z][a-z\\s]*"))
            {
                error.SetError(txtConcept, "Formato de concepto incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtYear.Text, "[0-9]+"))
            {
                error.SetError(txtYear, "Formato de año incorrecto");
                return;
            }
            if (cboMonth.SelectedItem == null)
            {
                error.SetError(cboMonth, "Por favor, selecciones un mes");
                return;
            }
            if (!Regex.IsMatch(txtDay.Text, "[0-9]+"))
            {
                error.SetError(txtDay, "Formato de día incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtTotal.Text, "[0-9]+(.)?[0-9]*"))
            {
                error.SetError(txtYear, "Formato de precio incorrecto");
                return;
            }
            if (cboStores.SelectedItem == null)
            {
                error.SetError(cboStores, "Por favor, seleccione una tienda");
                return;
            }
            int year = Convert.ToInt32(txtYear.Text);
            int day = Convert.ToInt32(txtDay.Text);
            if (year < 1900 || year > DateTime.Today.Year) {
                error.SetError(txtYear, "El año no es correcto");
                return;
            }
            if (day < 1 || day > 31)
            {
                error.SetError(txtYear, "El día no es correcto");
                return;
            }

            DateTime dt = DateTime.Parse(year + "-" + cboMonth.SelectedIndex.ToString() + "-" + day);
            CLSStore s = (CLSStore)cboStores.SelectedItem;
            CLSTransaction t = new CLSTransaction(0,
                txtConcept.Text.Trim(), dt, Convert.ToDouble(txtTotal.Text.Trim()), s);

            if (TransactionDAO.AddTransaction(t) != 0) MessageBox.Show("Transacción agregada");

        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9.]") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
    }
}
