using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book : Loot
    {
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public int PublisherId { get; set; }
        public string EditionNumber { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
