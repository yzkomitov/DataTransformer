using DataTransformer.Services;

namespace DataTransformer.Tests
{
    [TestClass]
    public class DataTransformerServiceTests
    {
        [TestMethod]
        public void GenerateDeliveryEndTime_Day_1()
        {
            DateTime input = new(2024, 1, 1);
            string timeUnit = "D";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2024, 1, 2), result);
        }

        [TestMethod]
        public void GenerateDeliveryEndTime_Day_2()
        {
            DateTime input = new(2024, 4, 1, 6, 7, 8);
            string timeUnit = "D";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2024, 4, 2, 6, 7, 8), result);
        }

        [TestMethod]
        public void GenerateDeliveryEndTime_Month_1()
        {
            DateTime input = new(2024, 1, 1);
            string timeUnit = "M";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2024, 2, 1), result);
        }

        [TestMethod]
        public void GenerateDeliveryEndTime_Month_2()
        {
            DateTime input = new(2024, 1, 1, 6, 0, 0);
            string timeUnit = "M";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2024, 2, 1, 6, 0, 0), result);
        }

        [TestMethod]
        public void GenerateDeliveryEndTime_HalfHour_1()
        {
            DateTime input = new(2024, 1, 1, 0, 0, 0);
            string timeUnit = "HH";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2024, 1, 1, 0, 30, 0), result);
        }

        [TestMethod]
        public void GenerateDeliveryEndTime_HalfHour_2()
        {
            DateTime input = new(2024, 12, 31, 23, 30, 0);
            string timeUnit = "HH";
            DataTransformerService service = new();

            DateTime result = service.GenerateDeliveryEndTime(input, timeUnit);

            Assert.AreEqual(new(2025, 1, 1, 0, 0, 0), result);
        }
    }
}