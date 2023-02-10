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
        public string ISBN { get; set; }
        public ICollection<Person> Writers { get; set; }
        public ICollection<Person> Illustrators { get; set; }
        public DateTime PublishedDate { get; set; }
        public Person Publisher { get; set; }
        public string Description { get; set; }
        public Image CoverImage { get; set; }
        public Language Language { get; set; }
        public BookSeries Series { get; set; }
        public int VolumeNumber { get; set; }
        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        // Navigation properties //
        public int CoverImageId { get; set; }
        public int PublisherId { get; set; }

    }
}
