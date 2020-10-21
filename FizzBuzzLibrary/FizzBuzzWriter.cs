using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public interface IFizzBuzzWriter
    {
        void Write(IEnumerable<KeyValuePair<int, string>> results);
    }
}
