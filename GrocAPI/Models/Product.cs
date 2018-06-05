using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrocAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Aisle { get; set; }
        public string Note { get; set; }
        public bool OnList { get; set; } = false;
        public bool Complete { get; set; } = false;
    }
}
