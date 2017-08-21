using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            if (age >= 17)
            {
                Console.WriteLine("You can see this movie");

            }
            else
            {
                Console.WriteLine("Sorry you are too young.  You need a parent present.");
            }
    }
}
