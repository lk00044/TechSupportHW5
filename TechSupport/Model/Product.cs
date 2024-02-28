// Leslie Keller

namespace Products.Model
{
    /// <summary>
    /// Class that represents the Product object
    /// </summary>
    public class Product
    {
        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public double Version { get; set; }

        public DateTime ReleaseDate { get; set; }

    }

}
