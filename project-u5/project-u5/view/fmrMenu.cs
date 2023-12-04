using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            new view.Categories().ShowDialog();
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            new view.Places().ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            new view.Transactions().ShowDialog();
        }
    }
}
