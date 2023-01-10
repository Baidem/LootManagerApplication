using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Loot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Reference> References { get; set; }
        public List<Barcode> Barcodes { get; set; }
        public int UserId { get; set; }
    }
}
