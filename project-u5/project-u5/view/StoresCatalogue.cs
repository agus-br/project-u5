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
    public partial class StoresCatalogue : Form
    {
        public StoresCatalogue()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            new view.InsertUpdateStore().ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new view.InsertUpdateStore().ShowDialog();
        }
    }
}
