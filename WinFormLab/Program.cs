using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Refit;

namespace WinFormLab;

internal static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
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

      var builder = new HostBuilder();
      builder.UseSerilog();
      builder.ConfigureServices((ctx, services) =>
      {
        //## 註冊 RefitClient API。 --- 手動一個一個註冊
        services.AddRefitClient<WinFormLab.RefitClient.IWeatherForecastApi>()
          .ConfigureHttpClient(http => http.BaseAddress = new Uri("https://localhost:7232/"));

        // 註冊應用表單
        services.AddScoped<MainForm>();
        services.AddScoped<FormA01>();
        services.AddScoped<FormA02>();
        services.AddScoped<FormA03>();
      });

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