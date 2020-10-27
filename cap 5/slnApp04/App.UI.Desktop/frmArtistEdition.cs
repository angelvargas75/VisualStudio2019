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
    public partial class frmArtistEdition : Form
    {
        public Artist _Artist { get; set; }
        public frmArtistEdition()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            if (isEdit())
            {
                var artistDA = new ArtistDA();
                var artistInfo = artistDA.Get(this._Artist.ArtistId);


                txtNombre.Text = this._Artist.Name;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var artistDA = new ArtistDA();

            var entity = new Artist();
            entity.Name = txtNombre.Text.Trim();

            if (isEdit())
            {
                entity.ArtistId = this._Artist.ArtistId;
                artistDA.Update(entity);
            }
            else artistDA.Insert(entity);

            this.Close();
        }

        private bool isEdit()
        {
            return this._Artist != null;
        }

        private void frmArtistEdicion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
