using Microsoft.Extensions.Logging;

namespace Task1.Services
{
    public class MyLogger<T>
    {
        public ILogger<T> Logger { get; set; }

        public MyLogger()
        {
            Logger = CreateLogger<T>();
        }

        private ILogger<T> CreateLogger<T>()
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddSimpleConsole());

            ILogger<T> logger = loggerFactory.CreateLogger<T>();
            return logger;
        }
    }
}