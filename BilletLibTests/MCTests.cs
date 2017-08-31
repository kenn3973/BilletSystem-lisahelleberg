using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    /// <summary>
    /// Denne klasse tester på metoder som har noget at gøre direkte med MC-klassen
    /// </summary>
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

        [TestMethod()]
        public void BroBizzRabatTestNo()
        {
            // arrange 
            var test = new MC();
            test.bizz = false;
            // act
            double rabat = test.BroBizzRabat();
            // assert
            Assert.AreEqual(125, rabat);
        }

        [TestMethod()]
        public void BroBizzRabatYes()
        {
            // arrange
            var test = new MC();
            test.bizz = true;
            // act
            double rabat = test.BroBizzRabat();
            // assert
            Assert.AreEqual(118.75, rabat);
        }
    }
}