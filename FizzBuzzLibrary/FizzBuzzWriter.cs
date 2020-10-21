using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public abstract class FizzBuzzWriter
    {
        public IEnumerable<KeyValuePair<int,string>> Results { get; }
        public FizzBuzzWriter(IEnumerable<KeyValuePair<int,string>> results)
        {
            Results = results ?? throw new System.ArgumentNullException(nameof(results));
        }
        public abstract void Write();
    }

}
