using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservationSystem
{
    internal class Cage
    {
        private int cage_id;
        int[] cage_count = new int[7];

        public Cage()
        {
            cage_id = 1;
            cage_count[0] = 4; //number of cage types of type1
            cage_count[1] = 2;
            cage_count[2] = 2;
            cage_count[3] = 1;
            cage_count[4] = 3;
            cage_count[5] = 2;
            cage_count[6] = 1;
        }

        public void assign_cage()
        {
            // Based on available cages, enter cage id to be allocated.
            // Take one away from the selected cage.
            try   // adding a try catch here to catch the erorr of an empty cage
            {
                // this asks the user which cage they want to allocate
                Console.Write("Enter cage id to be allocated: ");
                cage_id = int.Parse(Console.ReadLine());
                cage_id--;

                // this checks if there are cages available of that type
                if (cage_count[cage_id] > 0)
                {
                    cage_count[cage_id]--;
                    Console.WriteLine("Cages left of type " + (cage_id + 1) + ": " + cage_count[cage_id]); // this displays the cages are left
                }
                else
                {
                    Console.WriteLine("No cages of this type are available."); // if there are no cages left inform the user
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Cage ID. Cage does not exist.");   // this runs if user enters a number outside the array range

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");  // this runs if user enters something that is not a number
            }
        }//end of method

        public void check_cage_availability(ref Cage c1)// called from keeper class
        {
            // what cages are available

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Cage type " + (i + 1) + ": " + c1.cage_count[i]);
            }

            // call assign_cage for object c1
            c1.assign_cage();
        }//end of method
    }
}
