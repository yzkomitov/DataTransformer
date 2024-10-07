using DataTransformer.Contracts;
using DataTransformer.Data;
using DataTransformer.Data.Model;
using DataTransformer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IDataReader, DataReader>();
builder.Services.AddTransient<IDataWriter, DataWriter>();
builder.Services.AddTransient<IDataTransformer, DataTransformerService>();

using IHost host = builder.Build();
TransformApp(host.Services);

static void TransformApp(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    var logger = provider.GetService<ILogger>();
    
    var dataReader = provider.GetService<IDataReader>();
    string path = Directory.GetCurrentDirectory();
    var input = dataReader.ReadFile<PriceDataPoint>($"{path}\\sample-data.json");

    logger.Info($"File read success. Total lines: {input?.Count}");

    var transformedInput = input?.ToList();

    logger.Info($"File transformation success. Total lines: {transformedInput?.Count}");

    var dataWriter = provider.GetService<IDataWriter>();
    dataWriter.Write(transformedInput, path, "output.json");

    logger.Info($"Output write success.");

    Console.WriteLine($"Execution success.\r\nOutput Directory: {path}\r\nFile Name: output.json.\r\nPress any key to exit.");
    Console.ReadKey();
}