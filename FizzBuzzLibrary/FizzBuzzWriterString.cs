using System;
using System.Collections.Generic;
using System.IO;

namespace FizzBuzzLibrary
{
    public class FizzBuzzWriterString  : IFizzBuzzWriter
    {
        private readonly TextWriter writer;

        public FizzBuzzWriterString(TextWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Write(IEnumerable<KeyValuePair<int, string>> results)
        {
            foreach (var item in results)
            {
                writer.WriteLine(item.Value);
            }
        }
    }

}
