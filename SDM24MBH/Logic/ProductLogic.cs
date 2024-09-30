using SDM24MBH.Data;
using SDM24MBH.Logic;
using System.Diagnostics;


namespace SDM24MBH.Logic
{
    public class ProductLogic : IProductLogic
    {
        private ILocalStorage _localStorage;

        public ProductLogic(ILocalStorage localStorageDI)
        {
            Debug.WriteLine($"Initializing ProductLogic");
            _localStorage = localStorageDI;
            return;
        }

        public async Task<Dictionary<Int32, IProduct>> GetAllProducts()
        {
            var _products = await _localStorage.GetAllProducts();
            return _products;
        }

        public async Task<Boolean> ClearStorage()
        {
            return await _localStorage.ClearStorage();
        }

        public async Task<Int32> AddProduct(IProduct product)
        {
            var result = await _localStorage.AddProduct(product);
            return result;
        }

        public async Task<Int32> AddUpdateProducts(Dictionary<Int32, IProduct> products)
        {
            var result = await _localStorage.AddUpdateProducts(products);
            return result;
        }

        public async Task<Int32> DeleteProducts(List<Int32> keysToDelete)
        {
           var results = await _localStorage.DeleteProducts(keysToDelete);
            return results;
        }

        public async Task<Dictionary<Int32, IProduct>> GetInStockProducts()
        {
            var data = await GetAllProducts();
            var results =  data.Where(p => p.Value.Quantity > 0).ToDictionary(p => p.Key, p => p.Value);
            return results;
        }

        public async Task<Dictionary<Int32, IProduct>> GetOutOfStockProducts()
        {
            var data =  await GetAllProducts();
            var results = data.Where(p => p.Value.Quantity <= 0).ToDictionary(p => p.Key, p => p.Value);
            return results;
        }

        public async Task<Decimal> GetTotalValueOfStock()
        {
            var data = await GetAllProducts();
            var results = data.Sum(p => (p.Value.Quantity >= 0 ? p.Value.Quantity : 0 ) * p.Value.Price );
            return results;
        }
    }

}
