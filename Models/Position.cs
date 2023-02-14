using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Position
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public Shelf Shelf { get; set; }
        public int ShelfId { get; set; }
        public List<Loot> Loots { get; set; }

        public void GetLocation(int LootID, int UserId)
        {
            // Code to get the Location
        }

    }
}
