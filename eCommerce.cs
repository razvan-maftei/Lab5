using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    [Table("eCommerce", Schema="BazaDeDate")]
    class eCommerce : Business
    {
        public string URL { get; set; }
    }
}
