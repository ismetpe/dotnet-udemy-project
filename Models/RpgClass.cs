using System.Text.Json.Serialization;

namespace dotnet_udemy_project.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,

        Mage,

        Klaric
    }
}