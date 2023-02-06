using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Manga : Book
    {
        public List<Person> Mangakas { get; set; }
        public List<MangaGenre> MangaGenres { get; set; }
        public string Description { get; set; }


    }
}
