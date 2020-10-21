using System;
using FizzBuzzLibrary;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             var comparators = new List<IFizzBuzzNumberComparator>{
                new ModulusFizzBuzzComparator("Fizz",3),
                new ModulusFizzBuzzComparator("Buzz",5),
                new ModulusFizzBuzzComparator("Wizz",7),
                new ModulusFizzBuzzComparator("Bang",11)
            };
            var builder = new FizzBuzzBuilder(comparators);
            IEnumerable<int> range = Enumerable.Range(1, 100);
            var writer = new FizzBuzzWriterString(Console.Out);
            var fizzBuzz = new FizzBuzz(builder,writer);
            fizzBuzz.WriteFizzBuzz(range);
        }
    }
}
