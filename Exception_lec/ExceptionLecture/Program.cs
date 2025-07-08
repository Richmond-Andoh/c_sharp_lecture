// Create an Exception class that inherits from System.Exception

namespace ExceptionLecture
{
    internal class Program
    {
        static void Main(string[], args) {
            int repeat = 1;
            int response = 1;

            while (response == 1)
            {
                try
                {
                    Console.WriteLine($"Hello {repeat}");
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}