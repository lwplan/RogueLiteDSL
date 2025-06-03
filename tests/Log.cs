using System;
using ConsoleApp3.Core;

namespace DSLApp1.Tests
{
    public static class Log
    {
        private static ILogger _backend = new FileLogger(); // default fallback

        public static void SetBackend(ILogger logger)
        {
            _backend = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public static void Info(string message) => _backend.Log(message);
        public static void Warning(string message) => _backend.Warn(message);
        public static void Error(string message) => _backend.Error(message);

        public static void LogException(Exception exception) => _backend.LogException(exception);
    }
}