namespace ProxyApp.BusinessModules
{
    internal class LoggingModule : ILoggingModule
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
