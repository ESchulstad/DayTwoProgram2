using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            int x = int.Parse(Console.ReadLine());

            if (x >= 16)
            {
                Console.WriteLine("You can drive.");

                if (x >= 18)
                {
                    Console.WriteLine("You're an adult.");
                }
                else
                {
                    Console.WriteLine("You're not an adult yet.");
                }
            }
        }
    }
}
