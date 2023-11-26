using Baseess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem
{
    public class Order : Basess
    {
        [DisplayName("Имя клиента")]
        public override string? Name { get; set; }
        [DisplayName("Дата заказа")]
        public DateTime? OrderDate { get; set; }
        //[DisplayName("Общая сумма")]
        //public decimal? TotalAmount { get; set; }
        public override string? ToString()
        {
            return Name;
        }
    }
}
