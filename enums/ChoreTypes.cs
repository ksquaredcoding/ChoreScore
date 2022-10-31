using System.Text.Json.Serialization;
namespace ChoreScore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]

public enum ChoreType
{
  Kitchen,
  Laundry,
  Outdoor,
  Misc
}