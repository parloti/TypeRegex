using System;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class PatternAnchorsTest
    {
        [TestMethod]
        public void AtStartOfStringOrLineTest()
        {
            Assert.AreEqual("^", new Pattern(Anchors.StartOfStringOrLine, false));
        }

        [TestMethod]
        public void AtEndOfStringOrLineTest()
        {
            Assert.AreEqual("$", new Pattern(Anchors.EndOfStringOrLine, false));
        }

        [TestMethod]
        public void AtStartOfStringOnlyTest()
        {
            Assert.AreEqual(@"\A", new Pattern(Anchors.StartOfStringOnly, false));
        }

        [TestMethod]
        public void AtEndOfStringOrBeforeEndingNewlineTest()
        {
            Assert.AreEqual(@"\Z", new Pattern(Anchors.EndOfStringOrBeforeEndingNewline, false));
        }

        [TestMethod]
        public void AtEndOfStringOnlyTest()
        {
            Assert.AreEqual(@"\z", new Pattern(Anchors.EndOfStringOnly, false));
        }

        [TestMethod]
        public void AtContiguousMatchesTest()
        {
            Assert.AreEqual(@"\G", new Pattern(Anchors.ContiguousMatches, false));
        }

        [TestMethod]
        public void AtWordBoundaryTest()
        {
            Assert.AreEqual(@"\b", new Pattern(Anchors.WordBoundary, false));
        }

        [TestMethod]
        public void AtNonWordBoundaryTest()
        {
            Assert.AreEqual(@"\B", new Pattern(Anchors.NonWordBoundary, false));
        }
    }
}
