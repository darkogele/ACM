using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined order
            return new Order();
        }

        /// <summary>
        /// Add order and save it 
        /// </summary>
        public bool Save()
        {
            //code for save add
            return true;
        }

        /// <summary>
        /// Validates the order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
