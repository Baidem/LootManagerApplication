using System.Security.Principal;

namespace Models
{
    public class ToySeries
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ItemCount { get; set; }
        public string Brand { get; set; }
        public string Licence { get; set; }
        public ToyGenre Genre { get; set; }
        public ToyType Type { get; set; }
        public Person Compagny { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set;}
        // Navigation properties //
        public int CompagnyId { get; set; }



    }
}