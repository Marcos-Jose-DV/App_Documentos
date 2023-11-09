using AppDocuments.Data;
using AppDocuments.Helpers;
using AppDocuments.ViewModels;
using AppDocuments.Views;
using LiteDB;
using Microsoft.Extensions.Logging;

namespace AppDocuments;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<UpdateComponentPage>();
        builder.Services.AddSingleton<PostCategoryPage>();
        builder.Services.AddSingleton<PostComponentPage>();
        builder.Services.AddSingleton<LiteDatabase>();
        builder.Services.AddSingleton<ConvertObject>();

        builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
        builder.Services.AddSingleton<IComponentRepositoty, ComponentRepositoty>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
    //Android
    //public static MauiAppBuilder RegisterDataBaseCategory(this MauiAppBuilder builder)
    //{
    //    builder.Services.AddSingleton<LiteDatabase>(
    //        options =>
    //        {
    //            return new LiteDatabase($"Filename={AppSettings.DatabasePath};Connection=Shared");
    //        }
    //    );
    //    builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
    //    return builder;
    //}
}
