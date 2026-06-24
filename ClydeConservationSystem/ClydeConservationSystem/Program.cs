namespace ClydeConservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_animals = 0;
            Mammal[] mammal_list = new Mammal[5];   // new object has been created, here i instantiated a new object of the mammal class 

            Reptile rep = new Reptile(); // here i instantiated a new object of the reptile class

            //these are new object for part 2 of the assesment
            Keeper k1 = new Keeper();
            Cage c1 = new Cage();

            while (true)
            {
                //This is going to be the maim menu of the program
                Console.WriteLine("Clyde Conversation System:");
                Console.WriteLine("1. Mammal");
                Console.WriteLine("2. Reptile");
                Console.WriteLine("3. Keeper Cage Allocation"); // this is the newly added option
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    while (true)  // in a loop so even when wrong the user still has a chance to answer correctly
                    {
                        // this is a sub menu of the mammal menu,
                        Console.WriteLine("1. Add Mammal");
                        Console.WriteLine("2. Print Mammal Details");
                        Console.WriteLine("3.Back to Main Menu");
                        Console.Write("Enter choice: ");
                        string mamChoice = Console.ReadLine();  // user input is stored in teh "mamChoice" variable

                        if (mamChoice == "1")
                        {
                            if (num_animals < mammal_list.Length)
                            {
                                mammal_list[num_animals] = new Mammal();
                                mammal_list[num_animals].set_mammal_details(ref num_animals);
                            }
                            else
                            {
                                Console.WriteLine("No space left in mammal list.");
                            }
                        }

                        else if (mamChoice == "2")
                        {
                            if (num_animals == 0)
                            {
                                Console.WriteLine("No mammals to display.");
                            }
                            else
                            {
                                for (int i = 0; i < num_animals; i++)
                                {
                                    mammal_list[i].print_mammal_details();
                                    Console.WriteLine("----------------------");
                                }
                            }
                        }

                        else if (mamChoice == "3")
                        {
                            Console.WriteLine("Returning to the main menu");
                            break;            // users are sent back to the main menu here
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Enter a number between 1-3"); // Error handling just in case a user enters a number other than 1. 2 or 3
                        }
                    }
                }

                if (choice == "2")
                {
                    // this is the sub menu of the reptile menu
                    while (true)
                    {
                        Console.WriteLine("Welcome to the Reptile Menu:");
                        Console.WriteLine("1. Add Reptile");
                        Console.WriteLine("2. Print Reptile Details");
                        Console.WriteLine("3. Back to the Main Menu");
                        Console.Write("Enter Choice: ");
                        string repChoice = Console.ReadLine();

                        if (repChoice == "1")
                        {
                            rep.set_reptiles_details(ref num_animals);
                        }
                        else if (repChoice == "2")
                        {
                            rep.print_reptile_details();
                        }
                        else if (repChoice == "3")
                        {
                            Console.WriteLine("Returning to the Main Menu"); 
                            break;                 // This break statement is meant to take the users back to the main menu
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Enter a valid number from 1-3."); // Error handling just in case a user enters a number other than 1. 2 or 3
                        }
                    }
                }
                // this is the keeper sectiiomn 
                if (choice == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Keeper Menu:");
                        Console.WriteLine("1. Allocate Cage to Keeper");
                        Console.WriteLine("2. Back to Main Menu");
                        Console.Write("Enter choice: ");
                        string keepChoice = Console.ReadLine();

                        if (keepChoice == "1")
                        {
                            k1.set_keeper_id(ref k1, ref c1);
                        }
                        else if (keepChoice == "2")
                        {
                            Console.WriteLine("Returning to Main Menu");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Enter 1 or 2.");
                        }
                    }
                }

                if (choice == "4")
                {
                    Console.WriteLine("Exiting the program. Goodbye!!");
                    break;  // This completely exits the user from ythe program once 3 is clicked
                }

            }
        }
    }
}
