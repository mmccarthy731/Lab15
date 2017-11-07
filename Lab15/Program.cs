using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
            Console.WriteLine("=================================================");
            bool repeat = true;
            while(repeat)
            {
                repeat = Validator.GetSelection();
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
