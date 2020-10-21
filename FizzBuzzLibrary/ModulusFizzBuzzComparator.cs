namespace FizzBuzzLibrary
{
    public class ModulusFizzBuzzComparator : IFizzBuzzNumberComparator
    {
        public int NumberToCompare { get; }
        public string Text { get; }

        public ModulusFizzBuzzComparator(string Text, int numberToCompare)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                throw new System.ArgumentException($"'{nameof(Text)}' cannot be null or whitespace", nameof(Text));
            }

            this.Text = Text;
            NumberToCompare = numberToCompare;
        }

        public bool IsMatch(int number)
        {
            return number % NumberToCompare == 0;
        }
    }
}
