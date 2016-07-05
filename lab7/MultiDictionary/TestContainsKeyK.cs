using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericApp;

namespace MultiDictionary
{
    [TestClass]
    public class TestContainsKeyK
    {
        [TestMethod]
        public void MultiDictionary_ContainsKey_NotExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "one");
            var res = md.ContainsKey(2);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void MultiDictionary_ContainsKey_ExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1,null);
            var res = md.ContainsKey(1);
            Assert.IsTrue(res);
        }
    }
}
