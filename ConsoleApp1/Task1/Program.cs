using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("Please enter the number of your choice");
            int calc = int.Parse(Console.ReadLine());

            


            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            switch (calc)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, Math.AddNums(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, Math.SubtractNums(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, Math.MultiplyNums(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, Math.DivideNums(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            
            Console.ReadLine();
        }

        public static class Math
        {
            public static int MultiplyNums(int _num1, int _num2)
            {
                return _num1 * _num2;
            }

            public static int AddNums(int _num1, int _num2)
            {
                return _num1 + _num2;
            }

            public static int DivideNums(int _num1, int _num2)
            {
                return _num1 / _num2;
            }

            public static int SubtractNums(int _num1, int _num2)
            {
                return _num1 - _num2;
            }
        }
    }
}
