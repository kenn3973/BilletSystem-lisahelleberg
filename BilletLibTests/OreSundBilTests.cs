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
        // Denne test sikrer at prisen bliver rigtigt registreret
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

        [TestMethod()]
        public void PrisTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BizzPrisTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BroBizzRabatOresundTest()
        {
            Assert.Fail();
        }
    }
}