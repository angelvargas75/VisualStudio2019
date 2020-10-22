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
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private void frmArtist_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
            lblCount.Text = da.Count().ToString();
            lblCount.Visible = true;

            dgvListado.DataSource = da.Gets(txtFilterByNmae.Text.Trim());
            dgvListado.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmArtistEdition();
            frm.ShowDialog();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var artist = (Artist)dgvListado.Rows[e.RowIndex].DataBoundItem;

            var frm = new frmArtistEdition();
            frm._Artist = artist;
            frm.ShowDialog();
        }
    }
}
