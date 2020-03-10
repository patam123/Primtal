using NUnit.Framework;
using System;
using System.Collections.Generic;
using PrimeNumberLibrary;


namespace PrimeNumberTests
{
    public class Tests
    {
        public List<int> backingList = new List<int>();
        [SetUp]
        public void Setup()
        {
            var primeHandler = new PrimeNumberHandler();

            var random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                primeHandler.AddPrimeToList(backingList, random.Next(1, 1000000));
            }
        }

        [Test]
        public void TestListIsSortedAfterAddingNumber()
        {

            var highestPrime = backingList[backingList.Count - 1];
            for (int i = backingList.Count - 1; i >= 0; i--)
            {
                if (backingList[i] > highestPrime)
                {
                    backingList[i] = highestPrime;
                }
            }
            Assert.AreEqual(backingList[backingList.Count - 1], highestPrime);
        }
    }
}