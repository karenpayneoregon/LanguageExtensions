using ExtensionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumber = "9991231234";
            Console.WriteLine($"Formatted phone number: {phoneNumber.FormatPhoneNumber()}");
            Console.ReadLine();
        }
    }
}
