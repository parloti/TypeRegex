using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeRegex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRegexTest
{
    [TestClass]
    public class AnchorsTest
    {
        [TestMethod]
        public void StartOfStringOrLineTest()
        {
            Assert.AreEqual("^", Anchors.StartOfStringOrLine);
        }

        [TestMethod]
        public void EndOfStringOrLineTest()
        {
            Assert.AreEqual("$", Anchors.EndOfStringOrLine);
        }

        [TestMethod]
        public void StartOfStringOnlyTest()
        {
            Assert.AreEqual(@"\A", Anchors.StartOfStringOnly);
        }

        [TestMethod]
        public void EndOfStringOrBeforeEndingNewlineTest()
        {
            Assert.AreEqual(@"\Z", Anchors.EndOfStringOrBeforeEndingNewline);
        }

        [TestMethod]
        public void EndOfStringOnlyTest()
        {
            Assert.AreEqual(@"\z", Anchors.EndOfStringOnly);
        }

        [TestMethod]
        public void ContiguousMatchesTest()
        {
            Assert.AreEqual(@"\G", Anchors.ContiguousMatches);
        }

        [TestMethod]
        public void WordBoundaryTest()
        {
            Assert.AreEqual(@"\b", Anchors.WordBoundary);
        }

        [TestMethod]
        public void NonWordBoundaryTest()
        {
            Assert.AreEqual(@"\B", Anchors.NonWordBoundary);
        }
    }
}
