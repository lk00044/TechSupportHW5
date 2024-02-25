using Customers.Model;
using Products.DAL;
using Products.Model;

/// <summary>
/// Handles the interaction between the view and the Product Data Access Layer 
/// </summary>
/// 
namespace TechSupport.Controller
{
    public class ProductDBController
    {
        private ProductDBDAL ProductSource;

        public ProductDBController() { 
            this.ProductSource = new ProductDBDAL();
        }


        /// <summary>
        /// Returns the products from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Product> GetProducts()
        {
            return this.ProductSource.GetProducts();
        }
    }
}
