using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
       
        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public static int InstanceCount { get; set; }
    
        /// <summary>
        ///   Save the current customer
        /// </summary>    
        public bool Save(Customer customer)
        {
            //code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrive one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns name="Customer"></returns>
        public Customer Retrive(int customerId)
        {
            // Code that retrives the defined customer
            return new Customer();
        }

        /// <summary>
        /// Retrives all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrive()
        {
            // Code that retrives list of the customers
            return new List<Customer>();
        }

        /// <summary>
        /// Validates the customer Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }
}
