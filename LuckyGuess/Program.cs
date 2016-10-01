using Framework;
using System;

namespace LuckyGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = AutoGenerator.GetRandomNumber();
            int nextNumber;
            Console.WriteLine($"Guess if next is smaller or bigger S/B?");
            while (true)
            {                
                nextNumber = AutoGenerator.GetRandomNumber();
                Console.WriteLine($"Number is {number}");
                while (true)
                {                       
                    ConsoleKeyInfo name = Console.ReadKey(true);
                    if (name.KeyChar == 's' && nextNumber <= number)
                    {
                        Console.WriteLine($"You won!");
                        break;
                    }
                    else if (name.KeyChar == 's' && nextNumber > number)
                    {
                        Console.WriteLine($"You lose!");
                        break;
                    }
                    else if (name.KeyChar == 'b' && nextNumber >= number)
                    {
                        Console.WriteLine($"You won!");
                        break;
                    }
                    else if (name.KeyChar == 'b' && nextNumber < number)
                    {
                        Console.WriteLine($"You lose!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Try again");
                    }
                }
                number = nextNumber;
            }
        }
    }
}
