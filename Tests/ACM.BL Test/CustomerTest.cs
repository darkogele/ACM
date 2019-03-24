using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValidation()
        {
            //--Arrage
            var customer = new Customer
            {
                FirstName = "Darko",
                LastName = "Gelevski"
            };
            var expected = "Gelevski, Darko";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
