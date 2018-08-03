using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class Program
    {
       public static void Main()
        {
            double choice = 0;
            bool check = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Area Calculator");
                Console.WriteLine("1) Calculate Circle Area");
                Console.WriteLine("2) Calculate Square Area");
                Console.WriteLine("3) Return to main menu");
                Console.WriteLine("Please enter the number of your selection");
                check = double.TryParse(Console.ReadLine(), out choice);
                if (check == false)
                {
                    Console.WriteLine("Invalid choice, Please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else
                {
                    switch (choice)
                    {
                        case 1:
                            Circle.Area();
                            break;
                        case 2:
                            Square.Area();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid Choice, Please enter a number between 1 and 5");
                            Console.Clear();
                            break;
                    }
                }
            } while (choice != 3);
        }
    }

    public static class Circle
    {
        public static double Values()
        {
            Console.WriteLine("Please enter the radius if the circle");
            double radius = double.Parse(Console.ReadLine());
            radius = radius * radius;
            return radius;   
        }
        public static void Area()
        {
              Console.WriteLine("The area of the circle is {0}", Circle.Values() * 3.14195);
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }

    public static class Square
    {
        public static double Values()
        {
            Console.WriteLine("Please enter the length of one side of the square");
            double length = double.Parse(Console.ReadLine());
            length = length * length;
            return length;
        }
        public static void Area()
        {
            Console.WriteLine("The area of the square is {0}", Square.Values());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
