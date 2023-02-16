using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Box
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        // Navigation properties //
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public List<Loot> Loots { get; set; }
    }
}
