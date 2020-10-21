using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary
{

    public class FizzBuzz
    {
        protected IFizzBuzzBuilder Builder { get; }
        protected IFizzBuzzWriter Writer { get; }
        public FizzBuzz(IFizzBuzzBuilder builder, IFizzBuzzWriter writer)
        {
            Builder = builder ?? throw new System.ArgumentNullException(nameof(builder));
            Writer = writer ?? throw new System.ArgumentNullException(nameof(writer));
        }

        public void WriteFizzBuzz(int number)
        {
            var result = Builder.GetFizzBuzz(number);
            var kvp = new KeyValuePair<int, string>[] { new KeyValuePair<int, string>(number, result) };
            Writer.Write(kvp);
        }
        public void WriteFizzBuzz(IEnumerable<int> range)
        {
            var results = Builder.GetFizzBuzz(range);
            Writer.Write(results);
        }
    }
}
