using JobNimbus.Functions;
using NUnit.Framework;

namespace JobNimbus.Tests
{
    public class UnitTests
    {
        [Test]
        public void OneOpenAndCloseReturnTrue()
        {
            var stringChecker = new StringChecker();
            string inputString = "{}";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsTrue(result);
        }

        [Test]
        public void OneCloseAndOpenReturnFalse()
        {
            var stringChecker = new StringChecker();
            string inputString = "}{";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsFalse(result);
        }

        [Test]
        public void TwoOpenAndOneCloseReturnFalse()
        {
            var stringChecker = new StringChecker();
            string inputString = "{{}";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsFalse(result);
        }

        [Test]
        public void EmptyStringReturnsTrue()
        {
            var stringChecker = new StringChecker();
            string inputString = "";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsTrue(result);
        }

        [Test]
        public void MultipleBracketSetsReturnTrue()
        {
            var stringChecker = new StringChecker();
            string inputString = "{FrERh}{gra}ar{ear}";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsTrue(result);
        }

        [Test]
        public void ValidAndInvalidBracketsReturnFalse()
        {
            var stringChecker = new StringChecker();
            string inputString = "ge{esg}geg}seg{";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsFalse(result);
        }

        [Test]
        public void OpeningBracketWithoutClosingBracketFails()
        {
            var stringChecker = new StringChecker();
            string inputString = "{";

            bool result = stringChecker.EvaluateStringForMatchedBrackets(inputString);

            Assert.IsFalse(result);
        }
    }
}
