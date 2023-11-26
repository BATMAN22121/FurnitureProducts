using Baseess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem
{
    public class Sales: Basess
    {
        [Browsable(false)]
        public override string? Name { get; set; }
        [DisplayName("Имя заказчика")]
        public Order? OrderID { get; set; }
        [DisplayName("Дата продажи")]
        public DateTime? SaleDate { get; set; }
        [DisplayName("Мебель")]
        public Furniture? FurnitureID { get; set; }        
        [DisplayName("Проданное количество")]
        public int? QuantitySold { get; set; }        
        public override string? ToString()
        {
            return Name;
        }
    }
}
