using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Area Calculator");
                Console.WriteLine("1) Enter Circle Values");
                Console.WriteLine("2) Calculate Circle Area");
                Console.WriteLine("3) Enter Square Values");
                Console.WriteLine("4) Calculate Circle Area");
                Console.WriteLine("5) Exit Program");
                Console.WriteLine("Please enter the number of your selection");
                choice = int.Parse(Console.ReadLine());
                if (choice > 5) Console.WriteLine("{0} is not a valid choice", choice);

                switch (choice)
                {
                    case 1:
                        Circle.Values();
                        break;
                    case 2:
                        Circle.Area();
                        break;
                    case 3:
                        Square.Values();
                        break;
                    case 4:
                        Square.Area();
                        break;
                    default:
                        break;
                }
            } while (choice != 5);
        }
    }
}
