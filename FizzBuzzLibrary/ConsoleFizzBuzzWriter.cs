using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public class ConsoleFizzBuzzWriter : FizzBuzzWriter
    {
        public ConsoleFizzBuzzWriter(IEnumerable<KeyValuePair<int,string>> results) : base(results)
        {
        }

        public override void Write()
        {
            foreach (var item in Results)
            {
                Console.WriteLine(item.Value);
            }
        }
    }

}
