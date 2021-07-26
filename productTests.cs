using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRBChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBChallenge.Tests
{
    [TestClass()]
    public class productTests
    {
        [TestMethod()]
        public void numDuplicatesTest()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glove", "glove", "glove" };
            int[] price = { 2, 3, 1, 2, 1 };
            int[] weight = { 2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name,price,weight);
            Assert.AreEqual(1, result);
        }


        [TestMethod()]
        public void numDuplicatesTest_NoDuplicates()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glove1", "glove2", "glove3" };
            int[] price = { 2, 3, 1, 2, 1 };
            int[] weight = { 2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void numDuplicatesTest_withMultipleDuplicates()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glove", "glove", "glove" };
            int[] price = { 2, 3, 1, 1, 1 };
            int[] weight = { 2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void numDuplicatesTest_withMultipleDuplicatesTest2()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glove", "glove", "glove","ball" };
            int[] price = { 2, 3, 1, 1, 1,2 };
            int[] weight = { 2, 5, 1, 1, 1,2 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void numDuplicatesTest_priceConstraintTest()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glove", "glove", "glove" };
            int[] price = { 2, 3, 1, 1, 10000 };
            int[] weight = { 2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void numDuplicatesTest_nameConstraintTest()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glovegoveglove", "glove", "glove" };
            int[] price = { 2, 3, 1, 1, 10000 };
            int[] weight = { 2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void numDuplicatesTest_weightConstraintTest()
        {
            product p = new product();
            string[] name = { "ball", "bat", "glovegoveglove", "glove", "glove" };
            int[] price = { 2, 3, 1, 1, 10000 };
            int[] weight = { -2, 5, 1, 1, 1 };
            int result = p.numDuplicates(name, price, weight);
            Assert.AreEqual(-1, result);
        }
    }
}