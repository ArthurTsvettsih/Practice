using System;
using Practice.DataSets;

namespace Practice
{
    class Program
    {
        //TODO: Extract everything from static Main to a non static Menu class, which will create the menu from the constructor
        //TODO: Then further extract stuff into their own files as this file will get very large very fast due to all the switch statements
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
            Console.WriteLine("1) Arrays, ArrayLists, Lists");
            Console.WriteLine("2) Queues, Stacks, Hashtables");

            var input = GetUserMenuSelection();

            switch (input)
            {
                case 1:
                    {
                        HandleArrayMenu();
                        break;
                    }
                case 2:
                    {
                        HandleQueueStackHashtableMenu();
                        break;
                    }
                default:
                    {
                        HandleMenuDefaultCase();
                        break;
                    }
            }
        }

        private static void HandleQueueStackHashtableMenu()
        {
            //TODO: Use reflection to get the list of function names
            Console.WriteLine("Please select a topic: ");
            Console.WriteLine("1) How To Enqueue and Dequeue in a Queue");
            Console.WriteLine("2) How To Peek in a Queue");
            Console.WriteLine("3) How To Push and Pop in a Stack");
            Console.WriteLine("4) How To Hashtable");
            Console.WriteLine("5) How To Dictionary");

            var input = GetUserMenuSelection();

            switch (input)
            {
                case 1:
                    {
                        QueueStackHashtablePractice.HowToEnqueueAndDequeue();
                        break;
                    }
                case 2:
                    {
                        QueueStackHashtablePractice.HowToPeekInAQueue();
                        break;
                    }
                case 3:
                    {
                        QueueStackHashtablePractice.HowToStack();
                        break;
                    }
                case 4:
                    {
                        QueueStackHashtablePractice.HowToHashtable();
                        break;
                    }
                case 5:
                    {
                        QueueStackHashtablePractice.HowToDictionary();
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
            //TODO: Use reflection to get the list of function names
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
