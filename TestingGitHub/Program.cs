using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Me("Muziwakhile", "Thwala");

            Console.Read();
        }

        private static void Me(string name, string surname)
        {
            Console.WriteLine($"My name is {name} {surname}");
        }
    }
}
