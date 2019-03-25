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

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // --Arrage
            var customer = new Customer
            {
                LastName = "Gelevski"
            };
            var expected = "Gelevski";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // --Arrage
            var customer = new Customer
            {
                FirstName = "Darko"
            };
            var expected = "Darko";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arange
            var c1 = new Customer();
            c1.FirstName = "Darko";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Sora";
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer()
            {
                LastName = "Gelevski",
                EmailAddress = "darkogele@hotmail.com"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
                EmailAddress = "Darkogele@live.com"
            };

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
