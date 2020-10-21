namespace FizzBuzzLibrary
{
    public interface IFizzBuzzNumberComparator
    {
        int NumberToCompare { get; }
        string Text { get; }

        bool IsMatch(int number);
    }
}
