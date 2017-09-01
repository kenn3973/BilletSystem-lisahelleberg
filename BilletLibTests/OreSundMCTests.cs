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
    /// Denne klasse tester metoder der kun har noget med ØresundMC at gøre
    /// </summary>
    [TestClass()]
    public class OreSundMCTests
    {
        // Denne test sikrer at køretøjstypen bliver korrekt registreret
        [TestMethod()]
        public void KøretøjsTypeTest()
        {
            // arrange
            OreSundMC MC = new OreSundMC();
            // act
            string type = MC.KøretøjsType();
            // assert
            Assert.AreEqual("Øresund MC", type);
        }

        // Denne test sikrer at prisen bliver registreret korrekt
        [TestMethod()]
        public void PrisTest()
        {
            // arrange
            OreSundMC MC = new OreSundMC();
            // act
            int pris = MC.Pris();
            // assert
            Assert.AreEqual(210, pris);
        }

        // Denne test sikrer at bizzprisen bliver korrekt registreret
        [TestMethod()]
        public void BizzPrisTest()
        {
            // arrange
            OreSundMC MC = new OreSundMC();
            // act
            int pris = MC.BizzPris();
            // assert
            Assert.AreEqual(73, pris);
        }

        // Denne test sikrer at en MC med brobizz får den rigtige rabat
        [TestMethod()]
        public void BroBizzRabatOresundTestYes()
        {
            // arrange
            OreSundMC MC = new OreSundMC();
            MC.bizz = true;
            // act
            int rabat = MC.BroBizzRabatOresund();
            // assert
            Assert.AreEqual(73, rabat);
        }

        // Denne test sikrer at en MC uden brobizz ikke får rabat
        [TestMethod()]
        public void BroBizzRabatOresundTestNo()
        {
            // arrange
            OreSundMC MC = new OreSundMC();
            // act
            int rabat = MC.BroBizzRabatOresund();
            // assert
            Assert.AreEqual(210, rabat);
        }
    }
}