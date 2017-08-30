using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class KøretøjTests
    {
        [TestMethod()]
        public void TælINummerpladeTest9()
        {
            // arrange
            var test = new Bil();
            test.nummerPlade = "123456789";
            // act
            int antal = test.TælINummerplade();
            // assert
            Assert.AreEqual(9, antal);
        }

        [TestMethod()]
        public void TælINummerpladeTest7()
        {
            // arrange
            var test = new MC();
            test.nummerPlade = "1234657";
            // act
            int antal = test.TælINummerplade();
            // assert
            Assert.AreEqual(7, antal);

        }
    }
}