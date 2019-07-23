using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class CharacterGroupTest
    {
        #region Helper

        private class Implementation : CharacterGroup
        {
            public Implementation(string set) : base(set)
            {
            }
        }

        #endregion

        #region Stringable

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("[abc]", new Implementation("abc"));
            Assert.AreEqual("[abc]", new Implementation("abc").ToString());
        }

        #endregion

        #region ISubtractable

        [TestMethod]
        public void SetTest()
        {
            Assert.AreEqual("abc", new Implementation("abc").Set);
        }

        #endregion
    }
}
