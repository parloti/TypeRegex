using System;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class HexadecimalUnicodeTest
    {
        [TestMethod]
        public void Contruction_Test()
        {
            new HexadecimalUnicode((char)1);
        }

        [TestMethod]
        public void Inheritance_Test()
        {
            HexadecimalUnicode instance = default(HexadecimalUnicode);

            try
            {
                instance = new HexadecimalUnicode((char)1);
            }
            catch(Exception e)
            {
                Assert.Inconclusive(e.Message);
            }

            Assert.IsTrue(instance is Stringable);
        }

        [TestMethod]
        public void ToString_Test()
        {
            HexadecimalUnicode instance = default(HexadecimalUnicode);

            try
            {
                instance = new HexadecimalUnicode((char)1);
            }
            catch (Exception e)
            {
                Assert.Inconclusive(e.Message);
            }

            Assert.AreEqual(@"\u0001", instance);
        }
    }
}
