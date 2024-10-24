using System;

namespace HierarchicalMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            bool exit = false;

            // Loop for the main menu
            while (!exit)
            {
                // Display the main menu
                Console.Clear(); // Clear the console for better readability
                Console.WriteLine("Welcome to the Computer Hardware Menu!");
                Console.WriteLine("Please choose a category:");
                Console.WriteLine("a. CPU");
                Console.WriteLine("b. Memory (RAM)");
                Console.WriteLine("c. Storage");
                Console.WriteLine("d. Exit");

                // Get user input
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line

                // Process the main menu selection
                switch (choice)
                {
                    case 'a':
                        HandleCpuMenu();
                        break;
                    case 'b':
                        HandleMemoryMenu();
                        break;
                    case 'c':
                        HandleStorageMenu();
                        break;
                    case 'd':
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        Console.ReadKey(); // Wait for user to acknowledge
                        break;
                }
            }
        }

        static void HandleCpuMenu()
        {
            char choice;
            // CPU Submenu
            Console.Clear();
            Console.WriteLine("CPU Options:");
            Console.WriteLine("a. Intel");
            Console.WriteLine("b. AMD");
            Console.WriteLine("c. Back to main menu");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("You chose Intel CPUs.");
                    break;
                case 'b':
                    Console.WriteLine("You chose AMD CPUs.");
                    break;
                case 'c':
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void HandleMemoryMenu()
        {
            char choice;
            // Memory Submenu
            Console.Clear();
            Console.WriteLine("Memory (RAM) Options:");
            Console.WriteLine("a. DDR4");
            Console.WriteLine("b. DDR5");
            Console.WriteLine("c. Back to main menu");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("You chose DDR4 RAM.");
                    break;
                case 'b':
                    Console.WriteLine("You chose DDR5 RAM.");
                    break;
                case 'c':
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void HandleStorageMenu()
        {
            char choice;
            // Storage Submenu
            Console.Clear();
            Console.WriteLine("Storage Options:");
            Console.WriteLine("a. HDD");
            Console.WriteLine("b. SSD");
            Console.WriteLine("c. Back to main menu");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("You chose HDD storage.");
                    break;
                case 'b':
                    Console.WriteLine("You chose SSD storage.");
                    break;
                case 'c':
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

