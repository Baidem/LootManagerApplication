using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InfoSheet
    {
        public int Id { get; set; }
        public Element Loot { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Barcode { get; set; }
        public ICollection<Price> Prices { get; set; }
        // Navigation properties //
        public int LootId { get; set; }

    }
}
