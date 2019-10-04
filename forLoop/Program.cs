using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             int number = 0;

             //int i = 0 -start of the loop, i <10 -stop; i++ -step
             for (int i = 0; i < 11; i++)
             {
                 Console.WriteLine($"i equals {i}");
             }

             Console.WriteLine();

             for (int j = 10; j > -1; j--)
             {
                 Console.WriteLine($"j equals {j}");
             }
            */

            int number = 0;
            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine($" {i}  bottles of beer on the wall, {i} bottles of beer. Take one down and pass it around, {i-1} bottles of beer on the wall");
            }
            Console.WriteLine();
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");

            Console.ReadLine();
        }



       
    }
}
