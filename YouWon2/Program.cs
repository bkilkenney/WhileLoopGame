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
            int i = 0;
            Console.WriteLine("Pick an integer.");
            int usersAnswer = int.Parse(Console.ReadLine());
            
            for (i = 0; i < int.MaxValue; i++)
            {
                for(i = 0; i % 3 !=0; i++)


                
                {
                    Console.WriteLine("You lost.");
                }


                Console.WriteLine("You won.");
                break;
       
            }
        }
    }
}
