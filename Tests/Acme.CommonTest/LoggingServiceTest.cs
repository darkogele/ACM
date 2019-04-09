using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "Darkogele@hotmail.com",
                FirstName = "Darko",
                LastName = "Gelevski",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "PS4",
                ProductDescription ="Gaming Console with the best collection of games",
                CurrentPrice = 22000M
            };
            changedItems.Add(product);

            //--Act
            LogginService.WriteToFile(changedItems);

            //--Assert
            //--Nothing here to assert
        }
    }
}
