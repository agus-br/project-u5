using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_u5.view
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
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
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]+") && (int)e.KeyChar != (int)Keys.Back || txtYear.Text.Length > 3)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]+") && (int)e.KeyChar != (int)Keys.Back || txtDay.Text.Length > 0)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]+(.)?") && (int)e.KeyChar != (int)Keys.Back || txtAmount.Text.Length > 0)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtYearReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]+") && (int)e.KeyChar != (int)Keys.Back || txtYearReport.Text.Length > 3)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtConcept.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]+)*"))
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
                error.SetError(cboMonth, "Por favor selecciones un mes");
                return;
            }
            if (!Regex.IsMatch(txtDay.Text, "[0-9]+"))
            {
                error.SetError(txtDay, "Formato de día incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtAmount.Text, "[0-9]+(.)?[0-9]*"))
            {
                error.SetError(txtYear, "Formato de cantidad incorrecto");
                return;
            }
            if (cboType.SelectedItem == null)
            {
                error.SetError(cboType, "Por favor selecciones un mes");
                return;
            }
            if (txtNotes.Text.Length == 0)
            {
                error.SetError(txtNotes, "Ingrese una Nota");
                return;
            }
            if (cboCategories.SelectedItem == null)
            {
                error.SetError(cboCategories, "Por favor selecciones una categoría");
                return;
            }
            if (cboPlaces.SelectedItem == null)
            {
                error.SetError(cboPlaces, "Por favor selecciones un lugar");
                return;
            }
        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtYearReport.Text, "[0-9]+"))
            {
                error.SetError(txtYearReport, "Formato de año incorrecto");
                return;
            }
            if (cboMonthReport.SelectedItem == null)
            {
                error.SetError(cboMonthReport, "Por favor selecciones un mes");
                return;
            }
            new view.Report().ShowDialog();
        }

        private void btnReportCategory_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtYearReport.Text, "[0-9]+"))
            {
                error.SetError(txtYearReport, "Formato de año incorrecto");
                return;
            }
            if (cboMonthReport.SelectedItem == null)
            {
                error.SetError(cboMonthReport, "Por favor selecciones un mes");
                return;
            }
            if (cboCategoriesReport.SelectedItem == null)
            {
                error.SetError(cboCategoriesReport, "Por favor selecciones una categoría");
                return;
            }
            new view.Report().ShowDialog();
        }
    }
}
