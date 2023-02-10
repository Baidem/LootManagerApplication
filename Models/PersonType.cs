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
        Compagny, 
        Publisher, 
        Author, 
        Writer,
        Maker,
        Designer,
        Comic_artist,
        Comic_drawer,
        Comic_writer, 
        Mangaka,
        Manga_drawer,
        Manga_assistant,
        BD_artist,
        BD_drawer,
        BD_writer,
        Other
    }
}
