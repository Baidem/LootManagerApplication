using System.Reflection;

namespace Models
{
    public class BookSeries
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int VolumeCount { get; set; }
        public string Brand { get; set; }
        public BookGenre Genre { get; set; }
        public BookType Type { get; set; }
        public Person Publisher { get; set; }
        // Navigation properties //
        public int GenreId { get; set; }
        public int TypeId { get; set; }
        public int PublisherId { get; set; }
    }
}