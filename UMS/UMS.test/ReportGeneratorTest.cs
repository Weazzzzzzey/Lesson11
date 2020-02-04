using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLayer;
using System.Collections.Generic;

namespace UMS.test
{
    [TestClass]
    public class ReportGeneratorTest
    {
        UserRepoository UR = new UserRepoository();
        [TestMethod]
        public void ReturnRightListsCount()
        {
            // Arrange
            ReportGenerator RG = new ReportGenerator(UR.Retrieve());
            List<ReportItem> actual = RG.Generate();
            // Act
            List < User > expected = UR.Retrieve();
            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
