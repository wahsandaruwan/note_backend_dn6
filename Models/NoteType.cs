using System.Text.Json.Serialization;

namespace backend.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    // Enum for the note type
    public enum NoteType
    {
        Detail = 1,
        Todo = 2
    }
}