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
            //int age = 21;
            //if (age >= 17)
            //{
            //    Console.WriteLine("You can see this movie");

            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are too young.  You need a parent present.");


            //int diners = 4;
            //int eachPay = 13;
            //Console.WriteLine("How much is each person paying?");
            //int eachPay = int.Parse(Console.ReadLine());
            //Console.WriteLine(eachPay * 4);
            //if (eachPay * 4 >= 50)
            //{
            //    Console.WriteLine("You earned 10% off your bill today!");
            //}
            //else
            //{
            //    Console.WriteLine("You earned 5% off your bill today!");
            //}

            Console.WriteLine("Please tell me your age");
            int studentAge = int.Parse(Console.ReadLine());
            if (studentAge < 0.0)
            {
                Console.WriteLine("This program is for humans.");
            }
            if (studentAge > 100.0)
            {
                Console.WriteLine("This program is for humans.");
            }
            else if (studentAge >= 0 && studentAge <= 2)
            {
                Console.WriteLine("Still in Mama's Arms.");
            }
            else if (studentAge >= 3 && studentAge <= 4)
            {
                Console.WriteLine("Pre-School Maniac.");
            }
            else if (studentAge >= 5 && studentAge <= 11)
            {
                Console.WriteLine("Elementary School.");
            }
            else if (studentAge >= 12 && studentAge <= 14)
            {
                Console.WriteLine("Middle School.");
            }
            else if (studentAge >= 15 && studentAge <= 18)
            {
                Console.WriteLine("High School.");
            }
            else if (studentAge >= 19 && studentAge <= 22)
            {
                Console.WriteLine("College.");
            }
            else if (studentAge >= 23 && studentAge <= 65)
            {
                Console.WriteLine("Working for the Man.");
            }
            else if (studentAge >= 66 && studentAge <= 100)
            {
                Console.WriteLine("Golden Years.");
            }
            }
        }
    }