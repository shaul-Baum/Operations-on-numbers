using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static int Sum(int[] input)
        {
            int sum = 0;
            foreach (int item in input)
            {
                sum += item;
            }
            return sum;
        }
        static int Counter(int[] input)
        {
            int counter = 0;
            foreach (int item in input)
            {
                counter++;
            }
            return counter;
        }
        static double Average(int[] input)
        {
            int sum = 0;
            int counter = 0;
            foreach (int item in input)
            {
                sum += item;
                counter++;
            }
            double average = (double)sum / counter;
            return average;
        }
        static string[] Input(string[] args = null)
        {
            string[] inputr = new string[0];
            do
            {
                List<string> input = new List<string>();
                input.Clear();
                string a = "";
                Console.WriteLine("Please enter at least three credit numbers.");
                while (a != "exit")
                {
                    Console.WriteLine("Enter a number. To exit, press Exit:");
                    a = Console.ReadLine();
                    if (a != "exit")
                    {
                        input.Add(a);
                    }
                    else
                    {
                        break;
                    }


                }
                inputr = input.ToArray();

            }

            while (!(InputTester(inputr)));
            return inputr;
        }
        static int Min(int[] input)
        {
            int min = input[0];
            foreach (int item in input)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        static string[] InputInputConverterTester(string[] args = null)
        {
            string[] input = new string[0];

            if (!(InputTester(args)))
            {
                input = Input();
                return input;
            }
            else
            {
                return args;
            }
        }
        static int Mxs(int[] input)
        {
            int mxs = 0;
            foreach (int item in input)
            {
                if (item > mxs)
                {
                    mxs = item;
                }
            }
            return mxs;
        }
        static int[] ConverterType(string[] input)
        {
            int[] inputr = new int[input.Length];
            for (int item = 0; item < input.Length; item++)
            {
                inputr[item] = int.Parse(input[item]);
            }
            return inputr;
        }
        static int[] Sorting(int[] input)
        {
            int a;
            for (int y = 0; y < input.Length - 1; y++)
            {
                bool flag = true;
                for (int i = 0; i < input.Length - y - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        a = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = a;
                        flag = false;
                    }
                }
                if (flag)
                {
                    break;
                }
            }





            return input;
        }
        static bool InputTester(string[] input)
        {
            if (input.Length >= 3)
            {
                foreach (string item in input)
                {
                    try
                    {
                        int numbar = int.Parse(item);
                        if (numbar < 0)
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid value");
                        return false;
                    }
                }

            }
            else
            {
                return false;
            }
            return true;
        }
        static void PrintInReverse(string[] input)
        {
            string[] inputReverse = new string[input.Length];

            int s = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                inputReverse[s] = input[i];
                s++;
            }
            print(inputReverse);
            return;

        }
        static void printInt(int[] input)
        {
            foreach (int item in input)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
        static void print(string[] input)
        {
            foreach (string item in input)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            void Menu()
            {
                string[] input = InputInputConverterTester(args);
                string choice;
                int[] inputr;
                do
                {

                    Console.WriteLine(@"    To enter a new series, press 1
    To view the series as entered, press 2
    To view the series in reverse order, press 3
    To view the series sorted (lowest to highest), press 4
    To view the maximum value, press 5
    To view the minimum value, press 6
    To view the average of the series, press 7
    To view the number of elements, press 8
    To view the sum of the series, press 9
    To exit Press Exit");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            input = Input();
                            break;
                        case "2":
                            print(input);
                            break;
                        case "3":
                            PrintInReverse(input);
                            break;
                        case "4":
                            inputr = ConverterType(input);
                            int[] inputSorting = Sorting(inputr);
                            printInt(inputSorting);
                            break;
                        case "5":
                            inputr = ConverterType(input);
                            int mxs = Mxs(inputr);
                            Console.WriteLine(mxs); ;
                            break;
                        case "6":
                            inputr = ConverterType(input);
                            int min = Min(inputr);
                            Console.WriteLine(min);
                            break;
                        case "7":
                            inputr = ConverterType(input);
                            double average = Average(inputr);
                            Console.WriteLine(average);
                            break;
                        case "8":
                            inputr = ConverterType(input);
                            int counter = Counter(inputr);
                            Console.WriteLine(counter);
                            break;
                        case "9":
                            inputr = ConverterType(input);
                            int sum = Sum(inputr);
                            Console.WriteLine(sum);
                            break;

                        default:
                            Console.WriteLine("Invalid value");
                            break;



                    }
                }
                while (choice != "exit");
                return;



            }
            Menu();

        }
    }
}
