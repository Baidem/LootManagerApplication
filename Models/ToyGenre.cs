using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ToyGenre
    {
        Superhero,
        Fantasy,
        Animal,
        Vehicle,
        Cooking,
        Doll_s_house,
        Sport,
        Science_fiction,
        Other

    }
}