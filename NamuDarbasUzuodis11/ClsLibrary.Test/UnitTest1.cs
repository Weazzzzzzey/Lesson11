using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClsLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        Identify I = new Identify("Dee", "Bost", new DateTime(1996, 12, 12));
        [TestMethod]
        public void MetodasGrazinaTinkamusMetus()
        {
            // Arrange
            int actual = 24;
            // Act
            int expected = I.getAge();
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
