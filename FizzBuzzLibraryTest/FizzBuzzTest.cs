using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FizzBuzzLibrary;
using Xunit;

namespace FizzBuzzLibraryTest
{
    public class FizzBuzzTest
    {
        private FizzBuzzBuilder GetBuilder()
        {
            var comparators = new List<IFizzBuzzNumberComparator>{
                new ModulusFizzBuzzComparator("Fizz",3),
                new ModulusFizzBuzzComparator("Buzz",5),
                new ModulusFizzBuzzComparator("Wizz",7),
                new ModulusFizzBuzzComparator("Bang",11)
            };
            var builder = new FizzBuzzBuilder(comparators);
            return builder;
        }
        [Theory]
        [InlineData("3: Fizz")]
        [InlineData("5: Buzz")]
        [InlineData("7: Wizz")]
        [InlineData("11: Bang")]
        [InlineData("21: FizzWizz")]
        [InlineData("45: FizzBuzz")]
        [InlineData("33: FizzBang")]
        [InlineData("35: BuzzWizz")]
        [InlineData("55: BuzzBang")]
        [InlineData("77: WizzBang")]
        public void WriterWritesFizzBuzzWizzBangTo100(string expected)
        {
            var builder = GetBuilder();
            IEnumerable<int> range = Enumerable.Range(1, 100);
            using (var writer = new StringWriter())
            {
                var fizzBuzzWriter = new FizzBuzzWriterString(writer);
                var fizzBuzz = new FizzBuzz(builder,fizzBuzzWriter);
                fizzBuzz.WriteFizzBuzz(range);  
                var consoleString = writer.GetStringBuilder().ToString();

                Assert.Contains(expected, consoleString);
            }
        }
    }
}
