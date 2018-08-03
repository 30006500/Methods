using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    public static class Program
    {
        static double num1 = 0;
        static double num2 = 0;
       
        public static void Main()

        {
            double calc = 0;
            bool check = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Return to main menu");
                Console.WriteLine("Please enter the number of your choice");
                check = double.TryParse(Console.ReadLine(), out calc);
                if (check == false)
                {
                    Console.WriteLine("Invalid choice, Please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else
                {

                    switch (calc)
                    {
                        case 1:
                            Input();
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, Math.AddNums(num1, num2));
                            Clear();
                            break;
                        case 2:
                            Input();
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, Math.SubtractNums(num1, num2));
                            Clear();
                            break;
                        case 3:
                            Input();
                            Console.WriteLine("{0} x {1} = {2}", num1, num2, Math.MultiplyNums(num1, num2));
                            Clear();
                            break;
                        case 4:
                            Input();
                            Console.WriteLine("{0} / {1} = {2}", num1, num2, Math.DivideNums(num1, num2));
                            Clear();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Invalid Choice, Please enter a number between 1 and 5");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }

                
            } while (calc != 5);
                    
           
        }
        public static void Input()
            {
            Console.WriteLine("Please enter the first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = double.Parse(Console.ReadLine());
            }

        public static void Clear()
        {
            Console.WriteLine("");
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static class Math
        {
            public static double MultiplyNums(double _num1, double _num2)
            {
                return _num1 * _num2;
            }

            public static double AddNums(double _num1, double _num2)
            {
                return _num1 + _num2;
            }

            public static double DivideNums(double _num1, double _num2)
            {
                return _num1 / _num2;
            }

            public static double SubtractNums(double _num1, double  _num2)
            {
                return _num1 - _num2;
            }
        }
    }
}
