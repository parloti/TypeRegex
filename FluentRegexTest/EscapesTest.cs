using System;
using System.Reflection;
using System.Text.RegularExpressions;
using FluentRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentRegexTest
{
    [TestClass]
    public class EscapesTest
    {

        [TestMethod]
        public void Test()
        {
            var propertyInfos = typeof(Escapes).GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                TestField(propertyInfo);
            }
        }

        private void TestField(PropertyInfo propertyInfo)
        {
            try
            {
                var value = propertyInfo.GetValue(null);
                new Regex(value as string);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
