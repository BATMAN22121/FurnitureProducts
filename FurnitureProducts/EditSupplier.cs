using FurnitureItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalRawMaterials
{
    public partial class EditSupplier : Form
    {
        public string _supplierName = "";
        public string _suppliercontactPerson = "";
        public string _supplierPhone = "";
        public string _supplieremail = "";
        public string _supplierAddress = "";
        public EditSupplier()
        {
            InitializeComponent();
        }
        public void Clear()
        {

            this.NameInput.Text = "";
            this.AddressInput.Text = "";
            this.PhoneInput.Text = "";
            this.ContactPersonInput.Text = "";
            this.EmailInput.Text = "";
        }
        public void Configure(Supplier supplier)
        {
            if (supplier != null)
            {
                this.NameInput.Text = supplier.Name;
                this.AddressInput.Text = supplier.Adress;
                this.PhoneInput.Text = supplier.Phone;
                this.ContactPersonInput.Text = supplier.ContactPerson;
                this.EmailInput.Text = supplier.Email;
            }
        }

        private void saveSupplier_Click(object sender, EventArgs e)
        {
            _supplierName = this.NameInput.Text;
            _supplierAddress = this.AddressInput.Text;
            _supplierPhone = this.PhoneInput.Text;
            _suppliercontactPerson = this.ContactPersonInput.Text;
            _supplieremail = this.EmailInput.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
