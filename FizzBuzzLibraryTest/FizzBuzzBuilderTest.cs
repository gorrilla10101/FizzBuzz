using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLibrary;
using Xunit;

namespace FizzBuzzLibraryTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData("Fizz", 3, 15, "15: Fizz")]
        [InlineData("Buzz", 5, 25, "25: Buzz")]
        [InlineData("Wizz", 7, 42, "42: Wizz")]
        [InlineData("Bang", 11, 66, "66: Bang")]
        public void SingleComparatorReturnsCorrectText(string text, int numberToCompare, int number, string expected)
        {
            var comparators = new List<IFizzBuzzNumberComparator>{
                new ModulusFizzBuzzComparator(text, numberToCompare)
            };
            var bizzBuzz = new FizzBuzzBuilder(comparators);
            var result = bizzBuzz.GetFizzBuzz(number);
            Assert.Equal(expected,result.ToString());
        }

        [Fact]
        public void GeneratesFizzBuzzWizzBang()
        {
            var comparators = new List<IFizzBuzzNumberComparator>{
                new ModulusFizzBuzzComparator("Fizz",3),
                new ModulusFizzBuzzComparator("Buzz",5),
                new ModulusFizzBuzzComparator("Wizz",7),
                new ModulusFizzBuzzComparator("Bang",11)
            };
            var builder = new FizzBuzzBuilder(comparators);
            IEnumerable<int> range = Enumerable.Range(1, 100);
            var results = builder.GetFizzBuzz(range);
            foreach(var result in results)
            {
                if(result.Key % 3 == 0)
                {
                    Assert.Contains("Fizz",result.Value);
                }
                if(result.Key % 5 == 0)
                {
                    Assert.Contains("Buzz",result.Value);
                }
                if(result.Key % 7 == 0)
                {
                    Assert.Contains("Wizz",result.Value);
                }
                if(result.Key % 11 == 0)
                {
                    Assert.Contains("Bang",result.Value);
                }               
            }
        }
    }
}
