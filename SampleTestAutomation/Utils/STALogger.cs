using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Utils
{
    public static class STALogger
    {
        private static readonly string LogFilePath = Path.Combine(AppContext.BaseDirectory, "TestLogs.txt");

        static STALogger()
        {
            // Ensure the log file is created or cleared at the start of the test run
            File.WriteAllText(LogFilePath, string.Empty);
        }

        /// <summary>
        /// Logs a message to the console and a log file.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

            // Log to console
            Console.WriteLine(logMessage);

            // Log to file
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }

        /// <summary>
        /// Logs an error message to the console and a log file.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        public static void LogError(string message)
        {
            string errorMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {message}";

            // Log to console
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();

            // Log to file
            File.AppendAllText(LogFilePath, errorMessage + Environment.NewLine);
        }
    }
}
