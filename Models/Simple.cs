using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Simple : Specification
    {
        public string Description { get; set; }
        public Person Author { get; set; }
        public Person Compagny { get; set; }
        public Image Image { get; set; }
        // Navigation properties //
        public int AuthorId { get; set; }
        public int CompagnyId { get; set; }
    }
}
