using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public abstract class FizzBuzzWriter
    {
        public abstract void Write(IEnumerable<KeyValuePair<int,string>> results);
    }

}
