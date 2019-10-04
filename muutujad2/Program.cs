using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muutujad2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Start:
            string name;
            int cpuNumber;
            int tries = 0;
            bool gameOver = false;

            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 6);


            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} ");

            //gameOver = NOT gameOver = true
            while (!gameOver)
            {
                int userNumber;
                Console.WriteLine("Try to guess the numbe:");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine("CPU number is smaller.");
                }
                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine("CPU number is bigger.");
                }
                else
                {
                    Console.WriteLine("You won! Play again? Y/N");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToUpper() == "Y")
                    {
                        goto Start;
                    }
                    
                    else
                    {
                        Console.WriteLine("Game over");
                        gameOver = true;
                    }
                }


            }


            Console.ReadLine();

        }
    }
}
