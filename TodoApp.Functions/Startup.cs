using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(TodoApp.Functions.Startup))]
namespace TodoApp.Functions
{
  public class Startup : FunctionsStartup
  {
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddLogging();
    }

    public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
    {
      base.ConfigureAppConfiguration(builder);
    }
  }
}