using ProxyApp.BusinessModules;

namespace ProxyApp.ProxyModules
{
    internal class LoggingModuleProxy : ILoggingModule
    {
        private readonly ILoggingModule _logger;
        public LoggingModuleProxy()
        {
            _logger = new LoggingModule();
        }
        public void Log(string message)
        {
            Console.WriteLine("Befor logging");
            _logger.Log(message);
            Console.WriteLine("After logging");

        }
    }
}
