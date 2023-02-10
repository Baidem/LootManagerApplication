using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ToyType
    {
        Puzzle,
        Outdoor,
        Electronic,
        Doll,
        Action_figurine,
        Building_set,
        Construction,
        Board_game,
        Art,
        Craft,
        Musical,
        Educationnal,
        Other

    }
}