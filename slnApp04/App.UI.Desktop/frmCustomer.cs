using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var customer = new CustomerDA();
            lblCount.Text = customer.Count().ToString();
            lblCount.Visible = true;

            dgvListado.DataSource = customer.Gets(txtFilterByNmae.Text.Trim());
            dgvListado.Refresh();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomerEdition();
            frm.ShowDialog();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var customer = (Customer)dgvListado.Rows[e.RowIndex].DataBoundItem;
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (Customer)dgvListado.Rows[e.RowIndex].DataBoundItem;

            var frm = new frmCustomerEdition();
            frm._Customer = customer;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var customer = new CustomerDA();
            //customer.Delete();
        }
    }
}
