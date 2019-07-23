using System;
using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class NegativeCharacterGroupTest
    {
        #region String Set Contructor

        [TestMethod]
        public void StringSet_ContructorSuccessful_Test()
        {
            try
            {
                new NegativeCharacterGroup("set");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StringSet_ContructorArgumentNull_Test()
        {
            new NegativeCharacterGroup(null as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringSet_ContructorEmptySet_Test()
        {
            new NegativeCharacterGroup("");
        }

        [TestMethod]
        public void StringSet_ContructorSet_Test()
        {
            Assert.AreEqual("[^abc]", new NegativeCharacterGroup("abc").ToString());
        }

        [TestMethod]
        public void StringSet_ContructorEscape_Test()
        {
            Assert.AreEqual(@"[^\.abc]", new NegativeCharacterGroup(".abc").ToString());
        }

        [TestMethod]
        public void StringSet_ContructorNotEscape_Test()
        {
            Assert.AreEqual(@"[^.abc]", new NegativeCharacterGroup(".abc", false).ToString());
        }

        #endregion

        #region Params Char Contructor

        [TestMethod]
        public void ParamsChar_ContructorSuccessful_Test()
        {
            try
            {
                new NegativeCharacterGroup('s', 'e', 't');
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ParamsChar_ContructorArgumentNull_Test()
        {
            new NegativeCharacterGroup(null as char[]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ParamsChar_ContructorEmptySet_Test()
        {
            new NegativeCharacterGroup(new char[] { });
        }

        [TestMethod]
        public void ParamsChar_ContructorSet_Test()
        {
            Assert.AreEqual("[^abc]", new NegativeCharacterGroup('a', 'b', 'c').ToString());
        }

        [TestMethod]
        public void ParamsChar_ContructorEscape_Test()
        {
            Assert.AreEqual(@"[^\.abc]", new NegativeCharacterGroup('.', 'a', 'b', 'c').ToString());
        }

        #endregion

        #region Char Range Contructor

        [TestMethod]
        public void CharRange_ContructorSuccessful_Test()
        {
            try
            {
                new NegativeCharacterGroup('a', 'c');
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CharRange_ContructorArgumentNull_Test()
        {
            new NegativeCharacterGroup('c', 'a');
        }

        [TestMethod]
        public void CharRange_ContructorSet_Test()
        {
            Assert.AreEqual(@"[^\u0061-\u0063]", new NegativeCharacterGroup('a', 'c').ToString());
        }

        [TestMethod]
        public void CharRange_ContructorCaseSensitive_Test()
        {
            Assert.AreEqual(@"[^\u0061-\u0063]", new NegativeCharacterGroup('a', 'c', true).ToString());
        }

        [TestMethod]
        public void CharRange_ContructorCaseInsensitive_Test()
        {
            Assert.AreEqual(@"[^\u0061-\u0063\u0041-\u0043]", new NegativeCharacterGroup('a', 'c', false).ToString());
        }

        #endregion

        #region UInt Range Contructor

        [TestMethod]
        public void UIntRange_ContructorSuccessful_Test()
        {
            try
            {
                new NegativeCharacterGroup(0, 5);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UIntRange_ContructorArgumentNull_Test()
        {
            new NegativeCharacterGroup(5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UIntRange_ContructorFirstOutOfRange_Test()
        {
            new NegativeCharacterGroup(10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UIntRange_ContructorLastOutOfRange_Test()
        {
            new NegativeCharacterGroup(0, 10);
        }

        [TestMethod]
        public void UIntRange_ContructorSet_Test()
        {
            Assert.AreEqual("[^0-3]", new NegativeCharacterGroup(0, 3).ToString());
        }

        #endregion
    }
}
