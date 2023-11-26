namespace FurnitureProducts
{
    partial class EditSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuantitySoldInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SaleDateInput = new System.Windows.Forms.DateTimePicker();
            this.FurnitureIDSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderIDSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySoldInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Проданное количество";
            // 
            // QuantitySoldInput
            // 
            this.QuantitySoldInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantitySoldInput.Location = new System.Drawing.Point(258, 92);
            this.QuantitySoldInput.Name = "QuantitySoldInput";
            this.QuantitySoldInput.Size = new System.Drawing.Size(228, 26);
            this.QuantitySoldInput.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Дата продажи";
            // 
            // SaleDateInput
            // 
            this.SaleDateInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaleDateInput.Location = new System.Drawing.Point(258, 36);
            this.SaleDateInput.Name = "SaleDateInput";
            this.SaleDateInput.Size = new System.Drawing.Size(228, 26);
            this.SaleDateInput.TabIndex = 75;
            // 
            // FurnitureIDSelect
            // 
            this.FurnitureIDSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FurnitureIDSelect.FormattingEnabled = true;
            this.FurnitureIDSelect.Location = new System.Drawing.Point(258, 63);
            this.FurnitureIDSelect.Name = "FurnitureIDSelect";
            this.FurnitureIDSelect.Size = new System.Drawing.Size(228, 27);
            this.FurnitureIDSelect.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Мебель";
            // 
            // OrderIDSelect
            // 
            this.OrderIDSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderIDSelect.FormattingEnabled = true;
            this.OrderIDSelect.Location = new System.Drawing.Point(258, 7);
            this.OrderIDSelect.Name = "OrderIDSelect";
            this.OrderIDSelect.Size = new System.Drawing.Size(228, 27);
            this.OrderIDSelect.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "Заказ";
            // 
            // saveOrder
            // 
            this.saveOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveOrder.Location = new System.Drawing.Point(12, 124);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(474, 26);
            this.saveOrder.TabIndex = 70;
            this.saveOrder.Text = "Сохранить";
            this.saveOrder.UseVisualStyleBackColor = true;
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // EditSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantitySoldInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaleDateInput);
            this.Controls.Add(this.FurnitureIDSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderIDSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveOrder);
            this.Name = "EditSales";
            this.Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySoldInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown QuantitySoldInput;
        private Label label3;
        private DateTimePicker SaleDateInput;
        private ComboBox FurnitureIDSelect;
        private Label label2;
        private ComboBox OrderIDSelect;
        private Label label6;
        private Button saveOrder;
    }
}