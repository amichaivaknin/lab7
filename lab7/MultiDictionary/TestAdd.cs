using System;
using GenericApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiDictionary
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void MultiDictionary_Add_NotExistValueAndKey()
        {
            MultiDictionary<int,string> md = new MultiDictionary<int,string>();
            md.Add(1,"one");
            var res = md.ContainsKey(1, "one");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MultiDictionary_Add_NotExistValue()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "one");
            md.Add(1, "ono");
            var res = md.ContainsKey(1, "ono");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MultiDictionary_Add_ExistValueAndKey()
        {
            MultiDictionary<int, string> md = new MultiDictionary<int, string>();
            md.Add(1, "ono");
            md.Add(1, "ono");
            var res = md.ContainsKey(1, "ono");
            Assert.IsTrue(res);
        }
    }
}
