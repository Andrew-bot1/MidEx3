using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidEx3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool exit = false;
            double[] numbers = { };

            while (!exit)
            {
                Console.WriteLine("1. Add a number to the array");
                Console.WriteLine("2. Display all numbers of the array");
                Console.WriteLine("3. Display the sum of all numbers in the array");
                Console.WriteLine("4. Display the greatest and lowest number in the array");
                Console.WriteLine("5. Display all numbers in reverse order");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNumber();
                        break;
                    case 2:
                        DisplayNumber();
                        break;
                    case 3:
                        DisplaySum();
                        break;
                    case 4:
                        DisplayGreatestAndLowest();
                        break;
                    case 5:
                        DisplayReverse();
                        break;
                    case 6:
                        exit = true;
                        return;
                }
            }

        }

        static void AddNumber()
        {
            Console.WriteLine("Enter a number to add: ");
            double number = Convert.ToDouble(Console.ReadLine());
            numbers.Add(number);
        }
        static void DisplayNumber()
        {
            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void DisplaySum()
        {
            
            Console.WriteLine("The sum of all numbers is: " + numbers.sum());
        }
        static void DisplayGreatestAndLowest()
        {
            Console.WriteLine("The greatest number is: " + numbers.Max());
            Console.WriteLine("The lowest number is: " + numbers.Min);
        }
        static void DisplayReverse()
        {
            Queue<double> revNum = new Queue<double>();
            foreach (double number in numbers)
            {
                revNum.Enqueue(number);
            }
            foreach (double number in revNum)
            {
                Console.WriteLine(number);
            }
        }
    }
}
