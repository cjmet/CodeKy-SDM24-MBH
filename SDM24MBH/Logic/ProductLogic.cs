using SDM24MBH.Data;
using SDM24MBH.Logic;
using System.Diagnostics;

namespace SDM24MBH.Logic
{
    public class ProductLogic : IProductLogic
    {
        private Dictionary<Int32, IProduct> _products;
        private ILocalStorage _localStorage;

        public ProductLogic()
        {
            Debug.WriteLine($"Initializing ProductLogic");
            _localStorage = new LocalStorage();
            Debug.WriteLine($"Loading products from local storage");
            _products = _localStorage.LoadProducts().Result;
            Debug.WriteLine($"Loaded {_products.Count} products");
        }

        public Boolean ClearStorage()
        {
            _products.Clear();
            return _localStorage.ClearStorage().Result;
        }

        public Int32 AddProduct(IProduct product)
        {
            IProduct newProduct = (IProduct)new Product();
            var Id = _products.Keys.Max() + 1;
            newProduct.Id = Id;
            _products.Add(Id, newProduct);
            var result = _localStorage.SaveProducts(_products).Result;
            return result ? Id : 0;
        }

        public Int32 AddUpdateProducts(Dictionary<Int32, IProduct> products)
        {
            Int32 result = 0;
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    if (_products.ContainsKey(product.Key))  _products[product.Key] = product.Value; 
                    else _products.Add(product.Key, product.Value);
                }
                result = _localStorage.SaveProducts(_products).Result ? products.Count : 0;
            }
            return result;
        }

        public IProduct? GetProductById(Int32 id)
        {
            _products.TryGetValue(id, out IProduct? product);
            return product;
        }

        public Boolean UpdateProduct(IProduct product)
        {
            Boolean result = false;
            if (_products.ContainsKey(product.Id))
            {
                _products[product.Id] = product;
                result = _localStorage.SaveProducts(_products).Result;
            }
            return result;
        }

        public Boolean DeleteProduct(Int32 id)
        {
            Boolean result = false;
            if (_products.ContainsKey(id)) result = _products.Remove(id);
            return result;
        }

        public Dictionary<Int32, IProduct> GetAllProducts()
        {
            return _products;
        }



        public Dictionary<Int32, IProduct> GetInStockProducts()
        {
            return _products.Where(p => p.Value.Quantity > 0).ToDictionary(p => p.Key, p => p.Value);
        }

        public Dictionary<Int32, IProduct> GetOutOfStockProducts()
        {
            return _products.Where(p => p.Value.Quantity <= 0).ToDictionary(p => p.Key, p => p.Value);
        }

        public Decimal GetTotalValueOfStock()
        {
            return _products.Sum(p => p.Value.Price * p.Value.Quantity);
        }


    }

}
