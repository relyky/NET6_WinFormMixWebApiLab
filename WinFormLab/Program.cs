using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Serilog;
using Refit;
using WinFormLab.Models;

namespace WinFormLab;

internal static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main(string[] args)
  {
    Log.Logger = new LoggerConfiguration()
      .MinimumLevel.Debug()
      .WriteTo.File("D:/Log/myapp.txt", rollingInterval: RollingInterval.Day)
      .CreateLogger();

    try
    {
      Log.Information($"Host init.");

      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();

      var builder = Host.CreateDefaultBuilder(args);

      builder.ConfigureServices((ctx, services) =>
      {
        var config = ctx.Configuration;

        //## for Authentication & Authorization
        services.AddAuthorizationCore();
        services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(config["WebApi1Url"]!) });
        services.AddTransient<AuthHeaderHandler>();
        services.AddSingleton<DeliveryQueue>();

        //## 註冊 RefitClient API。 --- 手動一個一個註冊
        services.AddRefitClient<WinFormLab.RefitClient.IIdentityApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri(config["WebApi1Url"]!))
          .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<WinFormLab.RefitClient.IWeatherForecastApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri(config["WebApi1Url"]!))
          .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<WinFormLab.RefitClient.IFileHandleApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri(config["WebApi1Url"]!))
          .AddHttpMessageHandler<AuthHeaderHandler>(); ;

        //# WebApi2
        services.AddRefitClient<WinFormLab.RefitClient.IValuesApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri("https://localhost:7138/"))
          .AddHttpMessageHandler<AuthHeaderHandler>();

        //# DemoSysAPI
        services.AddRefitClient<DemoSysUI.RefitClient.IMyValueApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri("https://localhost:7014/"))
          .AddHttpMessageHandler<AuthHeaderHandler>();

        // 註冊應用表單
        services.AddScoped<MainForm>();
        services.AddTransient<LoginDialog>();
        services.AddTransient<FormA01>();
        services.AddTransient<FormA02>();
        services.AddTransient<FormA03>();
        services.AddTransient<FormA04>();
        services.AddTransient<FormA05>();
        services.AddTransient<FormA06>();
        services.AddTransient<FormA07>();
        services.AddTransient<DemoSysUI.DeomForm01>();
      });

      builder.UseSerilog();

      var host = builder.Build();
      //-----------------------------------------------------------------------
      Log.Information($"Host start.");

      using (var scope = host.Services.CreateScope())
      {
        var provider = scope.ServiceProvider;
        var mainForm = provider.GetRequiredService<MainForm>();
        Application.Run(mainForm);
      }

      Log.Information($"Host exit.");
    }
    catch (Exception ex)
    {
      Log.Fatal(ex, $"Host terminated unexpectedly.");
    }
    finally
    {
      Log.CloseAndFlush();
    }
  }
}