using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal abstract class Animal
    {

        // these are protected which means that only thius classs and reptiles and mammals can access their variables 
        protected int id;
        protected string animal_name;
        protected string animal_type;
        protected int danger_rating;
        protected char sex;

        // these getter methods ar used to return the values of the protected variable
        public void set_animal_details(ref int num_animals)
        {

        }
        public int get_id()
        {
            return id;
        }
        public string get_animal_name()
        {
            return animal_name;
        }
        public string get_animal_type()
        {
            return animal_type;
        }
        public int get_danger_rating()
        {
            return danger_rating;
        }
        public char get_sex()
        {
            return sex;
        }

        public void print_animal_details()
        {
            Console.Write($"ID {id}:");
            Console.Write($"Animal name: {animal_name}");
            Console.Write($"Animal Type: {animal_type}");
            Console.Write($"Danger Rating: {danger_rating}");
            Console.Write($"Sex: {sex}");
        }

        public virtual double calculate_insurance(int danger_rating)
        {
            return 0;
        }
    }
}
