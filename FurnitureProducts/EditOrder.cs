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
    public partial class EditOrder : Form
    {
        public DateTime _orderDate = DateTime.Now;
        public string _customerName = "";
        //public decimal _totalAmount = 0;
        public EditOrder()
        {
            InitializeComponent();
        }
        public void Clear()
        {

            this.CustomerNameInput.Text = "";
            this.OrderDateInput.Text = "";
           // this.TotalAmountInput.Value = 0;
        }
        public void Configure(Order order)
        {
            if (order != null)
            {
                this.CustomerNameInput.Text = order.Name;
                this.OrderDateInput.Value = (DateTime)order.OrderDate;
                //this.TotalAmountInput.Value = (decimal)order.TotalAmount;
            }
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            _customerName = this.CustomerNameInput.Text;
            _orderDate = this.OrderDateInput.Value;
           //_totalAmount = this.TotalAmountInput.Value;

            this.DialogResult = DialogResult.OK;
        }
    }
}
