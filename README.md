<h1 style="margin: 0">CodeKy-SDM24-MBH</h1>

<font size="4">A MAUI Blazor Hybrid Demo Project as a multi-platform alternative to ASP .NET with MVC</font>

The MAUI Blazor Hybrid framework uses the more mature Blazor front end combined the MAUI multi-platform back end to deliver a full multi-platform package.

- It should be expected that this project will take **<u>2x the time to develop</u>** as the standard ASP .NET MVC project, but will be able to target multiple platforms.
- This is a time-budgeted project. I'm trying get a feel for how viable this alternative may be for students and what kind of time investment this should be expected to take for students. I'm also fairly limited in the time I have to devote to this project. It is entirely possible that it will fail to be completed with-in the given time-budget.
- This is a demo project, so many more complicated topics and features, such as security and authentication, will be left out, simplified, or glossed over.
- The (web) front-end will be severly simplified for demonstration purposes. Little to no effort will be made to conform to modern web design standards.  We're just trying to get up a quick fast and functional bare bones Maui Blazor Hybrid project.
- This project will only be targeting windows and android, but the same project should be able to target iOS and Mac as well.
- Some effort will be made to restrict the project to libraries and features that are compatible with all platforms. Although some platform specific features may be included, such as the use of the android emulator.

&nbsp;
## Table of Contents

- [Development Hardware Requirements](#development-hardware-requirements)
  - [Hardware Details](#hardware-details)
  - [Personal VM Note](#personal-vm-note)
- [Important Notes](#important-notes)
- [Additional References](#additional-references)
- [Project Plan](#project-plan)
  - [Part 1](#part-1)
  - [Part 2](#part-2)
- [Project Blog](#project-blog)

&nbsp;
## Development Hardware Requirements

- **8 physical hardware cores with 12+ gigabytes of memory is strongly recommended.**
- Physical hardware SSD with a direct local path, with no spaces in the path names.
  - Ex: c:\users\username\local\Solution47\Project23

### &ensp;Hardware Details

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

&nbsp;

## Important Notes

- Do not modify the .csproj targets, as this can have unintended consequences. As an example, by default the project should restrict the use of incompatible libraries.
- Do not use underlines, spaces, or other special characters in the project name. Hyphens are allowed but discouraged.
- ...

### &ensp;Additional References

- [Maui Blazor Platform Features](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/8-platform-features)
  - [Android Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/android/platform-specifics/)
  - [iOS Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/ios/platform-specifics/)
  - [Windows Platform Specifics](https://learn.microsoft.com/en-us/dotnet/maui/windows/platform-specifics/)
  - [Invoke Native Platform Code](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/invoke-platform-code/)
- [Project Structure for Blazor Apps](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure)
- [Preferences]
- [Local Storage](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/secure-storage?view=net-maui-8.0&tabs=windows)

&nbsp;

## Project Plan

---

### Part 1

1. Initial Setup and Tutorial
   1. [Microsoft: Build a .NET MAUI Blazor Hybrid app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-8.0)
      1. Make sure to test the default app on both Android and Windows.
   1. [Microsoft: Build a mobile and desktop app with Blazor Hybrid and .NET MAUI](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/)
   1. Add a "Delete Completed Items Button"
      1. `<button @onclick="()=>todos.RemoveAll(todo => todo.IsDone)">Delete Done (Inline)</button>`
   1. Don't forget to test on Android in addition to Windows

---

### Part 2

1. Apply what we've learned so far to a simplified version of the Pet Shop Project
    1. Keep it Simple and Functional First. We'll add Features Later.
    1. Add a modified Product Class from the Petshop to the Data Folder.
        1. Be aware of name spaces.
        1. Lets keep it simple and only one basic class, no methods, nor interfaces yet.
        1. We can add a Dictionary for Specification that vary by product.
        1. Add an unique Id field.  We'll use this to identify items in a dictionary.
        1. Add an isSelected field.  We'll use this to identify items selected for actions like Add, Delete, Update, Purchase, etc.

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
                    @* Snipped for Brevity *@
            ```
            1. Another non-standard way to do this would be a span, but it throws a warning:
            ```
            <span>Too many products</span> 
            ```
        1. Model it after the ToDo page. 
        1. Ignore the Specifications for now, that can be added later. 
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
                // Snipped for Brevity
            ```         
        1. Test that and make sure everything is working and wired up correctly.
        
     1. You should probably check that the dictionary keys match the product ids.
        1. Something like `<label>@(product.Key != product.Value.Id ? $"KeyError[{product.Key}]" : product.Key)</label>`
        1. Then create one product that purposely has a mismatched key and id to test it.
     1. Now lets start wiring up those buttons.
        1. Start with the Add Buttton, this should be just like what you did in the tutorials.
            1. make sure to use an unique Id for each product. Ex: `var Id = _products.Keys.Max() + 1;`
            1. Don't forget to set the product.ID field as well as the Dictionay.Key.
            1. After You've added the product, clear the input fields.  
                1. The easiest way to do this is to just new up a product in the bound input variable.
                1. `newProduct = new Product();`
            1. Test it.
        1. Then move on to the other buttons, testing each one as you go.
        1. It might be nice to sort the list by ID?  Try that.
        1. Test It.
        1. We should really load the products from file by default.  
            1. [Microsoft: Blazor Component lifecycle](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components#component-lifecycle)
            1. lets try: OnAfterRenderAsync(), ... 
            1. Ok, that didn't work.  Lets try OnInitializedAsync()...
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
     1. Now lets add some organizational Hierarchy
        1. Department, Category, SubCategory, Section, Subsection, Brand
        1. Put that into our Inventory Component page, maybe using two lines with the Hirarchy on the first line and the products on the second.
        1. Avoiding getting into tables, grids, and such, just put a few tabs in front of the second line to help with spacing. 
        1. `<label>&emsp; &emsp; &emsp;</label>`
        1. Update the test products to include the new fields.
        1. Oops. Now we need a way to NOT load the old products. 
            1. How about we check to see if the list size is 0, then not load the (empty) products list?
        1. <span style="color: gold;"> &#9733; </span> Don't forget to Test it on Android.

---

### Part 3

1. ...

1. 1. Project Structure, more Blazor details, and examples.
   1. [Project Structure for Blazor Apps](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure)
   1. [Build a Blazor Movie Database](https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/?view=aspnetcore-8.0)
   1. [Microsoft: Build a .NET MAUI Blazor Hybrid app with a Blazor Web App](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui-blazor-web-app?view=aspnetcore-8.0)

1. ...

1. [YouTube: Let's build REST API Client Desktop App using .Net MAUI Blazor Hybrid for Windows and Mac OS Desktop](https://www.youtube.com/watch?app=desktop&v=HKMhgOAZLWw)

1. [FreeCodeCamp: Learn Blazor WebAssembly and Web API on .NET 6 by Building a Shopping Cart App](https://www.freecodecamp.org/news/learn-blazor-webassembly-and-web-api-on-net-6-by-building-a-shopping-cart-app/)
1. ...

&nbsp;

### Project Blog:

#### 2024/09/24

- Started on Part 1.b ...
- @expression(), @code, @functions, ...
- @bind, @onchange, @onclick, @onsubmit, ...
- Razor component file names require a capitalized first letter.
- Dang, that's already CRUD, of a rough sort.

#### 2024/09/23

- Created the project and added the README.md file.
