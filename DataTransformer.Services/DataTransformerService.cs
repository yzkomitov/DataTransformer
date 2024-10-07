using DataTransformer.Contracts;

namespace DataTransformer.Services
{
    public class DataTransformerService : IDataTransformer
    {
        public DateTime GenerateDeliveryEndTime(DateTime input, string timeUnit)
        {
            return DateTime.MaxValue;
        }
    }
}
