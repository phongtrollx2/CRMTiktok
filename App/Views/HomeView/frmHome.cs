using App.Views.CustomerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.HomeView
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ucCustomer ucCustomer = new ucCustomer();
            ucCustomer.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucCustomer);
        }

    }
}
