using DataTransformer.Data.Json;
using System.Text.Json.Serialization;

namespace DataTransformer.Data.Model
{
    public class PriceDataPoint
    {
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime PriceDate { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DeliveryStart { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public double Price { get; set; }

        public string Commodity { get; set; }

        public string TimeUnit { get; set; }

        public string TimeZone { get; set; }

        public AdditionalData AdditionaData { get; set; }

        public PriceDataPoint()
        {
            
        }

        public PriceDataPoint(PriceDataPoint dp)
        {
            PriceDate = dp.PriceDate;
            DeliveryStart = dp.DeliveryStart;
            Commodity = dp.Commodity;
            TimeUnit = dp.TimeUnit;
            Price = dp.Price;
            TimeZone = dp.TimeZone;
            AdditionaData = dp.AdditionaData;
        }
    }
}
