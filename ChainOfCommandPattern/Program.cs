using System;
using System.Globalization;

namespace ChainOfCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User("John Doe", "693725551741", new RegionInfo("AT"), new DateTimeOffset(2005, 04, 05, 00, 00, 00, TimeSpan.FromHours(2)));
            var processor = new UserProcessor();

            //sender
            var result = processor.Register(usr, out string message);

            Console.WriteLine(result ? "User successfully registered!" : $"Something went wrong: {message}");
            Console.ReadKey();
        }
    }
}
