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
    /// Denne klasse tester på metoder som kun har noget med OreSundBil-klassen at gøre
    /// </summary>
    [TestClass()]
    public class OreSundBilTests
    {
        // Denne test sikrer at køretøjet bliver rigtigt registreret
        [TestMethod()]
        public void KøretøjsTypeTest()
        {
            // arrange
            OreSundBil bil = new OreSundBil();
            // act
            string type = bil.KøretøjsType();
            // assert
            Assert.AreEqual("Øresund Bil", type);
        }

        // Denne test sikrer at prisen blive rigtigt registreret
        [TestMethod()]
        public void PrisTest410()
        {
            // arrange
            OreSundBil bil = new OreSundBil();
            // act
            int pris = bil.Pris();
            // assert
            Assert.AreEqual(410, pris);
        }

        // Denne test sikrer at prisen på brobizz bliver korrekt registreret
        [TestMethod()]
        public void BizzPrisTest()
        {
            // arrange
            OreSundBil bil = new OreSundBil();
            // act
            int brobizzPris = bil.BizzPris();
            // assert
            Assert.AreEqual(161, brobizzPris);
        }

        // Denne test sikrer at en bil med brobizz får den rigtige rabat
        [TestMethod()]
        public void BroBizzRabatOresundTestYes()
        {
            OreSundBil bil = new OreSundBil();
            bil.bizz = true;
            // act
            int bizzPris = bil.BroBizzRabatOresund();
            // assert
            Assert.AreEqual(161, bizzPris);
        }

        // Denne test sikrer at en bil uden brobizz ikke får rabat
        [TestMethod()]
        public void BroBizzRabatOresundTestNo()
        {
            // arrange
            OreSundBil bil = new OreSundBil();
            // act
            int bizzpris = bil.BroBizzRabatOresund();
            // assert
            Assert.AreEqual(410, bizzpris);
        }
    }
}