using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonType
    {
        Compagny, Publisher, Author, Writer, Cartoonist, Comic_book_artist, Comic_strip_artist, Comic_book_illustrator, Mangaka, Maker, Artist, Designer 
    }
}
