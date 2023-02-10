using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Toy : Specification
    {
        public Person Compagny { get; set; }
        public ToySeries Series { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public Packaging Packaging { get; set; }
        public string Description { get; set; }
        public Image CatalogueImage { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        // Navigation properties //
        public int ToySeriesId { get; set; }
        public int PackagingId { get; set; }
        public int CatalogueImageId { get; set; }

        // Methodes //

        public void GetFullWeight(string filePath)
        {
            // Code for total weight = toy weight + packaging weight
        }

    }
}
