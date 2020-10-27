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
    public partial class frmCustomerEdition : Form
    {
        public Customer _Customer { get; set; }

        public frmCustomerEdition()
        {
            InitializeComponent();
        }

        private void frmCustomerEdition_Load(object sender, EventArgs e)
        {
            MostraDatos();
        }

        public void MostraDatos()
        {
            if (isEdit())
            {
                txtFirstName.Text = this._Customer.FirstName;
                txtLastName.Text = this._Customer.LastName;
                txtCompany.Text = this._Customer.Company;
                txtAddress.Text = this._Customer.Address;
                txtCity.Text = this._Customer.City;
                txtState.Text = this._Customer.State;
                txtCountry.Text = this._Customer.Country;
                txtPostalCode.Text = this._Customer.PostalCode;
                txtPhone.Text = this._Customer.Phone;
                txtFax.Text = this._Customer.Fax;
                txtEmail.Text = this._Customer.Email;
            }
        }

        private bool isEdit()
        {
            return this._Customer != null;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var customerDA = new CustomerDA();

            var entity = new Customer();
            entity.FirstName = txtFirstName.Text.Trim();
            entity.LastName = txtLastName.Text.Trim();
            entity.Company = txtCompany.Text.Trim();
            entity.Address = txtAddress.Text.Trim();
            entity.City = txtCity.Text.Trim();
            entity.State = txtState.Text.Trim();
            entity.Country = txtCountry.Text.Trim();
            entity.PostalCode = txtPostalCode.Text.Trim();
            entity.Phone = txtPhone.Text.Trim();
            entity.Fax = txtFax.Text.Trim();
            entity.Email = txtEmail.Text.Trim();

            if (isEdit())
            {
                entity.CustomerId = this._Customer.CustomerId;
                customerDA.Update(entity);
            }
            else customerDA.Insert(entity);

            this.Close();
        }
    }
}
