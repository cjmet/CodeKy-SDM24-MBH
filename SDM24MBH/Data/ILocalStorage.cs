
namespace SDM24MBH.Data
{
    public interface ILocalStorage
    {
        public Task<Boolean> ClearStorage();
        public Task<Boolean> SaveProducts(Dictionary<Int32, IProduct> products);
        public Task<Dictionary<Int32, IProduct>> LoadProducts();
    }
}
