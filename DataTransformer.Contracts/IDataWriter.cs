namespace DataTransformer.Contracts
{
    public interface IDataWriter
    {
        public void Write<T>(List<T> input, string path, string fileName) where T : class, new();
    }
}
