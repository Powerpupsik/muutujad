using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutused
{
    class Program
    {
        static void Main(string[] args)
        {

            //HARJUTUS 1- number pos, neg või 0
            /* Start:
             Console.WriteLine("Enter a number");
             int userNumber;
             userNumber = int.Parse(Console.ReadLine());


             if (userNumber > 0)
             {
                 Console.WriteLine("Your number is positive");
             }
             else if (userNumber < 0)
             {
                 Console.WriteLine("Your number is negative");
             }
             else
             {
                 Console.WriteLine("Your number is equal with zero");
             }

             goto Start;*/


            //HARJUTUS 2- jagub 2 või 11

           /* Console.WriteLine("Enter a number");
            int userNumber;
            userNumber = int.Parse(Console.ReadLine());

            {

                if (userNumber % 5 == 0)
                {
                    Console.WriteLine("your number divides with 5");
                }
                else if (userNumber % 11 == 0)
                {
                    Console.WriteLine("your number divides with 11");
                }
                else
                {
                    Console.WriteLine("your number doesn't divide with 5 or 11");
                }
            }*/

            //HARJUTUS 3- number is even or odd

            Console.WriteLine("Enter a number");
            int userNumber;
            userNumber = int.Parse(Console.ReadLine());

            {
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("your number is even");
                }
                else
                {
                    Console.WriteLine("your number is odd");
                }
            }

            //HARJUTUS 4- KASUTAJA TÄHT ON TÄISH. VÕI KAASH. (switchid või ifid; lüh.versioon massiividega)

            Console.WriteLine("Enter a letter");
            string userLetter;
            userLetter = int.Parse(Console.ReadLine());

            if (userLetter == { })
            {

            }


            Console.ReadLine();
        }

    }
}
