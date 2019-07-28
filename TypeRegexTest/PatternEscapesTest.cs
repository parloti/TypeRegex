using System;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class PatternEscapesTest
    {
        #region Character Escapes

        [TestMethod]
        public void BellTest()
        {
            var pattern = new Pattern().Bell();
            Assert.AreEqual(@"\u0007", pattern);
        }

        [TestMethod]
        public void BackspaceTest()
        {
            var pattern = new Pattern().Backspace();
            Assert.AreEqual(@"\u0008", pattern);
        }

        [TestMethod]
        public void TabTest()
        {
            var pattern = new Pattern().Tab();
            Assert.AreEqual(@"\u0009", pattern);
        }

        [TestMethod]
        public void CarriageReturnTest()
        {
            var pattern = new Pattern().CarriageReturn();
            Assert.AreEqual(@"\u000D", pattern);
        }

        [TestMethod]
        public void VerticalTabTest()
        {
            var pattern = new Pattern().VerticalTab();
            Assert.AreEqual(@"\u000B", pattern);
        }

        [TestMethod]
        public void FormFeedTest()
        {
            var pattern = new Pattern().FormFeed();
            Assert.AreEqual(@"\u000C", pattern);
        }

        [TestMethod]
        public void NewLineTest()
        {
            var pattern = new Pattern().NewLine();
            Assert.AreEqual(@"\u000D?\u000A", pattern);

            pattern = new Pattern().NewLine(false);
            Assert.AreEqual(@"\u000A", pattern);
        }

        [TestMethod]
        public void EscapeTest()
        {
            var pattern = new Pattern().Escape();
            Assert.AreEqual(@"\u001B", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OctalNegativeSignTest()
        {
            new Pattern().Octal("-10");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OctalArgumentNullTest()
        {
            new Pattern().Octal(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OctalEmptyArgumentTest()
        {
            new Pattern().Octal("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OctalInvalidArgumentLengthTest()
        {
            new Pattern().Octal("0");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void OctalInvalidFormatTest()
        {
            new Pattern().Octal("80");
        }

        [TestMethod]
        public void OctalTest()
        {
            var pattern = new Pattern().Octal("40");
            Assert.AreEqual(@"\40", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HexadecimalNegativeSignTest()
        {
            new Pattern().Hexadecimal("-10");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HexadecimalArgumentNullTest()
        {
            new Pattern().Hexadecimal(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HexadecimalEmptyArgumentTest()
        {
            new Pattern().Hexadecimal("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HexadecimalInvalidArgumentLengthTest()
        {
            new Pattern().Hexadecimal("0");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void HexadecimalTestInvalidFormat()
        {
            new Pattern().Hexadecimal("GF");
        }

        [TestMethod]
        public void HexadecimalTest()
        {
            var pattern = new Pattern().Hexadecimal("20");
            Assert.AreEqual(@"\20", pattern);
        }

        [TestMethod]
        public void ASCIIControlTest()
        {
            var pattern = new Pattern().ASCIIControl('C');
            Assert.AreEqual(@"\cC", pattern);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnicodeNegativeSignTest()
        {
            new Pattern().Unicode("-10");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UnicodeArgumentNullTest()
        {
            new Pattern().Unicode(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UnicodeEmptyArgumentTest()
        {
            new Pattern().Unicode("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UnicodeInvalidArgumentLengthTest()
        {
            new Pattern().Unicode("0");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void UnicodeTestInvalidFormat()
        {
            new Pattern().Unicode("GF");
        }

        [TestMethod]
        public void UnicodeTest()
        {
            var pattern = new Pattern().Unicode("0020");
            Assert.AreEqual(@"\u0020", pattern);
        }

        [TestMethod]
        public void LiteralTest()
        {
            var pattern = new Pattern().Literal('*');
            Assert.AreEqual(@"\u002A", pattern);
        }

        #endregion
    }
}
