using System;
using System.Collections.Generic;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeList = new List<int>();
            while (true)
            {
                Console.Write(">: ");
                var input = Console.ReadLine().ToLower();
                if (Int32.TryParse(input, out int result))
                {
                    AddPrimeToList(primeList, result);
                }
                else if (input == "exit" || input == "quit")
                {
                    Environment.Exit(0);
                }
                else if (input == "print")
                {
                    PrintPrimes(primeList);
                }
                else if (input == "next")
                {
                    NextPrime(primeList);
                }
                else
                {
                    Console.WriteLine("Wrong input, a number is required");
                }
            }
        }
        static void AddPrimeToList(List<int> primeList, int primeNumber)
        {
            int primeCount = 0;
            for (int i = 1; i <= primeNumber; i++)
            {
                if (primeNumber % i == 0)
                {
                    primeCount++;
                }
            }
            if (primeCount == 2)
            {
                Console.WriteLine($"{primeNumber} is a Prime Number");
                primeList.Add(primeNumber);
                primeList.Sort();
            }
            else
            {
                Console.WriteLine($"{primeNumber} is not a Prime Number");
            }
        }
        static void PrintPrimes(IList<int> primeList)
        {
            for (int i = 0; i < primeList.Count; i++)
            {
                Console.WriteLine(primeList[i]);
            }
        }
        static void NextPrime(List<int> primeList)
        {
            bool isPrime = false;
            var primeNumber = primeList[primeList.Count - 1];
            while (!isPrime)
            {
                primeNumber++;
                int primeCount = 0;
                for (int i = 1; i <= primeNumber; i++)
                {
                    if (primeNumber % i == 0)
                    {
                        primeCount++;
                    }
                }
                if (primeCount == 2)
                {
                    primeList.Add(primeNumber);
                    isPrime = true;
                }
            }
        }
    }
}
