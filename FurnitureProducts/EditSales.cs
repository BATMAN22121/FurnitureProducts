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
    public partial class EditSales : Form
    {
        public Order _order;
        public Furniture _furniture;

        public BindingList<Order> _orders;
        public DateTime _saleDate;
        public BindingList<Furniture> _furnitures;
        public decimal _quantitySold;

        public EditSales()
        {
            InitializeComponent();
            this.OrderIDSelect.DataSource = _orders;
            this.SaleDateInput.Value = DateTime.Now;
            this.FurnitureIDSelect.DataSource= _furnitures;
            this.QuantitySoldInput.Value = 0;
        }
        public void Clear()
        {

            this.QuantitySoldInput.Value = 0;
            this.SaleDateInput.Value= DateTime.Now;

        }
        public void Configure(Sales sales)
        {
            if (sales != null)
            {
                this.OrderIDSelect.SelectedIndex = this.OrderIDSelect.FindStringExact(sales.OrderID.Name);
                this.SaleDateInput.Value = (DateTime)sales.SaleDate;
                this.FurnitureIDSelect.SelectedIndex = this.FurnitureIDSelect.FindStringExact(sales.FurnitureID.Name);
                this.QuantitySoldInput.Value = (int)sales.QuantitySold;
            }

            this.OrderIDSelect.DataSource = _orders;
            this.FurnitureIDSelect.DataSource = _furnitures;
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            _order = this.OrderIDSelect.SelectedItem as Order;
            _saleDate = this.SaleDateInput.Value;
            _furniture = this.FurnitureIDSelect.SelectedItem as Furniture;
            _quantitySold = this.QuantitySoldInput.Value;


            this.DialogResult = DialogResult.OK;
        }
    }
}
