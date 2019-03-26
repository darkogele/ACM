using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrive one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns name="Customer"></returns>
        public Customer Retrive(int customerId)
        {
            // Create the instnace of CUstomer class
            // Pass the requested id
            var customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "Darkogele@gmail.com";
                customer.FirstName = "Darko";
                customer.LastName = "Gele";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        ///   Save the current customer
        /// </summary>    
        public bool Save(Customer customer)
        {
            var customerDb = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EmailAddress = customer.EmailAddress
            };

            //code that saves the defined customer
            //Mapping values before DBContext

            return true;
        }
    }
}
