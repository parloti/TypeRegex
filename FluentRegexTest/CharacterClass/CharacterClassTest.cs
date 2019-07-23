using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class CharacterClassTest
    {
        #region Stringable

        [TestMethod]
        public void AnyTest()
        {
            Assert.AreEqual(@"[\u0000-\uFFFF]", CharacterClass.Any);
        }

        #region Word

        [TestMethod]
        public void WordTest()
        {
            Assert.AreEqual(@"\w", CharacterClass.Word);
        }

        [TestMethod]
        public void ECMAScriptWordTest()
        {
            Assert.AreEqual(@"[a-zA-Z_0-9]", CharacterClass.ECMAScriptWord);
        }

        [TestMethod]
        public void UnicodeWordTest()
        {
            Assert.AreEqual(@"[\p{L}\p{Mn}\p{Nd}\p{Pc}]", CharacterClass.UnicodeWord);
        }

        [TestMethod]
        public void NonWordTest()
        {
            Assert.AreEqual(@"\W", CharacterClass.NonWord);
        }

        [TestMethod]
        public void ECMAScriptNonWordTest()
        {
            Assert.AreEqual(@"[^a-zA-Z_0-9]", CharacterClass.ECMAScriptNonWord);
        }

        [TestMethod]
        public void UnicodeNonWordTest()
        {
            Assert.AreEqual(@"[^\p{L}\p{Mn}\p{Nd}\p{Pc}]", CharacterClass.UnicodeNonWord);
        }

        #endregion

        #region WhiteSpace

        [TestMethod]
        public void WhiteSpaceTest()
        {
            Assert.AreEqual(@"\s", CharacterClass.WhiteSpace);
        }

        [TestMethod]
        public void ECMAScriptWhiteSpaceTest()
        {
            Assert.AreEqual(@"[ \f\n\r\t\v]", CharacterClass.ECMAScriptWhiteSpace);
        }

        [TestMethod]
        public void UnicodeWhiteSpaceTest()
        {
            Assert.AreEqual(@"[\f\n\r\t\v\x85\p{Z}]", CharacterClass.UnicodeWhiteSpace);
        }

        [TestMethod]
        public void NonWhiteSpaceTest()
        {
            Assert.AreEqual(@"\S", CharacterClass.NonWhiteSpace);
        }

        [TestMethod]
        public void ECMAScriptNonWhiteSpaceTest()
        {
            Assert.AreEqual(@"[^ \f\n\r\t\v]", CharacterClass.ECMAScriptNonWhiteSpace);
        }

        [TestMethod]
        public void UnicodeNonWhiteSpaceTest()
        {
            Assert.AreEqual(@"[^\f\n\r\t\v\x85\p{Z}]", CharacterClass.UnicodeNonWhiteSpace);
        }

        #endregion

        #region Digit

        [TestMethod]
        public void DigitTest()
        {
            Assert.AreEqual(@"\d", CharacterClass.Digit);
        }

        [TestMethod]
        public void ECMAScriptDigitTest()
        {
            Assert.AreEqual(@"[0-9]", CharacterClass.ECMAScriptDigit);
        }

        [TestMethod]
        public void UnicodeDigitTest()
        {
            Assert.AreEqual(@"\p{Nd}", CharacterClass.UnicodeDigit);
        }

        [TestMethod]
        public void NonDigitTest()
        {
            Assert.AreEqual(@"\D", CharacterClass.NonDigit);
        }

        [TestMethod]
        public void ECMAScriptNonDigitTest()
        {
            Assert.AreEqual(@"[^0-9]", CharacterClass.ECMAScriptNonDigit);
        }

        [TestMethod]
        public void UnicodeNonDigitTest()
        {
            Assert.AreEqual(@"\P{Nd}", CharacterClass.UnicodeNonDigit);
        }

        #endregion

        #endregion

        #region ISubtractable

        [TestMethod]
        public void Any_SetTest()
        {
            Assert.AreEqual(@"\u0000-\uFFFF", CharacterClass.Any.Set);
        }

        #region Word

        [TestMethod]
        public void Word_SetTest()
        {
            Assert.AreEqual(@"\w", CharacterClass.Word.Set);
        }

        [TestMethod]
        public void ECMAScriptWord_SetTest()
        {
            Assert.AreEqual(@"a-zA-Z_0-9", CharacterClass.ECMAScriptWord.Set);
        }

        [TestMethod]
        public void UnicodeWord_SetTest()
        {
            Assert.AreEqual(@"\p{L}\p{Mn}\p{Nd}\p{Pc}", CharacterClass.UnicodeWord.Set);
        }

        [TestMethod]
        public void NonWord_SetTest()
        {
            Assert.AreEqual(@"\W", CharacterClass.NonWord.Set);
        }

        [TestMethod]
        public void ECMAScriptNonWord_SetTest()
        {
            Assert.AreEqual(@"^a-zA-Z_0-9", CharacterClass.ECMAScriptNonWord.Set);
        }

        [TestMethod]
        public void UnicodeNonWord_SetTest()
        {
            Assert.AreEqual(@"^\p{L}\p{Mn}\p{Nd}\p{Pc}", CharacterClass.UnicodeNonWord.Set);
        }

        #endregion

        #region WhiteSpace

        [TestMethod]
        public void WhiteSpace_SetTest()
        {
            Assert.AreEqual(@"\s", CharacterClass.WhiteSpace.Set);
        }

        [TestMethod]
        public void ECMAScriptWhiteSpace_SetTest()
        {
            Assert.AreEqual(@" \f\n\r\t\v", CharacterClass.ECMAScriptWhiteSpace.Set);
        }

        [TestMethod]
        public void UnicodeWhiteSpace_SetTest()
        {
            Assert.AreEqual(@"\f\n\r\t\v\x85\p{Z}", CharacterClass.UnicodeWhiteSpace.Set);
        }

        [TestMethod]
        public void NonWhiteSpace_SetTest()
        {
            Assert.AreEqual(@"\S", CharacterClass.NonWhiteSpace.Set);
        }

        [TestMethod]
        public void ECMAScriptNonWhiteSpace_SetTest()
        {
            Assert.AreEqual(@"^ \f\n\r\t\v", CharacterClass.ECMAScriptNonWhiteSpace.Set);
        }

        [TestMethod]
        public void UnicodeNonWhiteSpace_SetTest()
        {
            Assert.AreEqual(@"^\f\n\r\t\v\x85\p{Z}", CharacterClass.UnicodeNonWhiteSpace.Set);
        }

        #endregion

        #region Digit

        [TestMethod]
        public void Digit_SetTest()
        {
            Assert.AreEqual(@"\d", CharacterClass.Digit.Set);
        }

        [TestMethod]
        public void ECMAScriptDigit_SetTest()
        {
            Assert.AreEqual(@"0-9", CharacterClass.ECMAScriptDigit.Set);
        }

        [TestMethod]
        public void UnicodeDigit_SetTest()
        {
            Assert.AreEqual(@"\p{Nd}", CharacterClass.UnicodeDigit.Set);
        }

        [TestMethod]
        public void NonDigit_SetTest()
        {
            Assert.AreEqual(@"\D", CharacterClass.NonDigit.Set);
        }

        [TestMethod]
        public void ECMAScriptNonDigit_SetTest()
        {
            Assert.AreEqual(@"^0-9", CharacterClass.ECMAScriptNonDigit.Set);
        }

        [TestMethod]
        public void UnicodeNonDigit_SetTest()
        {
            Assert.AreEqual(@"\P{Nd}", CharacterClass.UnicodeNonDigit.Set);
        }

        #endregion

        #endregion
    }
}
