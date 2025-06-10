using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace LoanApplicationSiteCore.Tests.Configs
{
    // Load config
    public static class ConfigLoader
    {
        public static PlaywrightSettings? GetPlaywrightSettings()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var settings = config.GetSection("Playwright").Get<PlaywrightSettings>();

            return settings;
        }
    }
}
