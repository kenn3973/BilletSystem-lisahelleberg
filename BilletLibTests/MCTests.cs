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

        // Denne test sikrer at programmet returnerer den korrekte pris
        [TestMethod()]
        public void PrisTest125()
        {
            // act
            int pris = testMC.Pris();
            // assert
            Assert.AreEqual(125, pris);
        }

        // Denne test sikrer at programmet registrerer det korrekte køretøj
        [TestMethod()]
        public void KøretøjTestMC()
        {
            // act
            string type = testMC.KøretøjsType();
            // assert
            Assert.AreEqual("MC", type);
        }

        // Denne test sikrer at en MC uden brobizz ikke får rabat
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

        // Denne test sikrer at en MC med brobizz får rabat
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