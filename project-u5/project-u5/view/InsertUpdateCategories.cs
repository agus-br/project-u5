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
    public partial class InsertUpdateCategories : Form
    {
        public InsertUpdateCategories()
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

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z0-9\\s]+") && (int)e.KeyChar != (int)Keys.Back)
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
            if(txtDescription.Text.Length == 0)
            {
                error.SetError(txtName, "Ingrese una descripción");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, "[A-Z]{1}[a-z]+([\\s][A-Z][a-z]+)*"))
            {
                error.SetError(txtName, "Formato de nombre incorrecto");
                return;
            }
            if (txtDescription.Text.Length == 0)
            {
                error.SetError(txtDescription, "Ingrese una descripción");
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
