using System;

namespace YourNamespace
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public void HandleException(Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Additional exception handling code can be added here
        }
    }

    class Program
    {
        static void Main()
        {
            Logger logger = new Logger();

            try
            {
                // Code that may throw an exception
                throw new Exception("Something went wrong!");
            }
            catch (Exception ex)
            {
                logger.HandleException(ex);
            }

            logger.Log("Logging a message");
        }
    }
}
