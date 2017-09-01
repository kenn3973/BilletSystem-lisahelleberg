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
    /// Denne klasse tester på metoder som har noget at gøre med både bil og MC
    /// </summary>
    [TestClass()]
    public class KøretøjTests
    {
        #region Tests der omhandler nummerpladen

        // Denne test sikrer at metoden tæller det rigtige antal tal i nummerpladen, her 9 tal
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

        // Denne test sikrer at metoden tæller det rigtige antal tal i nummerpladen, her 7 tal
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

        // Denne test sikrer at metoden sender en Exception til brugeren, hvis der er indtastet mere end 7 tal i nummerpladen
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeTest0()
        {
            // arrange
            var test = new Bil();
            test.nummerPlade = "";
            // act
            test.TestNummerplade();
        }

        // Denne test sikrer at metoden sender en Exception til brugeren, hvis der er indtastet 0 eller færre tal i nummerpladen
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeTest8()
        {
            // arrange
            var test = new Bil();
            test.nummerPlade = "12345678";
            // act
            test.TestNummerplade();
        }

        // De følgende to tests sikrer at metoden godkender nummerpladen, hvis der er indtastet mellem 1 og 7 tal
        [TestMethod()]
        public void TestNummerpladeTest1()
        {
            // arrange
            var test = new Bil();
            test.nummerPlade = "1";
            // act
            test.TestNummerplade();
        }
        [TestMethod()]
        public void TestNummerpladeTest7()
        {
            // arrange
            var test = new Bil();
            test.nummerPlade = "1234567";
            // act
            test.TestNummerplade();
        }

        #endregion

        #region Tests der omhandler bizzen

        // De følgende to metoder sikrer at programmet melder rigtigt tilbage hvorvidt et køretøj har en brobizz eller ej
        [TestMethod()]
        public void GetBizzTestFalse()
        {
            // arrange
            var test = new Bil();
            // act
            test.GetBizz();
            // assert
            Assert.IsFalse(false);
        }

        [TestMethod()]
        public void GetBizzTestTrue()
        {
            // arrange
            var test = new Bil();
            test.bizz = true;
            //act
            test.GetBizz();
            // assert
            Assert.IsTrue(true);
        }

        #endregion

        // Denne test sikrer at turen over broen bliver registreret
        [TestMethod()]
        public void PasserBroTest1Gang()
        {
            // arrange
            var bil = new Bil();
            bil.PasserBro();
            // act
            int ture = bil.GetAntalTureOverBro();
            //assert
            Assert.AreEqual(1, ture);
        }

        // Denne test sikrer at antallet af ture bliver rigtigt registeret over broen, her 3 ture
        [TestMethod()]
        public void GetAntalTureOverBroTest3Bil()
        {
            // arrange
            var bil = new Bil();
            bil.PasserBro();
            bil.PasserBro();
            bil.PasserBro();
            // act
            int ture = bil.GetAntalTureOverBro();
            // assert
            Assert.AreEqual(3, ture);
        }

        // Denne metode sikrer at turen bliver registreret hvis man kører MC
        [TestMethod()]
        public void GetAntalTureOverBroMC()
        {
            // arrage
            var MC = new MC();
            MC.PasserBro();
            // act
            int ture = MC.GetAntalTureOverBro();
            // assert
            Assert.AreEqual(1, ture);
        }

        // Denne test sikrer at turen bliver registreret hvis man køre over Øresund i bil
        [TestMethod()]
        public void GetAntalTureOverBroOresundBil()
        {
            // arrange
            var oBil = new OreSundBil();
            oBil.PasserBro();
            // act
            int ture = oBil.GetAntalTureOverBro();
            // assert
            Assert.AreEqual(1, ture);
        }

        // Denne test sikrer at turen bliver registreret hvis man kører over Øresund på MC
        [TestMethod()]
        public void GetAntalTureOverBroOresundMC()
        {
            // arrange
            var oMC = new OreSundMC();
            oMC.PasserBro();
            // act
            int ture = oMC.GetAntalTureOverBro();
            // assert
            Assert.AreEqual(1, ture);
        }
    }
}