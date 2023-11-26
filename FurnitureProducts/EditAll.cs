
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using СollegeActivity;
using FurnitureItem;
using FurnitureItem.Repository;
using MedicalRawMaterials;
using FurnitureProducts;
using System.Windows.Controls;
using Microsoft.VisualBasic;

namespace FurnitureI
{
    public partial class EditAll : Form
    {
        private Edit _baseEditForm = new Edit();
        private EditSupplier _editSupplier = new EditSupplier();
        private EditSales _editSales = new EditSales();
        private EditOrder _editOrder = new EditOrder();
        private EditFurniture _editFurniture = new EditFurniture();

        public BindingList<Supplier> _suppliers = new BindingList<Supplier>();
        public BindingList<Order> _orderss = new BindingList<Order>();
        public BindingList<Furniture> _furnituress = new BindingList<Furniture>();
        public BindingList<Sales> _saless = new BindingList<Sales>();

        public SupplierRepository _supplierRepository;
        public FurnitureRepository _furnitureRepository;
        public OrdersRepository _ordersRepository;
        public SalesRepository _salesRepository;


        private Dictionary<string, int> orderSearchKeys = new Dictionary<string, int>
            {
                { "Имя клиента", 0 },
                { "Дата заказа", 1 },
                { "Общая сумма", 2 },
            };        
        private Dictionary<string, int> furnitureSearchKeys = new Dictionary<string, int>
            {
                { "Название мебели", 0 },
                { "Категория", 1 },
                { "Цена", 2 },
                { "Количество на складе", 3 },
                { "Описание", 4 },
                { "Дата производства ", 5 },
                { "Поставщик", 6 },
            };        
        private Dictionary<string, int> salesSearchKeys = new Dictionary<string, int>
            {
                { "Имя заказчика", 0 },
                { "Дата продажи", 1 },
                { "Название мебели", 2 },
            };
           

        private Dictionary<string, int> supplierSearchKeys = new Dictionary<string, int>
            {
                { "Название поставщика", 0 },
                { "Контактное лицо", 1 },
                { "Телефон", 2 },
                { "Почта", 3 },
                { "Адрес", 4 },
            };        

        public EditAll()
        {
            InitializeComponent();
            var connectionString = "Server=.\\SQLEXPRESS;Database=FurnitureStore;Trusted_Connection=True;";
            _supplierRepository = new SupplierRepository(connectionString);
            _ordersRepository = new OrdersRepository(connectionString);
            _furnitureRepository = new FurnitureRepository(connectionString, _supplierRepository);
            _salesRepository = new SalesRepository(connectionString, _ordersRepository, _furnitureRepository);

            var supplierList = _supplierRepository.Select();           
            var orderList = _ordersRepository.Select();
            var furnitureList = _furnitureRepository.Select();
            var salesList = _salesRepository.Select();

            _suppliers = new BindingList<Supplier>(supplierList);
            _orderss = new BindingList<Order>(orderList);
            _furnituress = new BindingList<Furniture>(furnitureList);
            _saless = new BindingList<Sales>(salesList);
            //_saless = new BindingList<Sales>(salesList);


            _editFurniture._suppliers = _suppliers;
            _editSales._furnitures = _furnituress;
            _editSales._orders = _orderss;

            

            this.OrderTable.DataSource = _orderss;
            this.OrderTable.Columns[2].Visible = false;            
            
            

            this.SalesTable.DataSource = _saless;
            this.SalesTable.Columns[4].Visible = false;

            this.SupplierTable.DataSource = _suppliers;
            this.SupplierTable.Columns[5].Visible = false;            

            this.FurnitureTable.DataSource = _furnituress;
            this.FurnitureTable.Columns[7].Visible = false;


            foreach (var item in orderSearchKeys)
            {
                ComboSearchOrder.Items.Add(item);
            }
            ComboSearchOrder.SelectedIndex = 0;
            ComboSearchOrder.ComboBox.DisplayMember = "Key";



            foreach (var item in salesSearchKeys)
            {
                ComboSearchSales.Items.Add(item);
            }
            ComboSearchSales.SelectedIndex = 0;
            ComboSearchSales.ComboBox.DisplayMember = "Key";

            foreach (var item in supplierSearchKeys)
            {
                ComboSearchSupplier.Items.Add(item);
            }
            ComboSearchSupplier.SelectedIndex = 0;
            ComboSearchSupplier.ComboBox.DisplayMember = "Key";

            foreach (var item in furnitureSearchKeys)
            {
                ComboSearchFurniture.Items.Add(item);
            }
            ComboSearchFurniture.SelectedIndex = 0;
            ComboSearchFurniture.ComboBox.DisplayMember = "Key";


        }

