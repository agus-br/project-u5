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

namespace project_u5.view
{
    public partial class InsertUpdatePlaces : Form
    {
        public InsertUpdatePlaces()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]+") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]+)*"))
            {
                error.SetError(txtName, "Formato de nombre incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtCity.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]?)*"))
            {
                error.SetError(txtCity, "Formato de ciudad incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtCountry.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]?)*"))
            {
                error.SetError(txtCountry, "Formato de país incorrecto");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]+)*"))
            {
                error.SetError(txtName, "Formato de nombre incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtCity.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]?)*"))
            {
                error.SetError(txtCity, "Formato de ciudad incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtCountry.Text, "[A-Z][a-z]+([\\s][A-Z][a-z]?)*"))
            {
                error.SetError(txtCountry, "Formato de país incorrecto");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
