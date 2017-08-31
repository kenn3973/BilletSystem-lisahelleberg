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
    /// Denne klasse tester på metoder som har noget at gøre direkte med bil-klassen
    /// </summary>
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
            string type = testBil.KøretøjsType();
            // assert
            Assert.AreEqual("Bil", type);
        }

        [TestMethod()]
        public void BroBizzRabatTestNo()
        {
            // arrange 
            var test = new Bil();
            test.bizz = false;
            // act
            double rabat = test.BroBizzRabat();
            // assert
            Assert.AreEqual(240, rabat);

        }

        [TestMethod()]
        public void BroBizzRabatTestYes()
        {
            // arrange
            var test = new Bil();
            test.bizz = true;
            // act
            double rabat = test.BroBizzRabat();
            // assert
            Assert.AreEqual(228, rabat);
        }

        /// <summary>
        /// Denne test sikrer at en bil 
        /// </summary>
        [TestMethod()]
        public void WeekendRabatBilTestYesYes()
        {
            // arrange 
            var test = new Bil();
            test.bizz = true;
            test.weekDay = 6;
            // act
            double weekend = test.WeekendRabatBil();
            // assert
            Assert.AreEqual(192, weekend);
        }
    }
}