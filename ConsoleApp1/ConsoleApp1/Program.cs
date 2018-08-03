using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task_2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            bool check = true;
            do
            {
                    Console.Clear();
                    Console.WriteLine("Exercises Week 2");
                    Console.WriteLine("1) Basic Calculator");
                    Console.WriteLine("2) Area Calculator");
                    Console.WriteLine("3) Exit");
                    Console.WriteLine("Please enter the number of your selection");
                    //selection = int.Parse(Console.ReadLine());
                    check = int.TryParse(Console.ReadLine(), out selection);
                if (check == false)
                {
                    Console.WriteLine("Invalid choice, Please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else
                {
                    switch (selection)
                    {
                        case 1:
                            Task1.Program.Main();
                            break;
                        case 2:
                            Task_2.Program.Main();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid choice, Please enter a number between 1 and 3");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                    }
                }
                
            } while (selection != 3);
        }
    }
}
