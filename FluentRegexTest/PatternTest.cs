using System;
using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class PatternTest
    {
        #region Stringable

        [TestMethod]
        public void ToStringTest()
        {
            var pattern = new Pattern();
            Assert.AreEqual(string.Empty, pattern.ToString());
        }

        #endregion

        #region Construction

        [TestMethod]
        public void DefaultContructorTest()
        {
            var pattern = new Pattern();
            Assert.AreEqual(string.Empty, pattern);
        }

        [TestMethod]
        public void Contructor_InitialTermTest()
        {
            var pattern = new Pattern("initial term", false);
            Assert.AreEqual("(initial term)", pattern);
        }

        [TestMethod]
        public void Contructor_InitialTerm_EscapeTest()
        {
            var pattern = new Pattern("initial term", true);
            Assert.AreEqual(@"(initial\ term)", pattern);
        }

        #endregion

        #region Main

        [TestMethod]
        public void AddTest()
        {
            var term = @"\*+?|{[()^$.# ";
            var pattern = new Pattern().Add(term);

            var expected = @"(\\\*\+\?\|\{\[\(\)\^\$\.\#\ )";
            Assert.AreEqual(expected, pattern.ToString());
        }

        [TestMethod]
        public void AddWithoutEscapeTest()
        {
            var term = @"\*+?|{[()^$.# ";
            var pattern = new Pattern().Add(term, false);

            Assert.AreEqual("(" + term + ")", pattern.ToString());
        }

        #endregion
    }
}
