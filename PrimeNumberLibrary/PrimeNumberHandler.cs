using System;
using System.Collections.Generic;
namespace PrimeNumberLibrary
{
    public class PrimeNumberHandler
    {
        public bool CheckIfNumberIsPrime(int number) // outofrangeexception måste hanteras? t.ex ifall en siffra mindre än ett skrivs in kommer loopen fortsätta
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
                if (count > 2)
                {
                    return false;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddPrimeToList(List<int> primeList, int primeNumber)
        {
                primeList.Add(primeNumber);
        }
        public void SortPrimeList(List<int> primeList)
        {
            primeList.Sort(); // göra egen sorteringsalgoritm?
        }
        public void PrintPrimes(IList<int> primeList)
        {
            for (int i = 0; i < primeList.Count; i++)
            {
                Console.WriteLine(primeList[i]);
            }
        }
        public int NextPrime(List<int> primeList)
        {
            var primehandler = new PrimeNumberHandler();
            bool isPrime = false;
            var primeNumber = primeList[primeList.Count - 1];
            while (!isPrime)
            {
                primeNumber++;
                if (primehandler.CheckIfNumberIsPrime(primeNumber))
                {
                    primehandler.AddPrimeToList(primeList, primeNumber);
                    isPrime = true;
                }
            }
            return primeNumber;
        }
    }
}
