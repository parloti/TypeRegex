using System;
using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class PositiveCharacterGroupTest
    {
        #region Construction

        #region String Set Contructor

        [TestMethod]
        public void StringSetContructor_SuccessfulTest()
        {
            try
            {
                new PositiveCharacterGroup("set");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StringSetContructor_ArgumentNullTest()
        {
            new PositiveCharacterGroup(null as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringSetContructor_EmptySetTest()
        {
            new PositiveCharacterGroup("");
        }

        [TestMethod]
        public void StringSetContructor_SetTest()
        {
            Assert.AreEqual("[abc]", new PositiveCharacterGroup("abc").ToString());
        }

        [TestMethod]
        public void StringSetContructor_EscapeTest()
        {
            Assert.AreEqual(@"[\.abc]", new PositiveCharacterGroup(".abc").ToString());
        }

        [TestMethod]
        public void StringSetContructor_NotEscapeTest()
        {
            Assert.AreEqual(@"[.abc]", new PositiveCharacterGroup(".abc", false).ToString());
        }

        #endregion

        #region Params Char Contructor

        [TestMethod]
        public void ParamsCharContructor_SuccessfulTest()
        {
            try
            {
                new PositiveCharacterGroup('s', 'e', 't');
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ParamsCharContructor_ArgumentNullTest()
        {
            new PositiveCharacterGroup(null as char[]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ParamsCharContructor_EmptySetTest()
        {
            new PositiveCharacterGroup(new char[] { });
        }

        [TestMethod]
        public void ParamsCharContructor_SetTest()
        {
            Assert.AreEqual("[abc]", new PositiveCharacterGroup('a', 'b', 'c').ToString());
        }

        [TestMethod]
        public void ParamsCharContructor_EscapeTest()
        {
            Assert.AreEqual(@"[\.abc]", new PositiveCharacterGroup('.', 'a', 'b', 'c').ToString());
        }

        #endregion

        #region Char Range Contructor

        [TestMethod]
        public void CharRangeContructor_SuccessfulTest()
        {
            try
            {
                new PositiveCharacterGroup('a', 'c');
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CharRangeContructor_ArgumentNullTest()
        {
            new PositiveCharacterGroup('c', 'a');
        }

        [TestMethod]
        public void CharRangeContructor_SetTest()
        {
            Assert.AreEqual(@"[\u0061-\u0063]", new PositiveCharacterGroup('a', 'c').ToString());
        }

        [TestMethod]
        public void CharRangeContructor_CaseSensitiveTest()
        {
            Assert.AreEqual(@"[\u0061-\u0063]", new PositiveCharacterGroup('a', 'c', true).ToString());
        }

        [TestMethod]
        public void CharRangeContructor_CaseInsensitiveTest()
        {
            Assert.AreEqual(@"[\u0061-\u0063\u0041-\u0043]", new PositiveCharacterGroup('a', 'c', false).ToString());
        }

        #endregion

        #region UInt Range Contructor

        [TestMethod]
        public void UIntRangeContructor_SuccessfulTest()
        {
            try
            {
                new PositiveCharacterGroup(0, 5);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UIntRangeContructor_ArgumentNullTest()
        {
            new PositiveCharacterGroup(5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UIntRangeContructor_FirstOutOfRangeTest()
        {
            new PositiveCharacterGroup(10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UIntRangeContructor_LastOutOfRangeTest()
        {
            new PositiveCharacterGroup(0, 10);
        }

        [TestMethod]
        public void UIntRangeContructor_SetTest()
        {
            Assert.AreEqual("[0-3]", new PositiveCharacterGroup(0, 3).ToString());
        }

        #endregion

        #region Parameterless Contructor

        [TestMethod]
        public void ParameterlessContructorTest()
        {
            Assert.AreEqual(@"[\u0000-\uFFFF]", new PositiveCharacterGroup().ToString());
        }

        #endregion

        #endregion
    }
}
