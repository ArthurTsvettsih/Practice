using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets;

namespace Practice
{
    class Program
    {
        //TODO: Extract everything from static Main to a non static Menu class, which will create the menu from the constructor
        static void Main(string[] args)
        {
            HandleCategoryMenu();
            Console.ReadKey(); // Stop the application from closing at the end
        }

        private static void HandleCategoryMenu()
        {
            Console.WriteLine("Please select a category: ");
            Console.WriteLine("1) Data Structures");

            var input = GetUserMenuSelection();

            switch (input)
            {
                case 1:
                    {
                        HandleDataStructureMenu();
                        break;
                    }
                default:
                    {
                        HandleMenuDefaultCase();
                        break;
                    }
            }

        }

        //TODO: Add input checks
        private static int GetUserMenuSelection()
        {
            var rawInput = Console.ReadKey().KeyChar;
            var input = Int32.Parse(rawInput.ToString());

            PrintEmptyLines(2);

            return input;
        }

        private static void PrintEmptyLines(int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
            }
        }

        private static void HandleDataStructureMenu()
        {
            Console.WriteLine("Please select a topic: ");
            Console.WriteLine("1) Arrays");

            var input = GetUserMenuSelection();

            switch (input)
            {
                case 1:
                    {
                        HandleArrayMenu();
                        break;
                    }
                default:
                    {
                        HandleMenuDefaultCase();
                        break;
                    }
            }
        }

        private static void HandleArrayMenu()
        {
            //TODO: Use reflection to get the list of arrays
            Console.WriteLine("Please select a topic: ");
            Console.WriteLine("1) How To Create An Array");
            Console.WriteLine("2) How To Resize An Array");
            Console.WriteLine("3) How To Create And Resize Array Lists");
            Console.WriteLine("4) How To Create And Resize Lists");

            var input = GetUserMenuSelection();

            switch (input)
            {
                case 1:
                    {
                        ArraysPractice.HowToCreateAnArray();
                        break;
                    }
                case 2:
                    {
                        ArraysPractice.HowToResizeAnArray();
                        break;
                    }
                case 3:
                    {
                        ArraysPractice.HowToCreateAndResizeArrayLists();
                        break;
                    }
                case 4:
                    {
                        ArraysPractice.HowToCreateAndResizeLists();
                        break;
                    }
                default:
                    {
                        HandleMenuDefaultCase();
                        break;
                    }
            }
        }

        private static void HandleMenuDefaultCase()
        {
            Console.WriteLine("Restart the application and enter a valid number");
            Console.ReadKey();
        }
    }
}
