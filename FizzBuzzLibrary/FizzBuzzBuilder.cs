using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
    public class FizzBuzzBuilder
    {
        public IEnumerable<IFizzBuzzNumberComparator> Comparators { get; }
        public FizzBuzzBuilder(IEnumerable<IFizzBuzzNumberComparator> comparators)
        {
            Comparators = comparators ?? throw new System.ArgumentNullException(nameof(comparators));
        }
        public string GetFizzBuzz(int number)
        {
            var builder = new StringBuilder().Append(number).Append(": ");
            foreach (var comparator in Comparators)
            {
                if (comparator.IsMatch(number))
                {
                    builder.Append(comparator.Text);
                }
            }
            return builder.ToString();
        }
        public IEnumerable<KeyValuePair<int, string>> GetFizzBuzz(IEnumerable<int> range)
        {
            var fizzBuzzResults = new List<KeyValuePair<int, string>>();
            foreach (var number in range)
            {
                var result = GetFizzBuzz(number);
                fizzBuzzResults.Add(new KeyValuePair<int, string>(number, result));
            }
            return fizzBuzzResults;
        }
    }
}
