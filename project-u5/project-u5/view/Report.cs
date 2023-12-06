using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class Report : Form
    {
        List<CLSTransaction> transactions;

        public Report()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData(false);
        }

        private void LoadData(bool bydate)
        {
            if (!bydate) transactions = TransactionDAO.GetAll();
            dgvReports.DataSource = transactions;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToOrderColumns = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvReports.Columns["id"].Visible = false;
            dgvReports.Columns["Store"].Visible = false;
            dgvReports.Columns["StoreName"].HeaderText = "Tienda";
            dgvReports.Columns["concept"].HeaderText = "Concepto";
            dgvReports.Columns["date"].HeaderText = "Fecha";
            dgvReports.Columns["total"].HeaderText = "Total";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            if (txtYear.Text == String.Empty) {
                LoadData(false);
                return;
            }
            year = Convert.ToInt32(txtYear.Text);

            if (cboMonth.SelectedItem == null)
            {
                month = -1;
            }
            else { 
                month = cboMonth.SelectedIndex + 1;
            }

            transactions = TransactionDAO.GetAllTransactionsByDate(year, month);
            LoadData(true);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && (int)e.KeyChar != (int)Keys.Back || txtYear.Text.Length > 4)
            {
                e.Handled = true;
            }
            error.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAddUpdateTransaction form = new frmAddUpdateTransaction(null);
            form.FormClosed += new FormClosedEventHandler(AddUpdateFormClosed);
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0) {
                int index = dgvReports.CurrentRow.Index;

                CLSTransaction t = transactions[index];

                frmAddUpdateTransaction form = new frmAddUpdateTransaction(t);
                form.FormClosed += new FormClosedEventHandler(AddUpdateFormClosed);
                form.ShowDialog();
            }
            else {
                MessageBox.Show("Seleccione un registro.");
            }
            
        }

        private void AddUpdateFormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                int index = dgvReports.CurrentRow.Index;

                CLSTransaction t = transactions[index];
                if (TransactionDAO.DeleteTransaction(t.ID)) MessageBox.Show("Se elímino el registro");
                LoadData(false);
            }
            else
            {
                MessageBox.Show("Seleccione un registro.");
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
