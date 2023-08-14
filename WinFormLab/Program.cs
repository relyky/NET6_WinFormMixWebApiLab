using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Refit;
using Microsoft.Extensions.Configuration;

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
        
        //## 註冊 RefitClient API。 --- 手動一個一個註冊
        services.AddRefitClient<WinFormLab.RefitClient.IWeatherForecastApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri(config["WebApi1Url"]!));

        services.AddRefitClient<WinFormLab.RefitClient.IFileHandleApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri(config["WebApi1Url"]!));

        // 註冊應用表單
        services.AddScoped<MainForm>();
        services.AddTransient<FormA01>();
        services.AddTransient<FormA02>();
        services.AddTransient<FormA03>();
        services.AddTransient<FormA04>();
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