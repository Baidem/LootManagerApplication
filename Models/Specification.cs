using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Barcode { get; set; }
        public List<Price> Prices { get; set; }

    }
}
