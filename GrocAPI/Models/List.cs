using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrocAPI.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}
