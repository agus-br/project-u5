using project_u5.data;
using project_u5.model;
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
    public partial class InsertUpdateStore : Form
    {

        CLSStore store;
        public InsertUpdateStore(CLSStore cS)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.store = cS;
            if (cS != null)
            {
                txtName.Text = store.Name;
                txtAddress.Text = store.Address;
                txtContact.Text = store.Contact;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z\\s]") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z.#\\s]") && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[A-Za-z0-9.\\s]") && (int)e.KeyChar != (int)Keys.Back)
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
            if (!Regex.IsMatch(txtAddress.Text, "[A-Za-z0-9#.]+([\\s][A-Za-z0-9#.]+)*"))
            {
                error.SetError(txtAddress, "Formato de ciudad incorrecto");
                return;
            }
            if (!Regex.IsMatch(txtContact.Text, "[A-Za-z0-9.]+([\\s][A-Za-z0-9.]+)*"))
            {
                error.SetError(txtContact, "Formato de país incorrecto");
                return;
            }
            if(store == null)
            {
                store = new CLSStore(0, txtName.Text, txtAddress.Text, txtContact.Text);
                if (StoreDAO.AddStore(store) != 0) MessageBox.Show("Se insertó un tienda nueva");
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                store = null;
                return;
            }
            else
            {
                store = new CLSStore(store.ID, txtName.Text, txtAddress.Text, txtContact.Text);
                if (StoreDAO.UpdateStore(store)) MessageBox.Show("Se modificó la tienda: " + store.Name); 
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
