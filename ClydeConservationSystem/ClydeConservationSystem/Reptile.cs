using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal class Reptile : Animal
    {
        private float tank_temperature;
        private string environment;

        public Reptile()
        {

        }
        public void set_reptiles_details(ref int num_animals)
        {
            id = ++num_animals;  // remains the same

            Console.Write("Enter Animal name: ");
            animal_name = Console.ReadLine();

            Console.Write("Enter animal type: ");
            animal_type = Console.ReadLine();

            //getting the danger rating if the animal
            while (true)
            {
                Console.Write("Enter Danger Rating (1-5): ");
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
                {
                    danger_rating = Convert.ToInt32(input); // if the user input is between 1-5 it gets converted to an integer from a string
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input pease enter a number between 1-5");
                }
            }

            //here i am getting the sex of the aimal and its in a loop so that even when wrong they are returend to answer the question correctly
            while (true)
            {
                Console.Write("Enter sex (M/F): ");
                string input = Console.ReadLine();
                if (input == "M" || input == "m")  //now it doesn't matter if its a lowercase or an uppercase
                {
                    sex = 'M';
                    break;
                }

                if (input == "F" || input == "f")  //now it doesn't matter if its a lowercase or an uppercase
                {
                    sex = 'F';
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input select M/F");
                }

            }

            //getting the environment conditions
            Console.Write("Enter environment (wet/dry): ");
            environment = Console.ReadLine();

            //getting the tank temperature
            Console.Write("Enter tank temperature: ");
            tank_temperature = float.Parse(Console.ReadLine());

        }
        public string get_tank_temp()
        {
            return tank_temperature.ToString();
        }
        public string get_environment()
        {
            return environment;
        }
        // this is where all the details set above are going to be displayed
        public void print_reptile_details()
        {
            Console.WriteLine($"Animal Name: {animal_name}");
            Console.WriteLine($"Animal Type: {animal_type}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Danger Rating: {danger_rating}");
            Console.WriteLine($"Tank Temperature: {tank_temperature:F1}");
            Console.WriteLine($"Environment: {environment}");

            calculate_insurance(danger_rating);  //calling this method so that the insurance gets calculated 
        }

        // this calculates and gives you the danger rating of the reptikles and they all have a base value
        public override double calculate_insurance(int danger_rating)
        {
            double baseValue = 1000;
            double insurance = 0;
            if (danger_rating == 1)
            {
                insurance = baseValue * 10 * 0.05;
            }

            else if (danger_rating == 2)
            {
                insurance = baseValue * 20 * 0.10;
            }

            else if (danger_rating == 3)
            {
                insurance = baseValue * 30 * 0.15;
            }

            else if (danger_rating == 4)
            {
                insurance = baseValue * 40 * 0.15;
            }

            else if (danger_rating == 5)
            {
                insurance = baseValue * 50 * 0.20;
            }

            else
            {
                Console.WriteLine("Invalid danger rating! Must be between 1-5");
            }

            Console.WriteLine($"Insurance cost: £{insurance}");
            return insurance;
        }
    }
    

}
