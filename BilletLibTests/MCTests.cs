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
    public class MCTests
    {
        // arrange
        MC testMC = new MC();

        [TestMethod()]
        public void PrisTest125()
        {
            // act
            int pris = testMC.Pris();
            // assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            // act
            string type = testMC.KøretøjsType();
            // assert
            Assert.AreEqual("MC", type);
        }
    }
}