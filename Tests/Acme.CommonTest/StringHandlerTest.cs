using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestVali()
        {
            //--Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            //--Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            //--Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";          

            //--Act
            var acutal = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, acutal);
        }
    }
}
