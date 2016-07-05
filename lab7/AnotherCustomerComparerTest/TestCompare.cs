using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomersApp;

namespace AnotherCustomerComparerTest
{
    [TestClass]
    public class TestCompare
    {
        [TestMethod]
        public void AnotherCustomerComparer_Compare_SameId()
        {
            AnotherCustomerComparer acc = new AnotherCustomerComparer();
            Customer c1 = new Customer(1, "a", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = acc.Compare(c1, c2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void AnotherCustomerComparer_Compare_SmallId()
        {
            AnotherCustomerComparer acc = new AnotherCustomerComparer();
            Customer c1 = new Customer(2, "a", "c");
            Customer c2 = new Customer(1, "a", "d");
            var res = acc.Compare(c1, c2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void AnotherCustomerComparer_Compare_BigId()
        {
            AnotherCustomerComparer acc = new AnotherCustomerComparer();
            Customer c1 = new Customer(1, "a", "c");
            Customer c2 = new Customer(2, "a", "d");
            var res = acc.Compare(c1, c2);
            Assert.AreEqual(-1, res);
        }
    }
}
