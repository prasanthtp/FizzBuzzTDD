using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Classes;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzUnitTests
    {

        [TestMethod]
        public void sampleTest()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void FizzBuzz_When1_Returns1()
        {
            int input = 1;
            string output = FizzBuzzClass.PrintNumber(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestMethod]
        public void FizzBuzz_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzzClass.PrintNumber(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestMethod]
        public void FizzBuzz_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzClass.PrintNumber(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void FizzBuzz_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzzClass.PrintNumber(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void FizzBuzz_When15_ReturnsFizzBuzz()
        {
            int input = 15;
            string output = FizzBuzzClass.PrintNumber(input);
            Assert.AreEqual("FizzBuzz", output);
        }

        [TestMethod]
        public void FizzBuzz_WhenDefault_ReturnsInputIntegerAsString()
        {

            var defaultNumbers = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29 };
            foreach (var input in defaultNumbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreEqual(input.ToString(), output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDivisibleBy3_ReturnsFizz()
        {
            var divOnlyBy3Numbers = new List<int> { 3, 6, 9, 12, 18, 21, 24 };
            foreach (var input in divOnlyBy3Numbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreEqual("Fizz", output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDivisibleBy5_ReturnsBuzz()
        {
            var divOnlyBy5Numbers = new List<int> { 5, 10, 20, 25 };
            foreach (var input in divOnlyBy5Numbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreEqual("Buzz", output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDivisibleBy3And5_ReturnsFizzBuzz()
        {
            var divBy3And5Numbers = new List<int> { 15, 30, 45, 60, 75, 90 };
            foreach (var input in divBy3And5Numbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreEqual("FizzBuzz", output);
            }
        }

 

        [TestMethod]
        public void FizzBuzz_WhenDefault_Not_ReturnsFizz()
        {
            var defaultNumbers = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29 };
            foreach (var input in defaultNumbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreNotEqual("Fizz", output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDefault_Not_ReturnsBuzz()
        {
           var  defaultNumbers = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29 };
            foreach (var input in defaultNumbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreNotEqual("Buzz", output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDefault_Not_ReturnsFizzBuzz()
        {
            var defaultNumbers = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29 };
            foreach (var input in defaultNumbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreNotEqual("FizzBuzz", output);
            }
        }

        [TestMethod]
        public void FizzBuzz_WhenDivisibleOnlyBy3_NotReturnsFizzBuzz()
        {
            var divOnlyBy3Numbers = new List<int> { 3, 6, 9, 12, 18, 21, 24 };
            foreach (var input in divOnlyBy3Numbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreNotEqual("FizzBuzz", output);
            }
        }


        [TestMethod]
        public void FizzBuzz_WhenDivisibleOnlyBy5_NotReturnsFizzBuzz()
        {
            var divOnlyBy5Numbers = new List<int> { 5, 10, 20, 25 };
            foreach (var input in divOnlyBy5Numbers)
            {
                string output = FizzBuzzClass.PrintNumber(input);
                Assert.AreNotEqual("FizzBuzz", output);
            }
        }
    }
}