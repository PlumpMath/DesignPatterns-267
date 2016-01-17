namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        public static string ReverseStringCase(string @string)
        {
            var charArray = @string.ToCharArray();
            var reverseCase = ArrayCaseReverse.ReverseCase(charArray);
            return new string(reverseCase);
        }
    }
}