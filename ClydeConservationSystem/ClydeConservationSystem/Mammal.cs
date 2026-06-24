using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal class Mammal : Animal
    {
        private string mate_name;
        private string given_birth;

        public Mammal()
        {

        }

        public void set_mammal_details(ref int num_animals)
        {

            id = ++num_animals;

            Console.Write("Enter Animal name: ");
            animal_name = Console.ReadLine();

            Console.Write("Enter animal type: ");
            animal_type = Console.ReadLine();

            //getting the danger rating if the animal
            while (true)
            {
                Console.Write("Enter Danger Rating (1-5): ");
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5") // making sure only 1-5 will be accepted
                {
                    danger_rating = Convert.ToInt32(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input please enter a number between 1-5");
                }
            }

            //getting the mate name
            Console.Write("Enter mate name: ");
            mate_name = Console.ReadLine();

            //here i am getting the sex of the aimal and its in a loop so that even when wrong they are returend to answer the question correctly
            while (true)
            {
                Console.Write("Enter sex (M/F): ");
                string input = Console.ReadLine();

                if (input == "M" || input == "m")
                {
                    sex = 'M';
                    given_birth = "N"; // made this char n because males can't give birth
                    break;
                }
                else if (input == "F" || input == "f")
                {
                    sex = 'F';
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input select M/F");
                }
            }

            // this is only called upon if the animal is a female
            if (sex == 'F')
            {
                while (true)
                {
                    Console.Write("Has animal given birth (Y/N): ");
                    string input = Console.ReadLine();

                    // this is used so that even if the user enters a lowecase or uppercase it wouldn't matter as it'll runs fine
                    if (input == "Y" || input == "N" || input == "y" || input == "n")
                    {
                        given_birth = input.ToUpper();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input - select Y or N");
                    }
                }
            }
            else
            {
                given_birth = "N"; // this just returns N because males dont give birth
            }

        }
        public string get_mate_name()
        {
            return mate_name;
        }

        public string get_given_birth()
        {
            return given_birth;
        }
        // printing out the details of the mammals to be displayed
        public void print_mammal_details()
        {
            Console.WriteLine($"Animal Name: {animal_name}");
            Console.WriteLine($"Animal Type: {animal_type}");
            Console.WriteLine($"Animal ID: {id}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Danger Rating: {danger_rating}");
            Console.WriteLine($"Mate name: {mate_name}");
            Console.WriteLine($"Given birth: {given_birth}");

            calculate_insurance(danger_rating);  //calling this method so that the insurance gets calculated
        }
        // calculating the danger rating of the mamals 
        public override double calculate_insurance(int danger_rating)
        {
            double baseValue = 5000;
            double insurance = 0;
            if (danger_rating == 1)
            {
                insurance = baseValue * 10 * 0.02;
            }

            else if (danger_rating == 2)
            {
                insurance = baseValue * 20 * 0.05;
            }

            else if (danger_rating == 3)
            {
                insurance = baseValue * 30 * 0.05;
            }

            else if (danger_rating == 4)
            {
                insurance = baseValue * 40 * 0.05;
            }

            else if (danger_rating == 5)
            {
                insurance = baseValue * 50 * 0.10;
            }

            else
            {
                Console.WriteLine("Invalid danger rating! Must be between 1-5");   // error checking for incorrect digits entered
            }
            Console.WriteLine($"Insurance cost: £{insurance}");
            return insurance;
        }
    }
}
