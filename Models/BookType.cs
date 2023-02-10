using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BookType
    {
        Book, Comic, BD, Manga, Manhna, Magaazine, Fanzine, Other
    }
}