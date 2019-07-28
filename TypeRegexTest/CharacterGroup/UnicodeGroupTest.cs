using System;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class UnicodeGroupTest
    {
        #region Helper

        private class Implementation : UnicodeGroup
        {
            public Implementation(string set) : base(set)
            {
            }

            protected override string CompositeFormat => "{0}";
        }

        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contructor_ArgumentNullException_Test()
        {
            new Implementation(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Contructor_EmptyArgument_Test()
        {
            new Implementation("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Contructor_WhiteSpaceArgument_Test()
        {
            new Implementation(" \t\n\r");
        }

        [TestMethod]
        public void Contructor_Test()
        {
            new Implementation("Block");
        }

        [TestMethod]
        public void ToString_Test()
        {
            Assert.AreEqual("Block", new Implementation("Block").ToString());
        }



    }
}
