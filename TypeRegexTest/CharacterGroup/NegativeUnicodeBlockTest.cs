using System;
using System.Reflection;
using System.Text.RegularExpressions;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{
    [TestClass]
    public class NegativeUnicodeBlockTest
    {
        [TestMethod]
        public void Test()
        {
            var propertyInfos = typeof(NegativeUnicodeBlock).GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                TestProperty(propertyInfo);
            }
        }

        private void TestProperty(PropertyInfo propertyInfo)
        {
            try
            {
                var value = propertyInfo.GetValue(null);
                new Regex(value.ToString());
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message + Environment.NewLine + propertyInfo.Name);
            }
        }
    }
}
