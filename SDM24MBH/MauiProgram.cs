using Microsoft.Extensions.Logging;
using SDM24MBH.Logic;
using SDM24MBH.Data;

namespace SDM24MBH
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddTransient<IProductLogic,ProductLogic>(); // cjm 
            builder.Services.AddTransient<ILocalStorage, SQLiteStorage>(); // cjm
            builder.Services.AddDbContext<SQLiteContext>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
