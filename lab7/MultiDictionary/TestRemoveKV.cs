using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericApp;

namespace MultiDictionary
{
    [TestClass]
    public class TestRemoveKV
    {
        [TestMethod]
        public void MultiDictionary_Remove_ExistValueAndKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "ono");
            var res = md.Remove(1, "ono");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MultiDictionary_Remove_NotExistValue()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "ono");
            var res = md.Remove(1, "one");
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void MultiDictionary_Remove_NotExistKet()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "ono");
            var res = md.Remove(2, "ono");
            Assert.IsFalse(res);
        }
    }
}
