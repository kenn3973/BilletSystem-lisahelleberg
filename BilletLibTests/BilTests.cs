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

        // Denne test sikrer at prisen bliver registreret korrekt
        [TestMethod()]
        public void PrisTest240()
        {
            // act
            int pris = testBil.Pris();
            // assert
            Assert.AreEqual(240, pris);
        }

        // Denne test sikrer at køretøjet bliver rigtigt registreret
        [TestMethod()]
        public void KøretøjsTypeTestBil()
        {
            // act
            string type = testBil.KøretøjsType();
            // assert
            Assert.AreEqual("Bil", type);
        }

        // Denne test sikrer at en bil uden brobizz ikke får rabat
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

        // Denne test sikrer at en bil med brobizz får brobizzrabat
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

        // Denne test sikrer at en bil med brobizz får weekendrabat når den passerer broen om lørdagen
        [TestMethod()]
        public void WeekendRabatBilTestYes6()
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

        // Denne test sikrer at en bil med brobizz får rabat når den passerer broen om søndagen
        [TestMethod()]
        public void WeekendRabatBilTestYes7()
        {
            // arrange
            var test = new Bil();
            test.bizz = true;
            test.weekDay = 7;
            // act
            double weekend = test.WeekendRabatBil();
            // assert
            Assert.AreEqual(192, weekend);
        }

        // Denne test sikrer at en bil med brobizz ikke får weekendrabat når den passerer broen en hverdag
        [TestMethod()]
        public void WeekendRabatBilTestYes5()
        {
            // arrange
            var test = new Bil();
            test.bizz = true;
            test.weekDay = 5;
            // act
            double weekend = test.WeekendRabatBil();
            // assert
            Assert.AreEqual(228, weekend);
        }

        // Denne test sikrer at en bil uden brobizz ikke får weekendrabat, når den passerer broen i weekenden
        [TestMethod()]
        public void WeekendRabatBilTestNo6()
        {
            // arrange
            var test = new Bil();
            test.weekDay = 6;
            // act
            double weekend = test.WeekendRabatBil();
            // assert
            Assert.AreEqual(240, weekend);
        }
    }
}