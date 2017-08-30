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
    public class BilTests
    {
        // arrange
        Bil testBil = new Bil();

        [TestMethod()]
        public void PrisTest240()
        {
            // act
            int pris = testBil.Pris();
            // assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            // act
            string type = testBil.Køretøj();
            // assert
            Assert.AreEqual("Bil", type);
        }
    }
}