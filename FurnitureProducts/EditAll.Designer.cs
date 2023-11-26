namespace FurnitureI
{
    partial class EditAll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Supplier = new System.Windows.Forms.TabPage();
            this.SupplierTable = new System.Windows.Forms.DataGridView();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.addSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboSearchSupplier = new System.Windows.Forms.ToolStripComboBox();
            this.searchSupplier = new System.Windows.Forms.ToolStripTextBox();
            this.Furniture = new System.Windows.Forms.TabPage();
            this.FurnitureTable = new System.Windows.Forms.DataGridView();
            this.menuStrip7 = new System.Windows.Forms.MenuStrip();
            this.addFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.editFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboSearchFurniture = new System.Windows.Forms.ToolStripComboBox();
            this.searchFurniture = new System.Windows.Forms.ToolStripTextBox();
            this.Sales = new System.Windows.Forms.TabPage();
            this.SalesTable = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addSales = new System.Windows.Forms.ToolStripMenuItem();
            this.editSales = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSales = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboSearchSales = new System.Windows.Forms.ToolStripComboBox();
            this.searchSales = new System.Windows.Forms.ToolStripTextBox();
            this.Orders = new System.Windows.Forms.TabPage();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.addOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboSearchOrder = new System.Windows.Forms.ToolStripComboBox();
            this.searchOrder = new System.Windows.Forms.ToolStripTextBox();
            this.Info = new System.Windows.Forms.TabPage();
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderIDSelect = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTable)).BeginInit();
            this.menuStrip5.SuspendLayout();
            this.Furniture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureTable)).BeginInit();
            this.menuStrip7.SuspendLayout();
            this.Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.menuStrip6.SuspendLayout();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.Supplier);
            this.tabControl1.Controls.Add(this.Furniture);
            this.tabControl1.Controls.Add(this.Sales);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Controls.Add(this.Info);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Supplier
            // 
            this.Supplier.Controls.Add(this.SupplierTable);
            this.Supplier.Controls.Add(this.menuStrip5);
            this.Supplier.Location = new System.Drawing.Point(4, 31);
            this.Supplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Supplier.Name = "Supplier";
            this.Supplier.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Supplier.Size = new System.Drawing.Size(1160, 415);
            this.Supplier.TabIndex = 4;
            this.Supplier.Text = "Поставщик";
            this.Supplier.UseVisualStyleBackColor = true;
            // 
            // SupplierTable
            // 
            this.SupplierTable.AllowUserToAddRows = false;
            this.SupplierTable.AllowUserToDeleteRows = false;
            this.SupplierTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SupplierTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SupplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierTable.Location = new System.Drawing.Point(4, 34);
            this.SupplierTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SupplierTable.Name = "SupplierTable";
            this.SupplierTable.ReadOnly = true;
            this.SupplierTable.RowTemplate.Height = 25;
            this.SupplierTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierTable.Size = new System.Drawing.Size(1152, 378);
            this.SupplierTable.TabIndex = 7;
            // 
            // menuStrip5
            // 
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplier,
            this.EditSupplier,
            this.deleteSupplier,
            this.ComboSearchSupplier,
            this.searchSupplier});
            this.menuStrip5.Location = new System.Drawing.Point(4, 3);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(1152, 31);
            this.menuStrip5.TabIndex = 0;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // addSupplier
            // 
            this.addSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(86, 27);
            this.addSupplier.Text = "Добавить";
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // EditSupplier
            // 
            this.EditSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Size = new System.Drawing.Size(87, 27);
            this.EditSupplier.Text = "Изменить";
            this.EditSupplier.Click += new System.EventHandler(this.EditSupplier_Click_1);
            // 
            // deleteSupplier
            // 
            this.deleteSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSupplier.Name = "deleteSupplier";
            this.deleteSupplier.Size = new System.Drawing.Size(76, 27);
            this.deleteSupplier.Text = "Удалить";
            this.deleteSupplier.Click += new System.EventHandler(this.deleteSupplier_Click);
            // 
            // ComboSearchSupplier
            // 
            this.ComboSearchSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboSearchSupplier.Name = "ComboSearchSupplier";
            this.ComboSearchSupplier.Size = new System.Drawing.Size(194, 27);
            // 
            // searchSupplier
            // 
            this.searchSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(121, 27);
            this.searchSupplier.TextChanged += new System.EventHandler(this.searchSupplier_TextChanged);
            // 
            // Furniture
            // 
            this.Furniture.Controls.Add(this.FurnitureTable);
            this.Furniture.Controls.Add(this.menuStrip7);
            this.Furniture.Location = new System.Drawing.Point(4, 31);
            this.Furniture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Furniture.Name = "Furniture";
            this.Furniture.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Furniture.Size = new System.Drawing.Size(1160, 415);
            this.Furniture.TabIndex = 6;
            this.Furniture.Text = "Мебель";
            this.Furniture.UseVisualStyleBackColor = true;
            // 
            // FurnitureTable
            // 
            this.FurnitureTable.AllowUserToAddRows = false;
            this.FurnitureTable.AllowUserToDeleteRows = false;
            this.FurnitureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FurnitureTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FurnitureTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.FurnitureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FurnitureTable.Location = new System.Drawing.Point(4, 34);
            this.FurnitureTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FurnitureTable.Name = "FurnitureTable";
            this.FurnitureTable.ReadOnly = true;
            this.FurnitureTable.RowTemplate.Height = 25;
            this.FurnitureTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureTable.Size = new System.Drawing.Size(1152, 378);
            this.FurnitureTable.TabIndex = 9;
            // 
            // menuStrip7
            // 
            this.menuStrip7.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFurniture,
            this.editFurniture,
            this.deleteFurniture,
            this.ComboSearchFurniture,
            this.searchFurniture});
            this.menuStrip7.Location = new System.Drawing.Point(4, 3);
            this.menuStrip7.Name = "menuStrip7";
            this.menuStrip7.Size = new System.Drawing.Size(1152, 31);
            this.menuStrip7.TabIndex = 1;
            this.menuStrip7.Text = "menuStrip7";
            // 
            // addFurniture
            // 
            this.addFurniture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addFurniture.Name = "addFurniture";
            this.addFurniture.Size = new System.Drawing.Size(86, 27);
            this.addFurniture.Text = "Добавить";
            this.addFurniture.Click += new System.EventHandler(this.addFurniture_Click);
            // 
            // editFurniture
            // 
            this.editFurniture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editFurniture.Name = "editFurniture";
            this.editFurniture.Size = new System.Drawing.Size(87, 27);
            this.editFurniture.Text = "Изменить";
            this.editFurniture.Click += new System.EventHandler(this.editFurniture_Click);
            // 
            // deleteFurniture
            // 
            this.deleteFurniture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteFurniture.Name = "deleteFurniture";
            this.deleteFurniture.Size = new System.Drawing.Size(76, 27);
            this.deleteFurniture.Text = "Удалить";
            this.deleteFurniture.Click += new System.EventHandler(this.deleteFurniture_Click);
            // 
            // ComboSearchFurniture
            // 
            this.ComboSearchFurniture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboSearchFurniture.Name = "ComboSearchFurniture";
            this.ComboSearchFurniture.Size = new System.Drawing.Size(194, 27);
            // 
            // searchFurniture
            // 
            this.searchFurniture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchFurniture.Name = "searchFurniture";
            this.searchFurniture.Size = new System.Drawing.Size(121, 27);
            this.searchFurniture.TextChanged += new System.EventHandler(this.searchMedicalRawMaterial_TextChanged);
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.SalesTable);
            this.Sales.Controls.Add(this.menuStrip2);
            this.Sales.Location = new System.Drawing.Point(4, 31);
            this.Sales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sales.Size = new System.Drawing.Size(1160, 415);
            this.Sales.TabIndex = 1;
            this.Sales.Text = "Продажи";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // SalesTable
            // 
            this.SalesTable.AllowUserToAddRows = false;
            this.SalesTable.AllowUserToDeleteRows = false;
            this.SalesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SalesTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesTable.Location = new System.Drawing.Point(4, 34);
            this.SalesTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SalesTable.Name = "SalesTable";
            this.SalesTable.ReadOnly = true;
            this.SalesTable.RowTemplate.Height = 25;
            this.SalesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesTable.Size = new System.Drawing.Size(1152, 378);
            this.SalesTable.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSales,
            this.editSales,
            this.deleteSales,
            this.ComboSearchSales,
            this.searchSales});
            this.menuStrip2.Location = new System.Drawing.Point(4, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1152, 31);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addSales
            // 
            this.addSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(86, 27);
            this.addSales.Text = "Добавить";
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // editSales
            // 
            this.editSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(87, 27);
            this.editSales.Text = "Изменить";
            this.editSales.Click += new System.EventHandler(this.editSales_Click);
            // 
            // deleteSales
            // 
            this.deleteSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSales.Name = "deleteSales";
            this.deleteSales.Size = new System.Drawing.Size(76, 27);
            this.deleteSales.Text = "Удалить";
            this.deleteSales.Click += new System.EventHandler(this.deleteSales_Click);
            // 
            // ComboSearchSales
            // 
            this.ComboSearchSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboSearchSales.Name = "ComboSearchSales";
            this.ComboSearchSales.Size = new System.Drawing.Size(194, 27);
            // 
            // searchSales
            // 
            this.searchSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchSales.Name = "searchSales";
            this.searchSales.Size = new System.Drawing.Size(121, 27);
            this.searchSales.TextChanged += new System.EventHandler(this.searchShipment_TextChanged);
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.OrderTable);
            this.Orders.Controls.Add(this.menuStrip6);
            this.Orders.Location = new System.Drawing.Point(4, 31);
            this.Orders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Orders.Size = new System.Drawing.Size(1160, 415);
            this.Orders.TabIndex = 5;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // OrderTable
            // 
            this.OrderTable.AllowUserToAddRows = false;
            this.OrderTable.AllowUserToDeleteRows = false;
            this.OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTable.Location = new System.Drawing.Point(4, 34);
            this.OrderTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.ReadOnly = true;
            this.OrderTable.RowTemplate.Height = 25;
            this.OrderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderTable.Size = new System.Drawing.Size(1152, 378);
            this.OrderTable.TabIndex = 8;
            // 
            // menuStrip6
            // 
            this.menuStrip6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrder,
            this.editOrder,
            this.deleteOrder,
            this.ComboSearchOrder,
            this.searchOrder});
            this.menuStrip6.Location = new System.Drawing.Point(4, 3);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Size = new System.Drawing.Size(1152, 31);
            this.menuStrip6.TabIndex = 0;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // addOrder
            // 
            this.addOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(86, 27);
            this.addOrder.Text = "Добавить";
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // editOrder
            // 
            this.editOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editOrder.Name = "editOrder";
            this.editOrder.Size = new System.Drawing.Size(87, 27);
            this.editOrder.Text = "Изменить";
            this.editOrder.Click += new System.EventHandler(this.editOrder_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(76, 27);
            this.deleteOrder.Text = "Удалить";
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // ComboSearchOrder
            // 
            this.ComboSearchOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboSearchOrder.Name = "ComboSearchOrder";
            this.ComboSearchOrder.Size = new System.Drawing.Size(194, 27);
            // 
            // searchOrder
            // 
            this.searchOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Size = new System.Drawing.Size(121, 27);
            this.searchOrder.TextChanged += new System.EventHandler(this.searchGroup_TextChanged);
            // 
            // Info
            // 
            this.Info.Controls.Add(this.InfoTable);
            this.Info.Controls.Add(this.label6);
            this.Info.Controls.Add(this.OrderIDSelect);
            this.Info.Location = new System.Drawing.Point(4, 31);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(1160, 415);
            this.Info.TabIndex = 7;
            this.Info.Text = "Информация";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // InfoTable
            // 
            this.InfoTable.AllowUserToAddRows = false;
            this.InfoTable.AllowUserToDeleteRows = false;
            this.InfoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InfoTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InfoTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTable.Location = new System.Drawing.Point(8, 47);
            this.InfoTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.ReadOnly = true;
            this.InfoTable.RowTemplate.Height = 25;
            this.InfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTable.Size = new System.Drawing.Size(1142, 360);
            this.InfoTable.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 79;
            this.label6.Text = "Заказчик";
            // 
            // OrderIDSelect
            // 
            this.OrderIDSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderIDSelect.FormattingEnabled = true;
            this.OrderIDSelect.Location = new System.Drawing.Point(254, 14);
            this.OrderIDSelect.Name = "OrderIDSelect";
            this.OrderIDSelect.Size = new System.Drawing.Size(228, 27);
            this.OrderIDSelect.TabIndex = 80;
            this.OrderIDSelect.SelectedIndexChanged += new System.EventHandler(this.OrderIDSelect_SelectedIndexChanged);
            // 
            // EditAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditAll";
            this.Text = "Редактирование записи";
            this.tabControl1.ResumeLayout(false);
            this.Supplier.ResumeLayout(false);
            this.Supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTable)).EndInit();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.Furniture.ResumeLayout(false);
            this.Furniture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureTable)).EndInit();
            this.menuStrip7.ResumeLayout(false);
            this.menuStrip7.PerformLayout();
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Supplier;
        private DataGridView SupplierTable;
        private MenuStrip menuStrip5;
        private ToolStripMenuItem addSupplier;
        private ToolStripMenuItem EditSupplier;
        private ToolStripMenuItem deleteSupplier;
        private ToolStripComboBox ComboSearchSupplier;
        private ToolStripTextBox searchSupplier;
        private TabPage Furniture;
        private DataGridView FurnitureTable;
        private MenuStrip menuStrip7;
        private ToolStripMenuItem addFurniture;
        private ToolStripMenuItem editFurniture;
        private ToolStripMenuItem deleteFurniture;
        private ToolStripComboBox ComboSearchFurniture;
        private ToolStripTextBox searchFurniture;
        private TabPage Orders;
        private DataGridView OrderTable;
        private MenuStrip menuStrip6;
        private ToolStripMenuItem addOrder;
        private ToolStripMenuItem editOrder;
        private ToolStripMenuItem deleteOrder;
        private ToolStripComboBox ComboSearchOrder;
        private ToolStripTextBox searchOrder;
        private TabPage Sales;
        private DataGridView SalesTable;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addSales;
        private ToolStripMenuItem editSales;
        private ToolStripMenuItem deleteSales;
        private ToolStripComboBox ComboSearchSales;
        private ToolStripTextBox searchSales;
        private TabPage Info;
        private Label label6;
        private ComboBox OrderIDSelect;
        private DataGridView InfoTable;
    }
}