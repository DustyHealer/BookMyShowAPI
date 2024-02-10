using Serilog;

namespace BookMyShow.Logging
{
    public static class LoggerConfig
    {
        public static void ConfigureLogger(LoggerConfiguration loggerConfiguration)
        {
            loggerConfiguration.MinimumLevel.Information()
                              .WriteTo.Console();
            // Add additional sinks (e.g., file, database) and customize formatting
        }
    }
}
