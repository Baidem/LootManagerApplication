using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book : Specification
    {
        public string Title { get; set; }
        public List<Person> Authors { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public Person Publisher { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public Image CoverImage { get; set; }
        // Navigation properties //
        public int CoverImageId { get; set; }
        public int AuthorsId { get; set; }
        public int PublisherId { get; set; }

    }
}
