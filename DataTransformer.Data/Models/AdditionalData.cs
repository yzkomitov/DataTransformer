using DataTransformer.Data.Json;
using System.Text.Json.Serialization;

namespace DataTransformer.Data.Model
{
    public class AdditionalData
    {
        [JsonPropertyName("CreateName")]
        public string CreateName { get; set; }

        [JsonPropertyName("CreateTime")]
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime CreateTime { get; set; }
    }
}
