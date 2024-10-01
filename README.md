<h1 style="margin: 0">CodeKy-SDM24-MBH</h1>

<font size="4">A MAUI Blazor Hybrid Demo Project as a multi-platform alternative to ASP .NET with MVC</font>

The MAUI Blazor Hybrid framework uses the more mature Blazor front end combined the MAUI multi-platform back end to deliver a full multi-platform package.

- Hardware Requirements: 
    - 2 physical cores, 4 threads, 8+ gigabytes of memory is required, but not recommended.
    - **6 physical hardware cores with 12+ gigabytes of memory is recommended.**
- Class Requirements: Module 3 or Module 4.

&nbsp;
## Table of Contents

- [Development Hardware Requirements](#development-hardware-requirements)
- [Important Notes](#important-notes)
- [Additional References](#additional-references)
- [Project Plan](#project-plan)
  - [Part 1](#part-1)
  - [Part 2](#part-2)
  - [Part 3](#part-3)
  - [Part 4](#part-4)
  - [Part 5](#part-5)
  - [Part 6](#part-6)
- [Project Blog](#project-blog)

&nbsp;
## Development Hardware Requirements

- **6 physical hardware cores with 12+ gigabytes of memory is recommended.**
- Physical hardware SSD with a direct local path, with no spaces in the path names.
  - Ex: c:\users\username\local\Solution47\Project23
<details>
<summary>Compiling to Multiple Targets</summary>

- If you do not have the hardware, do not attempt to complile to non-native targets.
- 8 performance cores are preferred, but 4 performance cores with 4 additional efficiency cores will work with some impact on performance.
  - As an Example: For Desktops an i7-xx700 or Ryzen 7, Dated 2020 or newer.
  - Notebooks/Mobile, you'll have to lookup the specs.
  - **<u>4+ Physical Hardware Cores**</u> on Bare Metal Hardware are **<u>REQUIRED</u>**
  - Windows 11 compatible cores dated 2020 or newer are recommended, but not required.
    - A 2025 i7-14700 is up to 80% faster than a 2020 i7-10700.
    - Windows 10 expires Fall of 2025.
  - The emulator needs 4 cores, and you need 2 additional cores on the host to support it. Then you need a couple more cores to support other processes, programs, and tabs running on the host.
    - **4 Cores:** If you have only 4 cores, you'll have to set the emulator to only use 2 cores, the default is 4 cores for the emulator. The emulator will then be running at half speed, and you'll have no resources left to support other programs and will have to keep everything non-essential closed when testing in the emulator. This is not recommended.
    - **6 Cores:** If you have only 6 cores, you'll have no extra resources to support processes on the host and will have to keep non-essential programs and tabs closed when testing in the emulator. But at least the emulator will run at full speed.
    - **8+ Cores:** will give you enough cores for the emulator, system support, and a couple left over to run additional processes and programs on the host.
  - The android emulator will not run in a VM<sup>\*</sup>
    - There are ways around this, but I'm not going into additional admin issues that will un-necessarily complicate things. If you are a student just now learning, I recommend you make sure you have the required hardware first, (6 cores), then you can focus all your time on learning C#, Maui, and Blazor.
    - Additional Cloud VM testing also failed.
    - A physical Android device can be used instead of the emulator, but the emulator is the recommended testing platform.
- Networked, Subst, and other drive types will fail to publish unless you complete additional configuration options.
  - [Error DEP0700 : Registration of the app failed.](https://stackoverflow.com/questions/42020845/error-dep0700-registration-of-the-app-failed-on-windows-10-on-a-macbook-dual)

### &ensp;Personal VM Note

- Responsiveness vs Peak Performance
  - (6 vCores <sup>P-2</sup>, 16 gb static memory) is considerably more responsive, snappier, vs (12 vCores, 24 gb dynamic memory) which has twice the peak performance under load.

</details>

&nbsp;
## Important Notes

- Do not modify the .csproj targets, as this can have unintended consequences. As an example, by default the project should restrict the use of incompatible libraries.
- Do not use underlines, spaces, or other special characters in the project name. Hyphens are allowed.

<details>
<summary> Additional References </summary>

- [Maui Blazor Platform Features](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/8-platform-features)
  - [Android Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/android/platform-specifics/)
  - [iOS Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/ios/platform-specifics/)
  - [Windows Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/windows/platform-specifics/)
  - [Invoke Native Platform Code](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/invoke-platform-code/)
- [Project Structure for Blazor Apps](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure)
- [Preferences]
- [Local Storage](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/secure-storage?view=net-maui-8.0&tabs=windows)

#### &emsp;<u>Example Projects</u>

- [Build a Blazor Movie Database](https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/?view=aspnetcore-8.0)
- [Microsoft: Build a .NET MAUI Blazor Hybrid app with a Blazor Web App](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui-blazor-web-app?view=aspnetcore-8.0)
- [YouTube: Let's build REST API Client Desktop App using .Net MAUI Blazor Hybrid for Windows and Mac OS Desktop](https://www.youtube.com/watch?app=desktop&v=HKMhgOAZLWw)
- [FreeCodeCamp: Learn Blazor WebAssembly and Web API on .NET 6 by Building a Shopping Cart App](https://www.freecodecamp.org/news/learn-blazor-webassembly-and-web-api-on-net-6-by-building-a-shopping-cart-app/)

</details>

&nbsp;
## Project Plan
---

### Part 1
<details>

1. Initial Setup and Tutorial
   1. [Microsoft: Build a .NET MAUI Blazor Hybrid app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-8.0)
      1. Make sure to test the default app on both Android and Windows.
   1. [Microsoft: Build a mobile and desktop app with Blazor Hybrid and .NET MAUI](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/)
   1. Add a "Delete Completed Items Button"
      1. `<button @onclick="()=>todos.RemoveAll(todo => todo.IsDone)">Delete Done (Inline)</button>`
   1. Don't forget to test on Android in addition to Windows

---
</details>

### Part 2
<details>

1. Apply what we've learned so far to a simplified version of the Pet Shop Project
    1. Keep it Simple and Functional First. We'll add Features Later.
    1. `async void` should only be used for event handlers.
        1. `async Task` should be used for all other 'async void' methods.
    1. Add a modified Product Class and Interface from the Petshop to the Data Folder.
        1. Be aware of name spaces.
        1. Lets keep it simple and only one basic Class.
        1. Add an unique Id field.  We'll use this to identify items in a dictionary.
        1. Add an isSelected field.  We'll use this to identify items selected for actions like Add, Delete, Update, Purchase, etc.
            ```
            public class Product : IProduct
            {
                public Int32 Id { get; set; }
                public Boolean isSelected { get; set; } = false;
                public String Brand { get; set; } = "";
                public String Name { get; set; } = "";
                public String Description { get; set; } = "";
                public Decimal Price { get; set; }
                public Int32 Quantity { get; set; }
            }
            ```
    1. Add an Inventory link to the Nav
    1. Add an Inventory.razor component
        1. Have it display up to 10 lines of inventory, we can add paging later.
            ```
            @{counter = 0;}
            <ul class="list-unstyled">
                @foreach (var product in _products)
                {
                    if (++counter > 10) {
                        @("Too many products");
                        break;
                    }
                    @* --- Snipped for Brevity --- *@
            ```
            1. Another non-standard way to do this would be a span, but it throws a warning:
            ```
            <span>Too many products</span> 
            ```
        1. Model it after the ToDo page. 
        1. You'll need Buttons and Inputs for CRUD: Add, Load, Save, and Delete
        1. We want to keep things simple and functional first.  Get the skeleton's syntax and struture correct and functioning first.  So for now just set the buttons up with a simple alert message.  We'll fix the actual functions later.
            ```
            private async Task NIA()
            {
                await App.Current.MainPage.DisplayAlert("NIA", $"Not Implemented Alert.", "OK");
                return;
            }
            ```
        1. Don't forget the @page and @use directives at the top of the file.
            ```
            @page "/inventory"
            @using YourProjectName.Data;
            ```
        1. Add 9 or 10 products for testing in an initial statement in the code block if you have not already.
            ```
            private Dictionary<int, Product> _products = new Dictionary<int, Product>
            {
                { 1, new Product { Id = 1, Name = "Product 1", Description="Description 1", Price = 100, Quantity = 1 } },
                { 2, new Product { Id = 2, Name = "Product 2", Description="Description 2", Price = 200, Quantity = 2 } },
                { 3, new Product { Id = 3, Name = "Product 3", Description="Description 3", Price = 300, Quantity = 3 } },
                // --- Snipped for Brevity ---
            ```         
        1. Test that and make sure everything is working and wired up correctly.
        
     1. You should probably check that the dictionary keys match the product ids.
        1. Something like `<label>@(product.Key != product.Value.Id ? $"KeyError[{product.Key}]" : product.Key)</label>`
        1. Then create one product that purposely has a mismatched key and id to test it.
     1. Now lets wire up those buttons.
        1. Begin with the Add Buttton, this should be just like what you did in the tutorials.
            1. make sure to use an unique Id for each product. Ex: `var Id = _products.Keys.Max() + 1;`
            1. Don't forget to set the product.ID field as well as the Dictionay.Key.
            1. After You've added the product, clear the input fields.  
                1. The easiest way to do this is to just new up a product in the bound input variable.
                1. `newProduct = new Product();`
            1. Test it.
        1. Then move on to the other buttons, testing each one as you go.
        1. We should really load the products from file by default.  
            1. [Microsoft: Blazor Component lifecycle](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components#component-lifecycle)
            1. Lets try OnInitializedAsync()...
                ```
                protected override async Task OnInitializedAsync()
                {
                    await base.OnInitializedAsync();
                    await LoadProducts();
                }
                ```
        1. Lets do a little cleaning and comment out the Counter and Weather Nav Options.  This should leave Home, Todo, and Inventory.
        1. Maybe clean up the Home Page and make things prettier.  Maybe add a little more information about the project.  Whatever you think is appropriate.
        1. Lets add a Logo to Home.Razor
            1. [Display images and documents in ASP.NET Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/images-and-documents?view=aspnetcore-8.0)
            1. copy logo.png to wwwroot
            1. `<img src="logo.png" alt="Logo" />`
        1. Don't forget to test on Android as well as Windows.
     1. Spacing?  I know I said minimal skeleton, but it really needs at least a microscopic amount of work.
        1. Ex: 
            ```
            @* --- Snipped for Brevity --- *@
            <label style="width:2em; text-align: right;">@(product.Key != product.Value.Id ? $"KeyError[{product.Key}]" : product.Key)</label>
            @* --- Snipped for Brevity --- *@
            <input @bind="product.Value.Description" style="width: 30em;" />
            <label> &nbsp Qty:</label><input @bind="product.Value.Quantity" type="number" style="width: 4em; text-align: right;" />
            <label> &nbsp  $</label><input @bind="product.Value.Price" type="number" style="width: 5.25em; text-align: right;" />
            ```
        1. We should probably do tables or grids instead.  But that's a bit more complicated, so we'll leave that for later.
        1. That description width is probably going to bite us on android.  It may need to be smaller.  It might need to be a different component all together.  We'll see.
![Screenshot01](https://github.com/cjmet/CodeKy-SDM24-MBH/blob/main/SDM24MBH/Files/Screenshot01.png?raw=true)

---
</details>

### Part 3
<details>
1. Visual UI <- Interface ->  Storage
    1. it's time to refactor and start adding in all our pet shop functionality.

1. Lets fix IProduct and Product First.
    1. Create the IProduct Class and IProductLogic Interface in the Data directory
        ```
        public interface IProduct
        {
            public Int32 Id { get; set; }
            public Boolean isSelected { get; set; }

            public String Brand { get; set; } 
            public String Name { get; set; } 
            public String Description { get; set; } 
            public Decimal Price { get; set; }
            public Int32 Quantity { get; set; }
        }
        ```
    1. Refactor everything to use IProduct instead of Product.
         1. Keep in mind you can NOT deserialize an interface, so you'll need to use the concrete class and then convert it.
            ```
            var products = JsonSerializer.Deserialize<Dictionary<Int32, Product>>(contents);
            if (products == null) return empty;
            Dictionary<Int32, IProduct> iProducts = products.ToDictionary(kvp => kvp.Key, kvp => kvp.Value as IProduct);
            return iProducts ?? empty;
            ```
         1. Test it.
1. Now lets fix the foundation of ILocalStorage and Storage Classes ... later these will be refactored into SQL.
    1. Create an ILocalStorage Interface and LocalStorage Class in the Data directory, and Implement the LocalStorage Class by moving the storage functionality from Inventory.razor to LocalStorage.
        1. LocalStorage "restriction that a setting name length may be 255 characters at the most. Each setting can be up to 8K bytes in size, and each composite setting can be up to 64 K bytes in size."
        1. We should probably just go ahead and use file storage instead.  
        1. Keep in mind you can NOT deserialize an interface, so you'll need to use the concrete class in the dictionary and then convert it as needed.
            ```
            public class LocalStorage : ILocalStorage
            {
                public async Task<Boolean> ClearStorage()
                {
                    var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
                    File.Delete(path);
                    return !File.Exists(path);
                }

                public async Task<Boolean> SaveProducts(Dictionary<Int32, IProduct> products)
                {
                    var contents = JsonSerializer.Serialize(products);
                    String? results;
                    var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
                    await File.WriteAllTextAsync(path, contents);
                    results = await File.ReadAllTextAsync(path);
                    return results == contents;
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
                    Dictionary<Int32, IProduct> iProducts = products.ToDictionary(kvp => kvp.Key, kvp => kvp.Value as IProduct);
                    return iProducts ?? empty;
                }
            }
            ```
        1. Make sure everything compiles ... it'll be a bit hard to test now, but at least make sure it compiles.  If you are ambitious, this might be a good time to write a test project to test the foundation storage classes. 
        1. Once you have LocalStorage and ILocalStorage implemented, lets wire those into the front end for testing with the GUI.  Note: You may want to disable the auto-load feature in OninitializedAsync() for now until you have the storage classes working correctly and throughly tested.
            1. **Clear Storage** - delete storage so we can start fresh and/or recover from errors.
            1. **Add Product** - add a product to storage.
            1. **Save Products** - save the products to storage.
            1. **Load Products** - load the products from storage.  
                1. If the database is empty, load the `TestIProducts.GetTestProducts()` instead.  You can just grab that from the respository to save time.
            1. **Delete Products** - delete selected products from storage.
            1. Update is just save after we modify something on the page
        1. We'll need to add initialization code to the Inventory Component to load the required classes. `LocalStorage _localStorage = new LocalStorage();`
        1. The Inventory Component is just a view or subset of the greater problem.  So we need to keep track of the veiw locally in the component, then send the changes as needed to the logic or storage class.  Start thinking modularly and separately in terms of the larger problem.
        1. As an example Add Product locally to the view, then Save to send the changes to the storage class. Right now we're Ommiting the Logic Class.  But Later once we add the Logic Class this will be:
            ```
            private void AddProduct()
            {
                var Id = _products.Count > 0 ?  _products.Keys.Max() + 1 : 1;
                newProduct.Id = Id;
                _products.Add(Id, newProduct);
                var results = _products.TryGetValue(Id, out IProduct product);
                newProduct = new Product();
            }

            private async Task SaveProducts()
            {
                var results = await _localStorage.SaveProducts(_products);
            }
            ```
        1. Now implement and test the rest of the initial methods: ClearStorage, AddProduct, SaveProducts, LoadProducts, DeleteProducts.
        1. Once that's running and tested, make sure the OnInitializedAsync() is working correctly and loading the products from storage correctly as well.
        1. Then double check that you removed all storage code from the Inventory Component and are using the LocalStorage Class instead.  If there is any old code left that accessed storage directly, it should be removed, as it will cause problems later.
</details>

### Part 4
<details>

1. Implement ProductLogic and IProductLogic Classes in the Logic directory
    1. Notes
        1. This should be very similar to the Product Logic class you already made for the petshop.  But it should be refactored to use IProduct instead of Product, and we'll want to use the LocalStorage class as well for permanent storage. The ProductLogic Class should be the only class that has access to the LocalStorage Class.  The Inventory Component should only have access to the ProductLogic Class.
       1. Assume we want to always keep everything saved and synced with the Storage Class, as opposed to caching.  
       1. Assume the storage class has thousands of records, while the logic class works on hundreds, and the visual gui only displays 10s.
    1. Lets start with the IProductLogic Interface.  Note: An Async Method is a Task.
        ```
            ...  Insert Interface Here
        ```
    2. Then start the ProductLogic Class and set contructors for the storage class
        ```
        public class ProductLogic : IProductLogic
        {
            private ILocalStorage _localStorage;

            public ProductLogic()
            {
                _localStorage = new LocalStorage();
            } 
        ```
    1. Add the GetAllProducts so we can test an initial LoadProducts().
        ```
        public async Task<Dictionary<Int32, IProduct>> GetAllProducts()
        {
            _products = await _localStorage.LoadProducts();
            return _products;
        }
        ```
    1. Notes: 
        1. Trying to async load the products in the synchronous constructor does not go well. 
        1. Contruct it, and then call GetAllProducts() to load the products before using the class, knowing that if we use it first, things won't go well.
        1. Logically this is what we were doing before anyway, so lets just do this again.
    
     1. Add GetAllProducts to the Inventory Component Initialization.   Follow OnInitializedAsync() which in turn calls LoadProducts(), modify the LoadProducts(), and test it.
        1. This is just updating one line of code.
        ```
        private async Task LoadProducts()
        {
            Debug.WriteLine("Attempting to Load Local Storage");
            _products = await _productLogic.GetAllProducts();       // <--- **** Here ****
            Debug.WriteLine($"LoadProducts: {_products.Count}");
            if (_products == null || _products.Count <= 0)
            {
                _products = TestIProducts.GetTestProducts();
                Debug.WriteLine($"GetTestProducts: {_products.Count}");
            }
        }
        ```
        1. Loading should have worked, even if everything else is in a bit of flux.
     1. Now lets finish up the Primary Functions:   ClearStorage(), AddProduct(), SaveProducts(), DeleteProducts(), ... 
        1. ClearStorage() is pretty straigt forward
            ```
            private async Task ClearStorage()
            {
                Debug.WriteLine("Attempting to Clear LocalStorage");
                _products.Clear();
                var results = await _productLogic.ClearStorage();
                Debug.WriteLine($"Results: {results}");
            }
            ```
            ```
            public async Task<Boolean> ClearStorage()
            {
                return await _localStorage.ClearStorage();
            }
            ```
            ```
            public async Task<Boolean> ClearStorage()
            {
                var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
                File.Delete(path);
                return !File.Exists(path);
            }
            ```
        1. AddProduct() however, is a bit trickier.  If we don't always load all products, we don't have any way to know what the key Id should be.  So we either have to load everything ... or let ProductLogic deal with it.  Time to pass the buck.
            1. Update Inventory for passing the buck to ProductLogic
                ```
                private void AddProduct()
                {        
                    var newId = _productLogic.AddProduct(newProduct);
                    if (newId > 0)
                    {
                        _products.Add(newId, newProduct);
                        newProduct = new Product();
                    }
                }
                ```
            1. Then we have the same problem in ProductLogic, We don't know what the key should be.  (There's a reason we use databases later.)
                ```
                public async Task<Int32> AddProduct(IProduct product)
                {
                    var result = await _localStorage.AddProduct(product);
                    return result;
                }
                ```
            1. Now we need to append an AddProduct to ILocalStorage and LocalStorage
                1. This is ugly, but that's what happens when you don't have a database.
                ```
                public async Task<Int32> AddProduct(IProduct product)
                {
                    var products = await LoadProducts();
                    var id = products.Count > 0 ? products.Keys.Max() + 1 : 1;
                    product.Id = id;
                    products.Add(id, product);
                    var result = await SaveProducts(products);
                    return result ? id : 0;
                }
                ```
            1. Test it.
         1. SaveProducts() aka: AddUpdateProducts() 
            1. this will be AddUpdateProducts.  Whatever we pass it will either be added or updated. I'm assuming a long list and that we really don't want to do a series of expensive read/write of the whole file.  This is again something that needs to be handled at the Storage level.  So we'll have to pass it along.
                ```
                private async Task SaveProducts()
                {
                    Debug.WriteLine("Attempting to Save Local Storage");
                    var results = await _productLogic.AddUpdateProducts(_products);
                    Debug.WriteLine($"SaveProducts: {results}");
                }
                ```
                ```
                public async Task<Int32> AddUpdateProducts(Dictionary<Int32, IProduct> products)
                {
                    var result = await _localStorage.AddUpdateProducts(products);
                    return result;
                }
                ```
                ```
                public async Task<Int32> AddUpdateProducts(Dictionary<Int32, IProduct> moreProducts)
                {
                    var products = await LoadProducts();
                    foreach (var kvp in moreProducts)
                        if (products.ContainsKey(kvp.Key)) products[kvp.Key] = kvp.Value;
                        else products.Add(kvp.Key, kvp.Value);
                    var result = await SaveProducts(products);
                    return result;
                }
                ```
         1. DeleteProducts()
            1. remember we want everything to stay updated and synced when we press the various buttons like delete.  Before we were just deleting them from the GUI and calling it good.  Now we have to propogate that to ProductLogic and Storage.
                ```
                private async Task DeleteProducts()
                {
                    Debug.WriteLine("Attempting to Delete Products");
                    var keysToDelete = _products.Where(p => p.Value.isSelected).Select(p => p.Key).ToList();
                    keysToDelete.ForEach(key => _products.Remove(key));
                    var results = await _productLogic.DeleteProducts(keysToDelete);
                    Debug.WriteLine($"DeleteProducts: {results}");
                }
                ```
                ```
                public async Task<Int32> DeleteProducts(List<Int32> keysToDelete)
                {
                    var results = await _localStorage.DeleteProducts(keysToDelete);
                    return results;
                }
                ```
                ```
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
                ```
        1. Lots of Testing ... and then some more testing.
    1. Now lets wire in the three logic functions: GetInStockProducts(), GetOutOfStockProducts(), GetTotalValueOfStock();
        1. This should be fairly easy, it's just pure logic going into the place logic belongs.  No more refactoring thank goodness.
        ```
        private async Task ShowInStock()
        {
            Debug.WriteLine("Attempting to Show In-Stock");
            _products = await _productLogic.GetInStockProducts();
            Debug.WriteLine($"ShowInStock: {_products.Count}");
        }

        private async Task ShowOutOfStock()
        {
            Debug.WriteLine("Attempting to Show Out-of-Stock");
            _products = await _productLogic.GetOutOfStockProducts();
            Debug.WriteLine($"ShowOutOfStock: {_products.Count}");
        }

        private async Task InventoryValue()
        {
            Debug.WriteLine("Attempting to Calculate Inventory Value");
            var results = await _productLogic.GetTotalValueOfStock();
            if (App.Current?.MainPage != null ) await App.Current.MainPage.DisplayAlert("Inventory Value", $"Total Value of Stock: {results:C}", "OK");
            Debug.WriteLine($"InventoryValue: {results}");
        }
        ```
        ```
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
        ```
    1. Now lets clean up those names and make them more relevant to all the new changes.  Maybe reorder them too.
    1. Then it looks like we need to clear the selectd bit when we load and press the various buttons. 
        ```
        private void ClearSelection ()
        {
            _products.Keys.ToList().ForEach(key => _products[key].isSelected = false);
        }
        ```
	1.  More Testing
    1.  And Done with Part 4.   I'm out of time, so we'll add Get by ID next time.
    ![Screenshot02](https://github.com/cjmet/CodeKy-SDM24-MBH/blob/main/SDM24MBH/Files/Screenshot02.png?raw=true)     

</details>

### Part 5
<details>

- Implemented Entity Framework Core (Single Table) and SQLite 
- I think I have lost the battle of documentation at this point.
- I'm going to have to finish the project, then backtrack and redo it in as simplified a form as possible and document that.
- Documenting it and figuring out how much to document is a real challenge.
- The Documentation alone, if given enough detail, could take a day for each hour of coding.  I'm struggling finding the right balance here.

</details>

### Part 6
- Implement MudBlazor

### Part 7 
To Be Continued ... 

 



&nbsp;
## Project Blog:
---

#### 2024/10/2
- More MudBlazor and Learning as much as possible.

#### 2024/10/1 
- MudBlazor

### 2024/09/30
- EF Core 

#### 2024/09/27
- This is much harder than it appears, trying to explain do it, explain it, and document it.  Trying to figure out what needs to be said when.
- Almost done with Part 4.   Part 4 because I decided to split Part 3 into two parts.

#### 2024/09/26
- In the middle of Part 3

#### 2024/09/25
- Began work on Part 2 
- I may start on Part 3 next ... but that may wait as well.

#### 2024/09/24

- Began work on Part 1.b ...
- @expression(), @code, @functions, ...
- @bind, @onchange, @onclick, @onsubmit, ...
- Razor component file names require a capitalized first letter.
- Dang, that's already CRUD, of a rough sort.

#### 2024/09/23

- Created the project and added the README.md file.
