using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Language

    {
        English,
        Spanish,
        German,
        Chinese,
        French,
        Russian,
        Japanese,
        Korean,
        Portuguese,
        Italian
    }
}
