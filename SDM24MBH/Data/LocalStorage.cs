
using System.Diagnostics;
using System.Text.Json;
using Microsoft.Maui.Storage;

namespace SDM24MBH.Data
{
    public class LocalStorage : ILocalStorage
    {
        private StorageType storageType = StorageType.LocalStorage;
        private enum StorageType { LocalStorage, FileStorage };
        private ISecureStorage localStorage = SecureStorage.Default;

        public LocalStorage()
        {
            Debug.WriteLine($"Initializing Storage: {storageType}");
        }

        public async Task<Boolean> ClearStorage()
        {
            if (storageType == StorageType.LocalStorage)
            {
                localStorage.Remove("products");
                var results = await localStorage.GetAsync("products");
                return results == null;
            }
            else
            {
                var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
                File.Delete(path);
                return !File.Exists(path);
            }
        }

        public async Task<Boolean> SaveProducts(Dictionary<Int32, IProduct> products)
        {
            var contents = JsonSerializer.Serialize(products);
            String? results;

            if (storageType == StorageType.LocalStorage)
            {
                await localStorage.SetAsync("products", contents);
                results = await localStorage.GetAsync("products");
                return results == contents;
            }
            else 
            {
                var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
                await File.WriteAllTextAsync(path, contents);
                results = await File.ReadAllTextAsync(path);
                return results == contents;
            }
        }

        public async Task<Dictionary<Int32, IProduct>> LoadProducts()
        {
            var empty = new Dictionary<Int32, IProduct>();

            if (storageType == StorageType.LocalStorage)
            {
                var contents = await localStorage.GetAsync("products");
                if (String.IsNullOrEmpty(contents)) return empty;
                var products = JsonSerializer.Deserialize<Dictionary<Int32, Product>>(contents);
                if (products == null) return empty;
                Dictionary<Int32, IProduct> iProducts = products.ToDictionary(kvp => kvp.Key, p => p.Value as IProduct);
                return iProducts ?? empty;
            }
            else
            {
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
            
        }
    }
}
