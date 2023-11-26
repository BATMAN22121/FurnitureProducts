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

namespace FurnitureProducts
{
    public partial class EditFurniture : Form
    {

        public string _name = "";
        public string _category = "";
        public decimal _price = 0;
        public int _stockQuantity = 0;
        public string _description = "";
        public DateTime _manufactureDate;
        public Supplier _supplier;
        public BindingList<Supplier> _suppliers;
        public EditFurniture()
        {
            InitializeComponent();
            this.SupplierSelect.DataSource = _suppliers;
            this.ManufactureDateInput.Value = DateTime.Now;
            this.NameInput.Text = "";
            this.CategoryInput.Text = "";
            this.DescriptionInput.Text = "";
            this.PriceInput.Value = 0;
            this.StockQuantityInput.Value = 0;
        }
        public void Clear()
        {

            this.NameInput.Text = "";
            this.CategoryInput.Text = "";
            this.DescriptionInput.Text = "";
            this.ManufactureDateInput.Value = DateTime.Now;
            this.PriceInput.Value = 0;
            this.StockQuantityInput.Value = 0;
        }
        public void Configure(Furniture furniture)
        {
            if (furniture != null)
            {
                this.SupplierSelect.SelectedIndex = this.SupplierSelect.FindStringExact(furniture.SupplierID.Name);
                this.NameInput.Text = furniture.Name;
                this.CategoryInput.Text = furniture.Category;
                this.PriceInput.Value = (decimal)furniture.Price;
                this.StockQuantityInput.Value = (int)furniture.StockQuantity;
                this.DescriptionInput.Text = furniture.Description;
                this.ManufactureDateInput.Value = (DateTime)furniture.ManufactureDate;
            }

            this.SupplierSelect.DataSource = _suppliers;
        }

        private void EditFurniture_Load(object sender, EventArgs e)
        {


        }

        private void saveFurniture_Click(object sender, EventArgs e)
        {
            _name = this.NameInput.Text;
            _category = this.CategoryInput.Text;
            _price = this.PriceInput.Value;
            _stockQuantity = (int)this.StockQuantityInput.Value;
            _description = this.DescriptionInput.Text;
            _manufactureDate = this.ManufactureDateInput.Value;
            _supplier = this.SupplierSelect.SelectedItem as Supplier;

            this.DialogResult = DialogResult.OK;
        }
    }
}
