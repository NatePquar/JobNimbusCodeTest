using System.Collections.Generic;

namespace JobNimbus.Functions
{
    public class StringChecker
    {
        public bool EvaluateStringForMatchedBrackets(string inputString)
        {
            string str = inputString;

            var openingBracketPositions = getOpeningBracketPositions(inputString);
            var closingBracketPositions = getClosingBracketPositions(inputString);

            if (openingBracketPositions.Count != closingBracketPositions.Count)
            {
                return false;
            }

            int arrayPosition = 0;
            foreach (int bracket in openingBracketPositions)
            {
                if (bracket > closingBracketPositions[arrayPosition])
                {
                    return false;
                }
                arrayPosition++;
            }

            return true;
        }

        private List<int> getOpeningBracketPositions(string input)
        {
            List<int> openingBrackets = new List<int>();

            int a = 0;
            int b = 0;
            while ((a < input.Length) && (b > -1))
            {
                b = input.IndexOf('{', a);
                if (b == -1) break;
                openingBrackets.Add(b);
                a = b + 1;
            }

            return openingBrackets;
        }

        private List<int> getClosingBracketPositions(string input)
        {
            List<int> closingBrackets = new List<int>();

            int a = 0;
            int b = 0;
            while ((a < input.Length) && (b > -1))
            {
                b = input.IndexOf('}', a);
                if (b == -1) break;
                closingBrackets.Add(b);
                a = b + 1;
            }

            return closingBrackets;
        }
    }
}
