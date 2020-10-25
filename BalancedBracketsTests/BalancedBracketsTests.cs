using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
     
        //Test #1: Returns True
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }


        //Test #2: Returns True
        [TestMethod]
        public void BracketOnlyLetters()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[abcd]"));
        }


        //Test #3: Return True
        [TestMethod]
        public void BracketOnlyNumbers()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[1234]"));
        }


        //Test #4: Returns True
        [TestMethod]
        public void BracketOnlyAlphaNumerical()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[abcd1234]"));
        }


        //Test #5: Returns True
        [TestMethod]
        public void BracketOnlyAlphaNumericalAndSymbols()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[abc?d12+3.4]"));
        }


        //Test #6: Returns True
        [TestMethod]
        public void BracketOnlyAlphaNumericalEmptySpace()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[a bc?d 12+  3.4]"));
        }


        //Test #7: Returns True
        [TestMethod]
        public void BracketOnlyAlphaNumericalEmptySpaceCurlyBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("{[a bc?d 12+  3.4]}"));
        }


        //Test #8: Returns False
        [TestMethod]
        public void NoBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("abdc"));
        }


        //Test #9: Returns False
        [TestMethod]
        public void NoBracketAlphaNumerical()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("a2b54dc"));
        }


        //Test #10: Returns False
        [TestMethod]
        public void NoBracketAlphaNumericalEmptySpace()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("a2   b5   4 dc"));
        }


        //Test #11: Returns False
        [TestMethod]
        public void NoBracketAlphaNumericalEmptySpaceSymbols()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("a2?  .  b5 =  4 dc"));
        }


        //Test #12: Returns False
        [TestMethod]
        public void OneBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[abdc"));
        }


        //Test #13: Returns False
        [TestMethod]
        public void OneBracketAlphaNumericalEmptySpaceSymbols()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[ab  ?34   d +/c/"));
        }


        //Test #14: Returns False
        [TestMethod]
        public void OneBracketRandomLocation()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("abd[c"));
        }


        //Test #15: Returns False
        [TestMethod]
        public void OneBracketRandomLocationAlphaNumericalEmptySpace()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("a324 . b   d[  .=c"));
        }

        //Test #16: Returns False
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(" "));
        }
    }
}
