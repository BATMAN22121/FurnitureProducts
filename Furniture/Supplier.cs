using Baseess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem
{
    public class Supplier : Basess
    {
        [DisplayName("Название компании")]
        public override string? Name { get; set; }
        [DisplayName("Контактное лицо")]
        public string? ContactPerson { get; set; }
        [DisplayName("Телефон")]
        public string? Phone { get; set; }
        [DisplayName("Почта")]
        public string? Email { get; set; }
        [DisplayName("Адрес")]
        public string? Adress { get; set; }
        public override string? ToString()
        {
            return Name;
        }
    }
}
