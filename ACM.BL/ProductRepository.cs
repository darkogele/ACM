using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrive one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrive(int productId)
        {
            // Create the instance of the Product class
            // pass Requested Id
            var product = new Product(productId);

            // Code that retirves the defined product

            // Temporary hard-coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            var myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        /// <summary>
        /// Return all of the products
        /// </summary>
        /// <returns></returns>
        public List<Product> Products()
        {
            //code to return the list of all products 
            return new List<Product>();
        }

        /// <summary>
        /// Saves new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
