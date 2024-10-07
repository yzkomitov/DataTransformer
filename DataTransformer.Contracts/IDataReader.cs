namespace DataTransformer.Contracts
{
    public interface IDataReader
    {
        public List<T> ReadFile<T>(string path) where T : class, new();
    }
}
