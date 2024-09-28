using SDM24MBH.Data;

namespace SDM24MBH.Logic
{
    public interface IProductLogic
    {
        public Task<Boolean> ClearStorage();    // Utility
        public Task<Int32> AddProduct(IProduct product);    // Create
        public Task<Dictionary<int, IProduct>> GetAllProducts();    // Read
        public Task<Int32> AddUpdateProducts(Dictionary<int, IProduct> products);   // Update
        public Task<Int32> DeleteProducts(List<int> keysToDelete);  // Delete


        public Task<Dictionary<int, IProduct>> GetInStockProducts();
        public Task<Dictionary<int, IProduct>> GetOutOfStockProducts();
        public Task<decimal> GetTotalValueOfStock();
    }
}
