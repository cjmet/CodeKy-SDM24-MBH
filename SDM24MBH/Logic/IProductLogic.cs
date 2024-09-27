using SDM24MBH.Data;

namespace SDM24MBH.Logic
{
    public interface IProductLogic
    {
        public bool ClearStorage();
        public int AddProduct(IProduct product);
        public int AddUpdateProducts(Dictionary<int, IProduct> products);
        public IProduct? GetProductById(int id);
        public bool UpdateProduct(IProduct product);
        public bool DeleteProduct(int id);

        public Dictionary<int, IProduct> GetAllProducts();
        public Dictionary<int, IProduct> GetInStockProducts();
        public Dictionary<int, IProduct> GetOutOfStockProducts();

        public decimal GetTotalValueOfStock();
    }
}
