namespace DataTransformer.Contracts
{
    public interface IDataTransformer
    {
        public DateTime GenerateDeliveryEndTime(DateTime input, string timeUnit);
    }
}
