using System;
using System.Globalization;
using System.Threading;

namespace StringTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-fi");
            Console.WriteLine(MyStrings.Hello);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv");
            Console.WriteLine(MyStrings.Hello);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            Console.WriteLine(MyStrings.Hello);

            Console.ReadLine();
        }
    }
}
