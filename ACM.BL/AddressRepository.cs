using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the address class
            // Pass the requested Id
            var address = new Address();
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Petar Deljan 1-1/15";
                address.StreetLine2 = "Treta Makedonska Brigada 41-4-15";
                address.City = "Skopje";
                address.State = "MKD";
                address.Country = "Macedonia";
                address.PostalCode = "1000";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses for the customer
            // Temporary hard-coded values to return
            // a set of addresses for a customer
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Petar Deljan 1-1/15",
                StreetLine2 = "Treta Makedonska Brigada 41-4-15",
                City = "Skopje",
                State = "MKD",
                Country = "Macedonia",
                PostalCode = "1000"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle earth",
                PostalCode = "0500"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Code that saves the address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // Code to saves the passed address.
            return true;
        }
    }
}
