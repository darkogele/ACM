using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrive one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrive(int productId)
        {
            //code that retirves the defined product
            return new Product();
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
            //code saves product
            return true;
        }

        /// <summary>
        /// Validates the Product
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
