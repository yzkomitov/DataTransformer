using DataTransformer.Contracts;
using System.Text.Json;

namespace DataTransformer.Data
{
    public class DataWriter : IDataWriter
    {
        public void Write<T>(List<T> input, string path, string fileName) where T : class, new()
        {
            var jsonText = JsonSerializer.Serialize(input);

            File.WriteAllText($"{path}\\{fileName}", jsonText);
        }
    }
}
