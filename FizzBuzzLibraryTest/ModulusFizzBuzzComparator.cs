using System;
using System.Collections.Generic;
using FizzBuzzLibrary;
using Xunit;

namespace FizzBuzzLibraryTest
{
    public class ModulusFizzBuzzComparatorTest
    {
        [Theory]
        [InlineData(3,3)]
        [InlineData(3,15)]
        [InlineData(5,15)]
        [InlineData(7,77)]
        [InlineData(11,44)]
        [InlineData(8,64)]
        public void ReturnsTrueWhenModulusIsZero(int modNumber, int number)
        {
            var comparator = new ModulusFizzBuzzComparator("Does Not Matter For Test", modNumber);
            Assert.True(comparator.IsMatch(number));
        }

        [Theory]
        [InlineData(3,4)]
        [InlineData(3,5)]
        [InlineData(5,19)]
        [InlineData(7,79)]
        [InlineData(11,47)]
        [InlineData(8,100)]
        public void ReturnsFalseWhenModulusIsNotZero(int modNumber, int number)
        {
            var comparator = new ModulusFizzBuzzComparator("Does Not Matter For Test", modNumber);
            Assert.False(comparator.IsMatch(number));
        }
    }
}
