using System;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class StringableTest
    {
        #region Helper

        private class Implementation1 : Stringable
        {
            private readonly string @string;

            public Implementation1(string @string)
            {
                this.@string = @string;
            }

            public override string ToString() => @string;
        }

        private class Implementation2 : Stringable
        {
            private readonly string @string;

            public Implementation2(string @string)
            {
                this.@string = @string;
            }

            public override string ToString() => @string;
        }

        #endregion

        [TestMethod]
        public void EqualsOperatorTest()
        {
            Assert.IsTrue(new Implementation1("string") == new Implementation2("string"));
        }

        [TestMethod]
        public void NotEqualsOperatorTest()
        {
            Assert.IsTrue(new Implementation1("string1") != new Implementation1("string2"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Equals_NullIntanceTest()
        {
            Assert.IsTrue((null as Stringable).Equals(new Implementation2("string")));
        }

        [TestMethod]
        public void EqualsTest()
        {
            Assert.IsTrue(new Implementation1("string").Equals(new Implementation2("string")));
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            Assert.AreNotEqual(new Implementation1("string1").GetHashCode(), new Implementation1("string2").GetHashCode());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ImplicitConversion_ArgumentNullTest()
        {
            string stringable = null as Stringable;
        }

        [TestMethod]
        public void ImplicitConversionTest()
        {
            string stringable = new Implementation1("string");
            Assert.AreEqual(typeof(string), stringable.GetType());
        }
    }
}
