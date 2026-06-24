using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal class Mammal_array
    {
        private int count = 0;
        private int num_animals = 1;
        private Mammal[] mammal_list = new Mammal[5];

        public void add_mam_list()
        {
            if (count < mammal_list.Length)
            {
                mammal_list[count] = new Mammal();
                mammal_list[count].set_mammal_details(ref num_animals);
                count++;

                Console.WriteLine("Mammal added to list");
            }
            else
            {
                Console.WriteLine("Mammal list is full.");
            }
        }
        //printing all animals in the array
        public void print_mam_list()
        {
            if (count == 0)
            {
                Console.WriteLine("No mammals to display");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Mammal: "+(i+1) + "    ");
                    mammal_list[i].print_mammal_details();
                }
            }
        }

    }
}
