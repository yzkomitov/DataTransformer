using DataTransformer.Contracts;

namespace DataTransformer.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Thread.Sleep(1000);
            Console.WriteLine(message);
        }
    }
}
