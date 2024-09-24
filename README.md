<h1 style="margin: 0">CodeKy-SDM24-MBH</h1>

<font size="4">A MAUI Blazor Hybrid Demo Project as a multi-platform alternative to ASP .NET with MVC</font>

The MAUI Blazor Hybrid framework uses the more mature Blazor front end combined the MAUI multi-platform back end to deliver a full multi-platform package.

- It should be expected that this project will take 2x the time to develop as the standard ASP .NET MVC project, but will be able to target multiple platforms.
- This is a time-budgeted project. I'm trying get a feel for how viable this alternative may be for students and what kind of time investment this should be expected to take for students. I'm also fairly limited in the time I have to devote to this project. It is entirely possible that it will fail to be completed with-in the given time-budget.
- This is a demo project, so many more complicated topics and features, such as security and authentication, will be left out, simplified, or glossed over.
- This project will only be targeting windows and android, but the same project should be able to target iOS and Mac as well.
- Some minimal effort will be made to restrict the project to libraries and features that are compatible with all platforms. Although some platform specific features may be included, such as the use of the android emulator.

&nbsp;

## Development Hardware Requirements

- **8 physical hardware cores with 12+ gigabytes of memory is strongly recommended.**
- Physical hardware SSD with a direct local path, with no spaces in the path names.
  - Ex: c:\users\username\local\Solution47\Project23

### &emsp; Hardware Details

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

&nbsp;

## Important Notes

- Do not modify the .csproj targets, as this can have unintended consequences. As an example, by default the project should restrict the use of incompatible libraries.
- Do not use underlines, spaces, or other special characters in the project name. Hyphens are allowed but discouraged.
- ...

&nbsp;

## Project Plan

1. [Microsoft: Build a .NET MAUI Blazor Hybrid app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-8.0)
1. <sup style="color: gold; font-weight: bold"> &#9733; </sup> [Microsoft: Build a mobile and desktop app with Blazor Hybrid and .NET MAUI](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/)
1. [Microsoft: Build a .NET MAUI Blazor Hybrid app with a Blazor Web App](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui-blazor-web-app?view=aspnetcore-8.0)
1. [YouTube: Let's build REST API Client Desktop App using .Net MAUI Blazor Hybrid for Windows and Mac OS Desktop](https://www.youtube.com/watch?app=desktop&v=HKMhgOAZLWw)
1. [FreeCodeCamp: Learn Blazor WebAssembly and Web API on .NET 6 by Building a Shopping Cart App](https://www.freecodecamp.org/news/learn-blazor-webassembly-and-web-api-on-net-6-by-building-a-shopping-cart-app/)
1. ...

## Project Notes

- ...

## Project Blog:

### 2024/09/24

- Started on Part 2 ...

### 2024/09/23

- Created the project and added the README.md file.
