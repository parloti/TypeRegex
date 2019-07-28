using System;
using System.Reflection;
using System.Text.RegularExpressions;
using TypeRegex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeRegexTest
{

    [TestClass]
    public class UnicodeBlockTest
    {
        [TestMethod]
        public void Test()
        {
            var fields = typeof(UnicodeGroup).GetFields();

            foreach (var field in fields)
            {
                TestField(field);
            }
        }

        private void TestField(FieldInfo field)
        {
            try
            {
                var value = field.GetValue(null);
                new Regex(@"\p{" + value as string + "}");
            }
            catch (Exception e)
            {
                Assert.Fail(field.Name + Environment.NewLine + e.Message);
            }
        }
    }
}