        private static void Search(ToolStripComboBox searchKinds, DataGridView table, ToolStripTextBox searchItem)
        {
            table.CurrentCell = null;
            var searchText = searchItem.Text.ToLower();
            if (searchText == string.Empty)
            {
                foreach (DataGridViewRow row in table.Rows)
                    row.Visible = true;
                return;
            }

            var searchItemIndex = ((KeyValuePair<string, int>)searchKinds.SelectedItem).Value;

            foreach (DataGridViewRow row in table.Rows)
            {
                var text = row.Cells[searchItemIndex].Value.ToString().ToLower();
                if (text.Contains(searchText))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private DialogResult AddNewBase(string propertyName, string value = "")
        {
            _baseEditForm.Text = propertyName;
            _baseEditForm._editName = value;
            return _baseEditForm.ShowDialog();
        }



        private void addSupplier_Click(object sender, EventArgs e)
        {
            _editSupplier.Clear();
            _editSupplier.Configure(null);
            if (_editSupplier.ShowDialog() == DialogResult.OK)
            {
                if (_editSupplier._supplierName == string.Empty ||
                _editSupplier._supplierPhone == string.Empty ||
                _editSupplier._supplierAddress == string.Empty ||
                _editSupplier._supplieremail == string.Empty ||
                _editSupplier._suppliercontactPerson == string.Empty
                ) { MessageBox.Show("Не введено значение!"); return; };

                var item = new Supplier
                {
                    Id = _suppliers.Count,
                    Name = _editSupplier._supplierName,
                    Adress = _editSupplier._supplierAddress,
                    Phone = _editSupplier._supplierPhone,
                    ContactPerson = _editSupplier._suppliercontactPerson,
                    Email = _editSupplier._supplieremail
                };

                var id = _supplierRepository.Insert(item);
                item.Id = id;
                _suppliers.Add(item);
            }
        }


        private void editGroup_Click(object sender, EventArgs e)
        {
  
        }





        private void EditMedicalRawMaterial_Click(object sender, EventArgs e)
        {
            
        }




        private void deleteGroup_Click(object sender, EventArgs e)
        {
            
        }


        private void deleteShipment_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteSupplier_Click(object sender, EventArgs e)
        {
            if (this.SupplierTable.SelectedRows.Count == 1)
            {
                var supplier = (Supplier)this.SupplierTable.SelectedRows[0].DataBoundItem;

                var delSupplier = _furnituress.Where(x => x.SupplierID?.Id == supplier.Id);
                if (delSupplier == null || delSupplier.Count() == 0)
                {
                    _supplierRepository.Delete(supplier.Id.Value);
                    _suppliers.Remove(supplier);
                }
                else MessageBox.Show("Ошибка! Такого поставщика нельзя удалить!!");
            }
        }


       

        private void DeleteMedicalRawMaterial_Click(object sender, EventArgs e)
        {
            
        }



        private void searchSupplier_TextChanged(object sender, EventArgs e)
        {
            Search(ComboSearchSupplier, SupplierTable, searchSupplier);
        }

        private void searchMedicalRawMaterial_TextChanged(object sender, EventArgs e)
        {
            Search(ComboSearchFurniture, FurnitureTable, searchFurniture);
        }

        private void searchShipment_TextChanged(object sender, EventArgs e)
        {
            Search(ComboSearchSales, SalesTable, searchSales);
        }

        private void searchGroup_TextChanged(object sender, EventArgs e)
        {
            Search(ComboSearchOrder, OrderTable, searchOrder);
        }


        private void addFurniture_Click(object sender, EventArgs e)
        {
            _editFurniture.Clear();
            _editFurniture.Configure(null);
            if (_editFurniture.ShowDialog() == DialogResult.OK)
            {
                if (_editFurniture._category == string.Empty ||
                    _editFurniture._description == string.Empty ||
                    _editFurniture._price == 0 ||
                    _editFurniture._stockQuantity == 0 ||
                    _editFurniture._name == string.Empty 
                ) { MessageBox.Show("Не введено значение!"); return; };

                var item = new Furniture
                {
                    Name = _editFurniture._name,
                    Category = _editFurniture._category,
                    Description = _editFurniture._description,
                    Price = _editFurniture._price,
                    StockQuantity = _editFurniture._stockQuantity,
                    ManufactureDate = _editFurniture._manufactureDate,
                    SupplierID = _editFurniture._supplier

                };
                var id = _furnitureRepository.Insert(item);
                item.Id = id;
                _furnituress.Add(item);
            }
        }

        private void addSales_Click(object sender, EventArgs e)
        {
            _editSales.Clear();
            _editSales.Configure(null);
            if (_editSales.ShowDialog() == DialogResult.OK)
            {
                if (_editSales._quantitySold == 0) { MessageBox.Show("Не введено значение!"); return; };

                var item = new Sales
                {
                    Id = _saless.Count,
                    FurnitureID = _editSales._furniture,
                    SaleDate = _editSales._saleDate,
                    OrderID = _editSales._order,
                    QuantitySold = (int?)_editSales._quantitySold
                };

                var fur = _furnituress.FirstOrDefault(x => x.Id == item.FurnitureID.Id);
                fur.StockQuantity -= item.QuantitySold;
                if (fur.StockQuantity < 0) { MessageBox.Show("недостаточное количество на складе!"); return; };
                _furnitureRepository.Update(fur);

                var id = _salesRepository.Insert(item);




                item.Id = id;
                _saless.Add(item);
            }
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            _editOrder.Clear();
            _editOrder.Configure(null);
            if (_editOrder.ShowDialog() == DialogResult.OK)
            {
                if (_editOrder._customerName == string.Empty) { MessageBox.Show("Не введено значение!"); return; };

                var item = new Order
                {
                    Id = _orderss.Count,
                    Name = _editOrder._customerName,
                    OrderDate = _editOrder._orderDate,
                    //TotalAmount = _editOrder._totalAmount
                };
                var id = _ordersRepository.Insert(item);
                item.Id = id;
                _orderss.Add(item);
            }
        }

        private void EditSupplier_Click_1(object sender, EventArgs e)
        {
            if (this.SupplierTable.SelectedRows.Count == 1)
            {
                var supplier = (Supplier)this.SupplierTable.SelectedRows[0].DataBoundItem;
                _editSupplier.Configure(supplier);
                if (_editSupplier.ShowDialog() == DialogResult.OK)
                {
                    if (_editSupplier._supplierName == string.Empty ||
                _editSupplier._supplierPhone == string.Empty ||
                _editSupplier._supplierAddress == string.Empty ||
                _editSupplier._supplieremail == string.Empty ||
                _editSupplier._suppliercontactPerson == string.Empty
                ) { MessageBox.Show("Не введено значение!"); return; };
                    var updated = new Supplier
                    {
                        Id = supplier.Id,
                        Name = _editSupplier._supplierName,
                        Adress = _editSupplier._supplierAddress,
                        Phone = _editSupplier._supplierPhone,
                        ContactPerson = _editSupplier._suppliercontactPerson,
                        Email = _editSupplier._supplieremail
                    };

                    _supplierRepository.Update(updated);
                    var indx = _suppliers.IndexOf(supplier);
                    _suppliers[indx] = updated;
                    this.SupplierTable.DataSource = _suppliers;

                    var toUpdate = _furnituress.Where(x => x.SupplierID?.Id == updated.Id);
                    if (toUpdate != null)
                    {
                        foreach (var Supplier in toUpdate)
                            Supplier.SupplierID = updated;
                    }
                    this.FurnitureTable.DataSource = _furnituress;
                    this.FurnitureTable.Update();
                }
            }
        }

        private void editSales_Click(object sender, EventArgs e)
        {
            var sales = (Sales)this.SalesTable.SelectedRows[0].DataBoundItem;
            _editSales.Configure(sales);
            if (_editSales.ShowDialog() == DialogResult.OK)
            {
                if (_editSales._quantitySold == 0) { MessageBox.Show("Не введено значение!"); return; };

                var updated = new Sales
                {
                    Id = sales.Id,
                    FurnitureID = _editSales._furniture,
                    SaleDate = _editSales._saleDate,
                    OrderID = _editSales._order,
                    QuantitySold = (int?)_editSales._quantitySold
                };

                _salesRepository.Update(updated);
                var indx = _saless.IndexOf(sales);
                //

                             
                var d = _saless[indx];

                if (updated.FurnitureID.Id != d.FurnitureID.Id)
                {
                    var fur = _furnituress.FirstOrDefault(x => x.Id == d.FurnitureID.Id);
                    //fur.StockQuantity += d.QuantitySold;

                    
                    //if (d.QuantitySold != updated.QuantitySold)
                    //{
                        var updatefur = _furnituress.FirstOrDefault(x => x.Id == updated.FurnitureID.Id);
                        updatefur.StockQuantity -= updated.QuantitySold;
                        updated.FurnitureID.StockQuantity = updatefur.StockQuantity;
                        if (updatefur.StockQuantity < 0) { MessageBox.Show("недостаточное количество на складе!"); return; };
                        fur.StockQuantity += updated.QuantitySold;
                        _furnitureRepository.Update(updatefur);

                    //}
                    _furnitureRepository.Update(fur);
                }
                else
                {
                    if (d.QuantitySold != updated.QuantitySold)
                    {
                        var fur = _furnituress.FirstOrDefault(x => x.Id == d.FurnitureID.Id);
                        var diff = d.QuantitySold - updated.QuantitySold;
                        if (fur.StockQuantity + diff < 0) { MessageBox.Show("недостаточное количество на складе!"); return; };
                        fur.StockQuantity += diff;
                        updated.FurnitureID.StockQuantity = fur.StockQuantity;
                        _furnitureRepository.Update(fur);
                    }
                }
                _saless[indx] = updated;

                this.SalesTable.DataSource = _saless;              
            }
        }

        private void editOrder_Click(object sender, EventArgs e)
        {
            var order = (Order)this.OrderTable.SelectedRows[0].DataBoundItem;
            _editOrder.Configure(order);
            if (_editOrder.ShowDialog() == DialogResult.OK)
            {
                if (_editOrder._customerName == string.Empty) { MessageBox.Show("Не введено значение!"); return; };

                var updated = new Order
                {
                    Id = order.Id,
                    Name = _editOrder._customerName,
                    OrderDate = _editOrder._orderDate,
                    //TotalAmount = _editOrder._totalAmount
                };

                _ordersRepository.Update(updated);
                var indx = _orderss.IndexOf(order);
                _orderss[indx] = updated;
                this.OrderTable.DataSource = _orderss;

                var toUpdate = _saless.Where(x => x.OrderID?.Id == updated.Id);
                if (toUpdate != null)
                {
                    foreach (var Order in toUpdate)
                        Order.OrderID = updated;
                }
                this.SalesTable.DataSource = _saless;
                this.SalesTable.Update();
            }
        }

        private void editFurniture_Click(object sender, EventArgs e)
        {
            var furniture = (Furniture)this.FurnitureTable.SelectedRows[0].DataBoundItem;
            _editFurniture.Configure(furniture);
            if (_editFurniture.ShowDialog() == DialogResult.OK)
            {
                if (_editFurniture._category == string.Empty ||
                    _editFurniture._description == string.Empty ||
                    _editFurniture._price == 0 ||
                    _editFurniture._stockQuantity == 0 ||
                    _editFurniture._name == string.Empty
                ) { MessageBox.Show("Не введено значение!"); return; };

                var updated = new Furniture
                {
                    Id = furniture.Id,
                    Name = _editFurniture._name,
                    Category = _editFurniture._category,
                    Description = _editFurniture._description,
                    Price = _editFurniture._price,
                    StockQuantity = _editFurniture._stockQuantity,
                    ManufactureDate = _editFurniture._manufactureDate,
                    SupplierID = _editFurniture._supplier                  

                };

                _furnitureRepository.Update(updated);
                var indx = _furnituress.IndexOf(furniture);
                _furnituress[indx] = updated;
                this.FurnitureTable.DataSource = _furnituress;

                var toUpdate = _saless.Where(x => x.FurnitureID?.Id == updated.Id);
                if (toUpdate != null)
                {
                    foreach (var Furniture in toUpdate)
                        Furniture.FurnitureID = updated;
                }
                this.SalesTable.DataSource = _saless;
                this.SalesTable.Update();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4)
            {
                this.OrderIDSelect.DataSource = _orderss;
                this.InfoTable.DataSource = _saless.Where(x => x.OrderID.Id == ((Order)OrderIDSelect.SelectedItem).Id)
                .Select(x => new OrderIformation
                {
                    Name = x.OrderID.Name,
                    FurnitureID = x.FurnitureID.Name,
                    QuantitySold = x.QuantitySold,
                    Price = x.FurnitureID.Price,
                    OrderDate = x.OrderID.OrderDate,
                    SaleDate = x.SaleDate,
                    PriceAll = x.QuantitySold * x.FurnitureID.Price
                }).ToList();
            }
        }
        public class OrderIformation
        {
            [DisplayName("Имя клиента")]
            public string? Name { get; set; }
            [DisplayName("Дата заказа")]
            public DateTime? OrderDate { get; set; }

            [DisplayName("Цена за шт.")]
            public decimal? Price { get; set; }
            [DisplayName("Дата продажи")]
            public DateTime? SaleDate { get; set; }
            [DisplayName("Мебель")]
            public string? FurnitureID { get; set; }
            [DisplayName("Проданное количество")]
            public int? QuantitySold { get; set; }
            [DisplayName("Общая стоймость")]
            public decimal? PriceAll { get; set; }
        }

        private void OrderIDSelect_SelectedIndexChanged(object sender, EventArgs e)
        {


            this.InfoTable.DataSource = _saless.Where(x => x.OrderID.Id == ((Order)OrderIDSelect.SelectedItem).Id)
                .Select(x => new OrderIformation
                {
                    Name = x.OrderID.Name,
                    FurnitureID = x.FurnitureID.Name,
                    QuantitySold = x.QuantitySold,
                    Price = x.FurnitureID.Price,
                    OrderDate = x.OrderID.OrderDate,
                    SaleDate = x.SaleDate,
                    PriceAll = x.QuantitySold * x.FurnitureID.Price
                }).ToList();
        }

        private void deleteFurniture_Click(object sender, EventArgs e)
        {
            if (this.FurnitureTable.SelectedRows.Count == 1)
            {
                var furniture = (Furniture)this.FurnitureTable.SelectedRows[0].DataBoundItem;

                var delFurniture = _saless.Where(x => x.FurnitureID?.Id == furniture.Id);
                if (delFurniture == null || delFurniture.Count() == 0)
                {
                    _furnitureRepository.Delete(furniture.Id.Value);
                    _furnituress.Remove(furniture);
                }
                else MessageBox.Show("Ошибка! Такую мебель нельзя удалить!!");
            }
        }

        private void deleteSales_Click(object sender, EventArgs e)
        {
            if (this.SalesTable.SelectedRows.Count == 1)
            {
                var sales = (Sales)this.SalesTable.SelectedRows[0].DataBoundItem;
                    _salesRepository.Delete(sales.Id.Value);
                    _saless.Remove(sales);
            }
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            if (this.OrderTable.SelectedRows.Count == 1)
            {
                var order = (Order)this.FurnitureTable.SelectedRows[0].DataBoundItem;

                var delOrder = _saless.Where(x => x.FurnitureID?.Id == order.Id);
                if (delOrder == null || delOrder.Count() == 0)
                {
                    _ordersRepository.Delete(order.Id.Value);
                    _orderss.Remove(order);
                }
                else MessageBox.Show("Ошибка! Такого заказчика нельзя удалить!!");
            }
        }
    }
}

