using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public class FizzBuzzWriterConsole : FizzBuzzWriter
    {
        public override void Write(IEnumerable<KeyValuePair<int,string>> results)
        {
            foreach (var item in results)
            {
                Console.WriteLine(item.Value);
            }
        }
    }

}
