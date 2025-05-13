using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool InputTester(string[] input = null)
            {
                if (input == null)
                {
                    input = args;
                }
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
            string[] Input()
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
            string[] InputInputConverterTester()
            {
                string[] input = new string[0];

                if (!(InputTester()))
                {
                    input = Input();
                    return input;
                }
                else
                {
                    return args;
                }
            }
            void print(string[] input)
            {
                foreach (string item in input)
                {
                    Console.Write(item + " ");
                }
            }
            void PrintInReverse(string[] input)
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

            void Menu()
            {
                string[] input = InputInputConverterTester();
                string choice;
                do
                {

                    Console.WriteLine(@"To enter a new series, press 1
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
                            //case "4":



                    }
                }
                while (choice != "exit");
                return;



            }
            Menu();

        }
    }
}
