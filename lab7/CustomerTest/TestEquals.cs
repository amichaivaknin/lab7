using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomersApp;

namespace CustomerTest
{
    [TestClass]
    public class TestEquals
    {
        [TestMethod]
        public void Customer_Equals_SameNameSameID()
        {
            Customer c1 = new Customer(1, "a", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Customer_Equals_SameNameDiffID()
        {
            Customer c1 = new Customer(2, "a", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void Customer_Equals_DiffNameSameID()
        {
            Customer c1 = new Customer(1, "b", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void Customer_Equals_DiffNameDiffID()
        {
            Customer c1 = new Customer(2, "b", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void Customer_Equals_NullCustomer()
        {
            Customer c1 = new Customer(2, "b", "c");
            Customer c2 = null;
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void Customer_Equals_NullName()
        {
            Customer c1 = new Customer(2, "b", "c");
            Customer c2 = new Customer(1, null, "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void Customer_Equals_2NullName()
        {
            Customer c1 = new Customer(2, null, "c");
            Customer c2 = new Customer(1, null, "d");
            var res = c1.Equals(c2);
            Assert.AreEqual(false, res);
        }




    }
}
