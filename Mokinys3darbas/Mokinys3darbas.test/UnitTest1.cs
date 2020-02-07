using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MokinysLibrary;

namespace Mokinys3darbas.test
{
    [TestClass]
    public class UnitTest1
    {

        Mokinys D11 = new Mokinys(11, "Dominykas",false);
        public void Pasirengti()
        {
            D11.Pazymiai.Add(10);
            D11.Pazymiai.Add(8);
            D11.Pazymiai.Add(8);
            D11.Pazymiai.Add(9);
            D11.Pazymiai.Add(9);
        }

        [TestMethod]
        public void kaiPazymiuNeraNera()
        {
            // Arrange
            //pazimiu neprideta
            decimal actual = D11.getVidurkis();
            // Act
            decimal expected = 0;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void kaiPazymiuYraVienas()
        {
            // Arrange
            D11.Pazymiai.Add(7);
            decimal actual = D11.getVidurkis();
            // Act
            decimal expected = 7;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void kaiPazymiuYraKeli()
        {
            // Arrange
            Pasirengti();
            decimal actual = D11.getVidurkis();
            // Act
            decimal expected = 8.8m;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
