using Products.DAL;

namespace TechSupport.Controller
{
    public class ProductDBController
    {
        private ProductDBDAL ProductSource;

        public ProductDBController() { 
            this.ProductSource = new ProductDBDAL();
        }
    }
}
