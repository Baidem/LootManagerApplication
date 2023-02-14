using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Storage
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public List<Shelf> Shelves { get; set; }
    }
}
