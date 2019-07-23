using System;
using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class PatternClassesTest
    {
        #region Character Classes

        #region Positive character group

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyIn1ArgumentNullTest()
        {
            new Pattern().AnyIn(null as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AnyIn1EmptyArgumentTest()
        {
            new Pattern().AnyIn("");
        }

        [TestMethod]
        public void AnyIn1Test()
        {
            var pattern = new Pattern().AnyIn("ae");
            Assert.AreEqual("([ae])", pattern);
        }

        [TestMethod]
        public void AnyIn1UnescapeTest()
        {
            var pattern = new Pattern().AnyIn(@"\.", false);
            Assert.AreEqual(@"([\.])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyIn2ArgumentNullTest()
        {
            new Pattern().AnyIn(null as char[]);
        }

        [TestMethod]
        public void AnyIn2Test()
        {
            var pattern = new Pattern().AnyIn('a', 'e');
            Assert.AreEqual("([ae])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Range1InvalidArgumentTest()
        {
            new Pattern().Range('z', 'a');
        }

        [TestMethod]
        public void Range1Test()
        {
            var pattern = new Pattern().Range('a', 'z');
            Assert.AreEqual(@"([\u0061-\u007A])", pattern);
        }

        [TestMethod]
        public void Range1SensitiveTest()
        {
            var pattern = new Pattern().Range('a', 'z', false);
            Assert.AreEqual(@"([\u0061-\u007A\u0041-\u005A])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Range2InvalidArgumentTest()
        {
            new Pattern().Range(9, 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Range2ReverseOrderTest()
        {
            new Pattern().Range(8, 10);
        }

        [TestMethod]
        public void Range2Test()
        {
            var pattern = new Pattern().Range(1, 8);
            Assert.AreEqual("([1-8])", pattern);
        }

        [TestMethod]
        public void AnyTest()
        {
            var pattern = new Pattern().Any();
            Assert.AreEqual(@"([\u0000-\uFFFF])", pattern);
        }

        #endregion

        #region Negative character group

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyNotIn1ArgumentNullTest()
        {
            new Pattern().AnyNotIn(null as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AnyNotIn1EmptyArgumentTest()
        {
            new Pattern().AnyNotIn("");
        }

        [TestMethod]
        public void AnyNotIn1Test()
        {
            var pattern = new Pattern().AnyNotIn("aei");
            Assert.AreEqual("([^aei])", pattern);
        }

        [TestMethod]
        public void AnyNotIn1UnescapeTest()
        {
            var pattern = new Pattern().AnyNotIn(@"\.", false);
            Assert.AreEqual(@"([^\.])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyNotIn2ArgumentNullTest()
        {
            new Pattern().AnyNotIn(null as char[]);
        }

        [TestMethod]
        public void AnyNotIn2Test()
        {
            var pattern = new Pattern().AnyNotIn('a', 'e', 'i');
            Assert.AreEqual("([^aei])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotInRange1InvalidArgumentTest()
        {
            new Pattern().NotInRange('z', 'a');
        }

        [TestMethod]
        public void NotInRange1Test()
        {
            var pattern = new Pattern().NotInRange('a', 'z');
            Assert.AreEqual(@"([^\u0061-\u007A])", pattern);
        }

        [TestMethod]
        public void NotInRange1SensitiveTest()
        {
            var pattern = new Pattern().NotInRange('a', 'z', false);
            Assert.AreEqual(@"([^\u0061-\u007A\u0041-\u005A])", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotInRange2InvalidArgumentTest()
        {
            new Pattern().NotInRange(9, 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotInRange2ReverseOrderTest()
        {
            new Pattern().NotInRange(8, 10);
        }

        [TestMethod]
        public void NotInRange2Test()
        {
            var pattern = new Pattern().NotInRange(1, 8);
            Assert.AreEqual("([^1-8])", pattern);
        }

        #endregion

        #region Word

        [TestMethod]
        public void WordTest()
        {
            var pattern = new Pattern().Word();
            Assert.AreEqual(@"(\w)", pattern);
        }

        [TestMethod]
        public void WordECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().Word(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([a-zA-Z_0-9])", pattern);
        }

        [TestMethod]
        public void WordUnicodeBehaviorTest()
        {
            var pattern = new Pattern().Word(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([\p{L}\p{Mn}\p{Nd}\p{Pc}])", pattern);
        }

        [TestMethod]
        public void NonWordTest()
        {
            var pattern = new Pattern().NonWord();
            Assert.AreEqual(@"(\W)", pattern);
        }

        [TestMethod]
        public void NonWordECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().NonWord(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([^a-zA-Z_0-9])", pattern);
        }

        [TestMethod]
        public void NonWordUnicodeBehaviorTest()
        {
            var pattern = new Pattern().NonWord(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([^\p{L}\p{Mn}\p{Nd}\p{Pc}])", pattern);
        }

        [TestMethod]
        public void ECMAScriptWordTest()
        {
            var pattern = new Pattern().ECMAScriptWord();
            Assert.AreEqual(@"([a-zA-Z_0-9])", pattern);
        }

        [TestMethod]
        public void ECMAScriptNonWordTest()
        {
            var pattern = new Pattern().ECMAScriptNonWord();
            Assert.AreEqual(@"([^a-zA-Z_0-9])", pattern);
        }

        [TestMethod]
        public void UnicodeWordTest()
        {
            var pattern = new Pattern().UnicodeWord();
            Assert.AreEqual(@"([\p{L}\p{Mn}\p{Nd}\p{Pc}])", pattern);
        }

        [TestMethod]
        public void UnicodeNonWordTest()
        {
            var pattern = new Pattern().UnicodeNonWord();
            Assert.AreEqual(@"([^\p{L}\p{Mn}\p{Nd}\p{Pc}])", pattern);
        }

        #endregion

        #region WhiteSpace

        [TestMethod]
        public void WhiteSpaceTest()
        {
            var pattern = new Pattern().WhiteSpace();
            Assert.AreEqual(@"(\s)", pattern);
        }

        [TestMethod]
        public void WhiteSpaceECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().WhiteSpace(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([ \f\n\r\t\v])", pattern);
        }

        [TestMethod]
        public void WhiteSpaceUnicodeBehaviorTest()
        {
            var pattern = new Pattern().WhiteSpace(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([\f\n\r\t\v\x85\p{Z}])", pattern);
        }

        [TestMethod]
        public void NonWhiteSpaceTest()
        {
            var pattern = new Pattern().NonWhiteSpace();
            Assert.AreEqual(@"(\S)", pattern);
        }

        [TestMethod]
        public void NonWhiteSpaceECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().NonWhiteSpace(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([^ \f\n\r\t\v])", pattern);
        }

        [TestMethod]
        public void NonWhiteSpaceUnicodeBehaviorTest()
        {
            var pattern = new Pattern().NonWhiteSpace(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([^\f\n\r\t\v\x85\p{Z}])", pattern);
        }

        [TestMethod]
        public void ECMAScriptWhiteSpaceTest()
        {
            var pattern = new Pattern().WhiteSpace(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([ \f\n\r\t\v])", pattern);
        }

        [TestMethod]
        public void ECMAScriptNonWhiteSpaceTest()
        {
            var pattern = new Pattern().NonWhiteSpace(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([^ \f\n\r\t\v])", pattern);
        }

        [TestMethod]
        public void UnicodeWhiteSpaceTest()
        {
            var pattern = new Pattern().WhiteSpace(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([\f\n\r\t\v\x85\p{Z}])", pattern);
        }

        [TestMethod]
        public void UnicodeNonWhiteSpaceTest()
        {
            var pattern = new Pattern().NonWhiteSpace(MatchingBehavior.Unicode);
            Assert.AreEqual(@"([^\f\n\r\t\v\x85\p{Z}])", pattern);
        }

        #endregion

        #region Digit

        [TestMethod]
        public void DigitTest()
        {
            var pattern = new Pattern().Digit();
            Assert.AreEqual(@"(\d)", pattern);
        }

        [TestMethod]
        public void DigitECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().Digit(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([0-9])", pattern);
        }
        [TestMethod]
        public void DigitUnicodeBehaviorTest()
        {
            var pattern = new Pattern().Digit(MatchingBehavior.Unicode);
            Assert.AreEqual(@"(\p{Nd})", pattern);
        }

        [TestMethod]
        public void ECMAScriptDigitTest()
        {
            var pattern = new Pattern().Digit(MatchingBehavior.ECMAScript);
            Assert.AreEqual("([0-9])", pattern);
        }

        [TestMethod]
        public void UnicodeDigitTest()
        {
            var pattern = new Pattern().Digit(MatchingBehavior.Unicode);
            Assert.AreEqual(@"(\p{Nd})", pattern);
        }

        [TestMethod]
        public void NonDigitTest()
        {
            var pattern = new Pattern().NonDigit();
            Assert.AreEqual(@"(\D)", pattern);
        }

        [TestMethod]
        public void NonDigitECMAScriptBehaviorTest()
        {
            var pattern = new Pattern().NonDigit(MatchingBehavior.ECMAScript);
            Assert.AreEqual(@"([^0-9])", pattern);
        }

        [TestMethod]
        public void NonDigitUnicodeBehaviorTest()
        {
            var pattern = new Pattern().NonDigit(MatchingBehavior.Unicode);
            Assert.AreEqual(@"(\P{Nd})", pattern);
        }

        [TestMethod]
        public void ECMAScriptNonDigitTest()
        {
            var pattern = new Pattern().NonDigit(MatchingBehavior.ECMAScript);
            Assert.AreEqual("([^0-9])", pattern);
        }

        [TestMethod]
        public void UnicodeNonDigitTest()
        {
            var pattern = new Pattern().NonDigit(MatchingBehavior.Unicode);
            Assert.AreEqual(@"(\P{Nd})", pattern);
        }



        #endregion

        #endregion
    }
}
