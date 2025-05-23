namespace coffeeshop.Models.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public IEnumerable<Product> GetTrendingProducts();
        public Product GetProductDetail(int id);

    }
}
