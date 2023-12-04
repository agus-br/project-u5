using System;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            new view.StoresCatalogue().ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            new view.frmAddTransaction().ShowDialog();
        }
    }
}
