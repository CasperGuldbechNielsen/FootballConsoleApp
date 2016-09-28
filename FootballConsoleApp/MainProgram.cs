using System;
using System.Diagnostics;

namespace FootballConsoleApp
{
    public class MainProgram
    {
        public MainProgram()
        {
            int x = ShowMenu();

            switch (x)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;

            }
        }

        private int ShowMenu()
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1. Show league standing \n" +
                              "2. Show news \n" +
                              "3. Show upcomming matches");

            string input = Console.ReadLine();

            int output = Int32.Parse(input);

            return output;
        }
    }
}