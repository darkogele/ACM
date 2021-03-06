﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order();
            //code that retrieves the defined order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Add order and save it 
        /// </summary>
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        // Call an insert Stored Procedure
                    }
                    else
                    {
                        // Call and Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}