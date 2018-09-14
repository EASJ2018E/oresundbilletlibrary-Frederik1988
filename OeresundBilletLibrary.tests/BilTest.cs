using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OeresundBilletLibrary.tests
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var bil = new Bil();

            //Act
            var pris = bil.Pris();

            //Assert
            Assert.AreEqual(410, pris);
        }

        [TestMethod]

        public void K�ret�j()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string k�ret�j = "�resund Bil";

            //Assert
            Assert.AreSame(k�ret�j, bil.K�ret�j());

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nummerpladen du har indtastet indeholder for mange cifre")]

        public void ForLangNummerPlade()
        {
            //Arrange
            var bil = new Bil("cb123456", new DateTime(2018, 9, 14));
        }

        [TestMethod]

        public void NummerPlade()
        {
            //Arrange
            var bil = new Bil("cd12345", new DateTime(2018, 9, 14));

            //Act
            string nummerPlade = bil.NummerPlade;

            //Assert
            Assert.AreEqual(7, nummerPlade.Length);
        }

        [TestMethod]

        public void BroBizzRabat()
        {
            //Arrange
            var bil = new Bil();

            //Act
            decimal prisMedRabat = bil.BroBizz();

            //Assert
            Assert.AreEqual(161m, prisMedRabat);
        }
    }
}
