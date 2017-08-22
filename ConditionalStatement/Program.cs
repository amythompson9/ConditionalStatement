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
            //relational operator
            //if (age >= 17)
            //{
            //    Console.WriteLine("You can see this movie");

            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are too young.  You need a parent present.");



            //Console.WriteLine("How much is your total bill?");
            //double totalBill = double.Parse(Console.ReadLine());
            //if (totalBill >= 50.0)
            //{
            //    Console.WriteLine("You earned 10% off your bill today!");
            //}
            //else
            //{
            //    Console.WriteLine("You earned 5% off your bill today!");
            //}
            //Console.WriteLine("Your new total is...");
            //if (totalBill >= 50)
            //{
            //    Console.WriteLine(totalBill * .90);
            //}
            //else
            //{
            //    Console.WriteLine(totalBill * .95);
            //}
            //Console.WriteLine("How many people are in your party?");
            //int peopleParty = int.Parse(Console.ReadLine());
            //Console.WriteLine("Each person owes the following amount");
            //if (totalBill >= 50)
            //{
            //    Console.WriteLine((totalBill * .90) / peopleParty);
            //}
            //else
            //{
            //    Console.WriteLine((totalBill * .95) / peopleParty);
            //}


            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if (grade <= 59)
            //{
            //    Console.WriteLine("You have failed this project.");
            //}
            //if (grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("You earned an A.");
            //}
            //else if (grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine("You earned a B.");
            //}
            //else if (grade >= 70 && grade <= 79)
            //{
            //    Console.WriteLine("You earned a C.");
            //}
            //else if (grade >= 60 && grade <= 69)
            //{
            //    Console.WriteLine("You have earned a D.");
            //}



            //Console.WriteLine("Please tell me your age");
            //int studentAge = int.Parse(Console.ReadLine());
            //if (studentAge < 0.0)
            //{
            //    Console.WriteLine("This program is for humans.");
            //}
            //if (studentAge > 100.0)
            //{
            //    Console.WriteLine("This program is for humans.");
            //}
            //else if (studentAge >= 0 && studentAge <= 2)
            //{
            //    Console.WriteLine("Still in Mama's Arms.");
            //}
            //else if (studentAge >= 3 && studentAge <= 4)
            //{
            //    Console.WriteLine("Pre-School Maniac.");
            //}
            //else if (studentAge >= 5 && studentAge <= 11)
            //{
            //    Console.WriteLine("Elementary School.");
            //}
            //else if (studentAge >= 12 && studentAge <= 14)
            //{
            //    Console.WriteLine("Middle School.");
            //}
            //else if (studentAge >= 15 && studentAge <= 18)
            //{
            //    Console.WriteLine("High School.");
            //}
            //else if (studentAge >= 19 && studentAge <= 22)
            //{
            //    Console.WriteLine("College.");
            //}
            //else if (studentAge >= 23 && studentAge <= 65)
            //{
            //    Console.WriteLine("Working for the Man.");
            //}
            //else if (studentAge >= 66 && studentAge <= 100)
            //{
            //    Console.WriteLine("Golden Years.");
            //}

            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number.");
            }
            else
            {
                Console.WriteLine(number + " is an odd number.");
            }
        }
    }
}