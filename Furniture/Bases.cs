using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseess
{
    public class Basess
    {
        [DisplayName("Код")]
        public virtual int? Id { get; set; }
        //public int? Id { get; set; }
        [DisplayName("Название")]
        public virtual string? Name { get; set; }

        //public virtual string? Id { get; set; }

    }
}
