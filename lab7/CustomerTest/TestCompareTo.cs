using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomersApp;

namespace CustomerTest
{
    [TestClass]
    public class TestCompareTo
    {
        [TestMethod]
        public void Customer_CompereTo_SameName()
        {
            Customer c1= new Customer(2,"a","c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(0,res);
        }

        [TestMethod]
        public void Customer_CompereTo_NullName()
        {
            Customer c1 = new Customer(2, "a", "c");
            Customer c2 = new Customer(1, null, "d");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Customer_CompereTo_2NullName()
        {
            Customer c1 = new Customer(2, null, "c");
            Customer c2 = new Customer(1, null, "d");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Customer_CompereTo_BigName()
        {
            Customer c1 = new Customer(2, "a", "c");
            Customer c2 = new Customer(1, "b", "d");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void Customer_CompereTo_SmallName()
        {
            Customer c1 = new Customer(2, "b", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Customer_CompereTo_SameCostumer()
        {
            Customer c1 = new Customer(1, "a", "c");
            Customer c2 = new Customer(1, "a", "c");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Customer_CompereTo_SameCostumerInsensitive()
        {
            Customer c1 = new Customer(1, "a", "c");
            Customer c2 = new Customer(1, "A", "c");
            var res = c1.CompareTo(c2);
            Assert.AreEqual(0, res);
        }
    }
}
