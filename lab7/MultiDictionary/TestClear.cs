using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericApp;

namespace MultiDictionary
{
    [TestClass]
    public class TestClear
    {
        [TestMethod]
        public void MultiDictionary_Clear_ExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(2, "ono");
            md.Clear();
            var res = md.Count;
            Assert.AreEqual(0,res);
        }

        [TestMethod]
        public void MultiDictionary_Clear_NotExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Clear();
            var res = md.Count;
            Assert.AreEqual(0, res);
        }
    }
}
