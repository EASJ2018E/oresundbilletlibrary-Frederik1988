using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OeresundBilletLibrary.tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void MainProgramTest()
        {
            //Arrange
            OeresundBilletLibrary.Program.Main();
            var c = OeresundBilletLibrary.Program.IsRunning;

            //Act
            bool test = true;

            //Assert
            Assert.AreEqual(c, test);
        }
    }
}
