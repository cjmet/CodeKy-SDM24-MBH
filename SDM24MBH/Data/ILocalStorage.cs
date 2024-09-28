
namespace SDM24MBH.Data
{
    public interface ILocalStorage
    {
        public Task<Boolean> ClearStorage();
        public Task<Int32> SaveProducts(Dictionary<Int32, IProduct> products);
        public Task<Dictionary<Int32, IProduct>> LoadProducts();
        public Task<Int32> AddProduct(IProduct product);
        public Task<Int32> AddUpdateProducts(Dictionary<Int32, IProduct> moreProducts);
        public Task<Int32> DeleteProducts(List<Int32> keysToDelete);
    }
}
