using System;
using System.Diagnostics;
namespace Cal
{
    class Calcu
    {
        public static void  Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int x= Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("enter Second number");
            int y= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nselect the operation");
            Console.WriteLine("1 --> Addition");
            Console.WriteLine("2 --> substraction");
            Console.WriteLine("3 --> Mtultiplication");
            Console.WriteLine("4 --> Divison");

            Console.WriteLine("\nenter the choice ");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (z)
            {
                case 1:Console.WriteLine($" the result is {x+y}");
                    break;
                case 2:
                    Console.WriteLine($" the result is {x - y}"); ;
                    break;
                case 3:
                    Console.WriteLine($" the result is {x * y}");
                    break;
                case 4:
                    if (y != 0)
                    {
                        Console.WriteLine($" the result is {x / y}");
                    }
                    else
                    {
                        Console.WriteLine("the number cant divide by zero");
                    }
                    break;
                default: Console.WriteLine("select the correct option");
                    break;
            }
        }
          
    }
}