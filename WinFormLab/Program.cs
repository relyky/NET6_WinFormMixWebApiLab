using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WinFormLab;

internal static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    ApplicationConfiguration.Initialize();

    var services = new ServiceCollection();
    ConfigureServices(services);
    
    using (var provider = services.BuildServiceProvider())
    {
      var mainForm = provider.GetRequiredService<MainForm>();
      Application.Run(mainForm);
    }
  }

  static void ConfigureServices(ServiceCollection services)
  {
    services.AddLogging(configure => configure.AddConsole());

    //        .AddScoped<IBusinessLayer, CBusinessLayer>()
    //        .AddScoped<IBusinessLayer, CBusinessLayer>()
    //        .AddSingleton<IDataAccessLayer, CDataAccessLayer>();

    services.AddScoped<MainForm>();
    services.AddScoped<FormA01>();
    services.AddScoped<FormA02>();
    services.AddScoped<FormA03>();
  }
}