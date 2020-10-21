using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public interface IFizzBuzzBuilder
    {
        string GetFizzBuzz(int number);
        IEnumerable<KeyValuePair<int, string>> GetFizzBuzz(IEnumerable<int> range);
    }
}
