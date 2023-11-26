using Baseess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem
{
    public class Furniture: Basess
    {
        [DisplayName("Название мебели")]
        public override string? Name { get; set; }
        [DisplayName("Категория")]
        public string? Category { get; set; }
        [DisplayName("Цена")]
        public decimal? Price { get; set; }

        [DisplayName("Количество на складе")]
        public int? StockQuantity { get; set; }
        [DisplayName("Описание")]
        public string? Description { get; set; }        
        [DisplayName("Дата производства")]
        public DateTime? ManufactureDate { get; set; }
        [DisplayName("Поставщик")]
        public Supplier? SupplierID { get; set; }
        public override string? ToString()
        {
            return Name;
        }
    }
}
