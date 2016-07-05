using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericApp;

namespace MultiDictionary
{
    [TestClass]
    public class TestRemoveK
    {
        [TestMethod]
        public void MultiDictionary_Remove_ExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "ono");
            var res = md.Remove(1);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MultiDictionary_Remove_NotExistKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(2, "ono");
            var res = md.Remove(1);
            Assert.IsFalse(res);
        }
    }
}
