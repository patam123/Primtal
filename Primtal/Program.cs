using System;
using System.Collections.Generic;
using PrimeNumberLibrary;

namespace Primtal
{
    public class Program
    {
        static void Main(string[] args)
        {
            var primeHandler = new PrimeNumberHandler();
            var primeList = new List<int>();
            Console.WriteLine("Enter a number to find out if it is a prime.");
            Console.WriteLine();
            Console.WriteLine("If you would like to see all your entered numbers that is prime, type 'print'.");
            Console.WriteLine("If you would like to add the next prime number based on the highest number that you entered, type 'next'.");
            Console.WriteLine("To stop the execution of this application, type 'exit', 'quit' or 'stop'.");
            while (true)
            {
                Console.Write(">: ");
                var input = Console.ReadLine().ToLower();
                if (Int32.TryParse(input, out int result))
                {
                    if (primeHandler.CheckIfNumberIsPrime(result))
                    {
                        Console.WriteLine($"{result} is a Prime Number");
                        if (!primeList.Contains(result))
                        {
                            primeHandler.AddPrimeToList(primeList, result);
                            primeHandler.SortPrimeList(primeList);
                            Console.WriteLine($"{result} was added to the list");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{result} is already in the list");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{result} is not a Prime Number");
                        Console.WriteLine();
                    }
                }
                else if (input == "exit" || input == "quit" || input == "stop")
                {
                    Environment.Exit(0);
                }
                else if (input == "print")
                {
                    primeHandler.PrintPrimes(primeList);
                    Console.WriteLine();
                }
                else if (input == "next")
                {
                    var nextPrime = primeHandler.NextPrime(primeList);
                    Console.WriteLine($"{nextPrime} was added to the list.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong input, a number is required");
                    Console.WriteLine();
                }
            }
        }

    }
}
