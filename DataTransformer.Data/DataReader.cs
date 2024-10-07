using DataTransformer.Contracts;
using DataTransformer.Data.Json;
using System.Text.Json;

namespace DataTransformer.Data
{
    public class DataReader : IDataReader
    {
        public List<T> ReadFile<T>(string path) where T : class, new()
        {
            var result = new List<T>();
            if (File.Exists(path))
            {
                var jsonString = File.ReadAllText(path);

                if (!string.IsNullOrWhiteSpace(jsonString))
                {
                    var serializeOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Converters =
                        {
                            new DateTimeJsonConverter(),
                            new DateJsonConverter()
                        }
                    };

                    result = JsonSerializer.Deserialize<List<T>>(jsonString, serializeOptions);
                }
            }

            return result;
        }
    }
}
