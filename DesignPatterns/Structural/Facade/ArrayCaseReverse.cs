namespace DesignPatterns.Structural.Facade
{
    public class ArrayCaseReverse
    {
        private static readonly char[] UpperCase;
        private static readonly char[] LowerCase;

        static ArrayCaseReverse()
        {
            UpperCase = new[]
            {
                'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z'
            };

            LowerCase = new[]
            {
                'a', 'b', 'c', 'd', 'e', 'f',
                'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x',
                'y', 'z'
            };
        }

        public static char[] ReverseCase(char[] @string)
        {
            var result = new char[@string.Length];

            for (var i = 0; i < @string.Length; i++)
            {
                var @char = @string[i];

                var upperCaseIndex = @char - 'A';
                var lowerCaseIndex = @char - 'a';

                if (upperCaseIndex >= 0 && upperCaseIndex < UpperCase.Length && @char == UpperCase[upperCaseIndex])
                {
                    result[i] = LowerCase[upperCaseIndex];
                }
                else if (lowerCaseIndex >= 0 && lowerCaseIndex < LowerCase.Length && @char == LowerCase[lowerCaseIndex])
                {
                    result[i] = UpperCase[lowerCaseIndex];
                }
                else
                {
                    result[i] = @char;
                }
            }

            return result;
        }
    }
}