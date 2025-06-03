using System;
using System.IO;

namespace DSLApp1.Tests
{
}

namespace ConsoleApp3.Core
{
    public interface ILogger
    {
        void Log(string message);
        void Warn(string message);
        void Error(string message);
        void LogException(Exception exception);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("[LOG] " + message);
        public void Warn(string message) => Console.WriteLine("[WARN] " + message);
        public void Error(string message) => Console.WriteLine("[ERROR] " + message);
        public void LogException(Exception exception) => Console.WriteLine("[Exception] " + exception.Message);
    }

    public class FileLogger : ILogger
    {
        private readonly string _logFilePath;

        public FileLogger(string path = "app.log")
        {
            _logFilePath = path;
            File.WriteAllText(_logFilePath, ""); // clear on start
        }

        private void Write(string level, string message)
        {
            File.AppendAllText(_logFilePath, $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n");
        }

        public void Log(string message) => Write("LOG", message);
        public void Warn(string message) => Write("WARN", message);
        public void Error(string message) => Write("ERROR", message);
        public void LogException(Exception ex) => Write("EXCEPTION", ex.ToString());
    }
}
