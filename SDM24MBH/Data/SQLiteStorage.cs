// ILocalStorage / Respository implementation for SQLite
using System.Data;
using System.Diagnostics;


namespace SDM24MBH.Data
{
    public class SQLiteStorage : ILocalStorage
    {
        private SQLiteContext _dbcontext;

        public SQLiteStorage(SQLiteContext dbcontext)
        {
            Debug.WriteLine($"Initializing SQLiteStorage");
            _dbcontext = dbcontext;
            return;
        }

        public async Task<int> AddProduct(IProduct product)
        {
            if (product == null) return 0;
            var _products = _dbcontext.Products;
            _products.Add((Product) product);
            var results = await _dbcontext.SaveChangesAsync();

            return results > 0 ? product.Id : 0;
        }

        public Task<int> AddUpdateProducts(Dictionary<int, IProduct> moreProducts)
        {
            var _products = _dbcontext.Products;
            var _ids = _products.Select(p => p.Id);
            foreach (var product in moreProducts)
            {
                var updatedProduct = product.Value as Product;
                if (_ids.Contains(product.Key))
                {
                    Debug.WriteLine($"Updating product {product.Key}");

                    if (updatedProduct != null) _products.Update(updatedProduct);
                }
                else
                {
                    Debug.WriteLine($"Adding product {product.Key}");
                    if (updatedProduct != null) _products.Add(updatedProduct);
                }
            }
            Debug.WriteLine($"Saving products");
            return _dbcontext.SaveChangesAsync();
        }

        public Task<bool> ClearStorage()
        {
            _dbcontext.ResetDatabase();
            return Task.FromResult(true);
        }

        public Task<int> DeleteProducts(List<int> keysToDelete)
        {
            var _products = _dbcontext.Products;
            _products.RemoveRange(_products.Where(p => keysToDelete.Contains(p.Id)));
            return _dbcontext.SaveChangesAsync();
        }

        public Task<Dictionary<int, IProduct>> GetAllProducts()
        {
            Dictionary<int, IProduct> products = _dbcontext.Products.ToDictionary(p => p.Id, p => p as IProduct);
            return Task.FromResult(products);
        }

        public Task<int> SaveProducts(Dictionary<int, IProduct> products)
        {
            return _dbcontext.SaveChangesAsync();
        }
    }
}
