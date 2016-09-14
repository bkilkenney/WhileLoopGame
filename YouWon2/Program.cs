using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWon2
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersNumber;
            while (true)
            {
                Console.WriteLine("Pick an integer");
                usersNumber = int.Parse(Console.ReadLine());

                if (usersNumber % 3 != 0)
                {
                    Console.WriteLine("You lost");
                }

//It goes from the IF back to the top, the writeline doesn't effect where it goes in the loop 


                else
                {
                    Console.WriteLine("You Won!");
                    
//Same as before, the writeline doesn't make it stop, break does
                }
            }
        }
    }
}
