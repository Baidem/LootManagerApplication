using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PackType
    {
        Blister_pack,
        Box,
        Poly_bag,
        Window_Box,
        Plastic_container,
        Corrugated_box,
        Shrink_Wrap,
        Flexible_pouche,
        Glass_jar,
        Metal_can,
        Plastic_bottle,
        Other

    }
}