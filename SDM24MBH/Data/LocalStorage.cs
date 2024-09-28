
using System.Diagnostics;
using System.Text.Json;
using Microsoft.Maui.Storage;

namespace SDM24MBH.Data
{
    public class LocalStorage : ILocalStorage
    {
        public async Task<Boolean> ClearStorage()
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
            File.Delete(path);
            return !File.Exists(path);
        }

        public async Task<Int32> SaveProducts(Dictionary<Int32, IProduct> products)
        {
            var contents = JsonSerializer.Serialize(products);
            String? results;
            var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
            await File.WriteAllTextAsync(path, contents);
            results = await File.ReadAllTextAsync(path);
            return results == contents ? products.Count : -products.Count;
        }

        public async Task<Dictionary<Int32, IProduct>> LoadProducts()
        {
            var empty = new Dictionary<Int32, IProduct>();
            var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
            var exists = File.Exists(path);
            if (!exists) return empty;
            var contents = await File.ReadAllTextAsync(path);
            if (String.IsNullOrEmpty(contents)) return empty;
            var products = JsonSerializer.Deserialize<Dictionary<Int32, Product>>(contents);
            if (products == null) return empty;
            Dictionary<Int32, IProduct> iProducts = products.ToDictionary(kvp => kvp.Key, p => p.Value as IProduct);
            return iProducts ?? empty;
        }

        public async Task<Int32> AddProduct(IProduct product)
        {
            var products = await LoadProducts();
            var id = products.Count > 0 ? products.Keys.Max() + 1 : 1;
            product.Id = id;
            products.Add(id, product);
            var result = await SaveProducts(products);
            return result > 0 ? id : 0;
        }

        public async Task<Int32> AddUpdateProducts(Dictionary<Int32, IProduct> moreProducts)
        {
            var products = await LoadProducts();
            foreach (var kvp in moreProducts)
                if (products.ContainsKey(kvp.Key)) products[kvp.Key] = kvp.Value;
                else products.Add(kvp.Key, kvp.Value);
            var result = await SaveProducts(products);
            return result;
        }

        // return the number of products deleted or -result 
        public async Task<Int32> DeleteProducts(List<Int32> keysToDelete)
        {
            var products = await LoadProducts();
            var startCount = products.Count;
            foreach (var key in keysToDelete)
                if (products.ContainsKey(key)) products.Remove(key);
            var result = startCount - await SaveProducts(products);
            return result == keysToDelete.Count ? result : - result;
        }
        // --- 
    }
}
