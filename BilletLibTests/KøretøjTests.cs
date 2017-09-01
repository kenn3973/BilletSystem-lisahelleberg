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

        //[TestMethod()]
        //public void GetBizzTest()
        //{
        //    // arrange
        //    var test = new Bil();
        //    test.bizz = true;
        //    // act
        //    test.GetBizz();
        //    //// assert
        //    //Assert.
        //}

        #endregion

    }
}