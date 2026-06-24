using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal class Keeper
    {
        int keeper_id;
        int[] cages_allocated = new int[4]; //up to 4 keepers for test purposes only

        public Keeper()
        {
            keeper_id = 0;
            cages_allocated[0] = 0; //each keeper will have no cages allocated initially for test purposes
            cages_allocated[1] = 0;
            cages_allocated[2] = 0;
            cages_allocated[3] = 0;
        }

        public void set_keeper_id(ref Keeper k1, ref Cage c1)
        {
            // user will input the keeper to be allocated a cage.
            // set_keeper_cage will be called to check if Keeper is not at their maximum of 4 cages, If not they will be allocated a cage.

            try  // adding a try catch here to catch the erorr of going over the range of keepers
            {
                Console.Write("Enter the Keeper ID that requires a cage: ");
                keeper_id = int.Parse(Console.ReadLine());
                keeper_id--;  // im adjusting this for the index

                int test = cages_allocated[keeper_id];

                k1.set_keeper_cage(ref c1);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Keeper ID. Keeper does not exist."); // error message when a keeper outside 1-4 is added 
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number."); // when anything other than numbers 1-4 is added 
            }
        }

        public int get_keeper_id()
        {
            keeper_id++;
            return keeper_id;
        }

        public void set_keeper_cage(ref Cage c1)
        {
            // checks to see that keeper has not been allocated their maximum (4)
            //If they have, print a message to that effect.If they haven’t, check avaialability of cages and allocate.

            if (cages_allocated[keeper_id] + 1 >= 0 && cages_allocated[keeper_id] + 1 <= 4)
            {
                // call check_cage_availability from cage class
                c1.check_cage_availability(ref c1);

                // add 1 to array element to keep track of the amount of cages for the keeper
                cages_allocated[keeper_id]++;

                Console.WriteLine("Keeper " + get_keeper_id() + " has " + cages_allocated[keeper_id = keeper_id - 1] + " cages");
            }
            else
            {
                // print message that the Keeper has reached the maximum number of cages allocated
                Console.WriteLine("Keeper " + (keeper_id + 1) +
                " has reached the maximum number of cages allocated.");
            }//end of if statement

        }//end of method
    }
}
