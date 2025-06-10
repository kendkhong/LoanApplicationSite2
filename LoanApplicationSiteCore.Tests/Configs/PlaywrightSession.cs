using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace LoanApplicationSiteCore.Tests.Configs
{
    public class PlaywrightSession
    {
        public IPlaywright Playwright { get; private set; }
        public IBrowser Browser { get; private set; }
        public IBrowserContext Context { get; private set; } 
        public IPage Page { get; private set; } // We will call this property in the tests

        public async Task StartAsync(string browserType = "chromium", bool headless = true)
        {
            // Initialize Playwright
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

            // Load Playwright setting
            var settings = ConfigLoader.GetPlaywrightSettings();
            // Initialize a browser - 'Chromium' can be changed to 'Firefox' or 'Webkit'
            Browser = browserType switch
            {
                "firefox" => await Playwright.Firefox.LaunchAsync(new() { Headless = settings?.Headless }),
                "webkit" => await Playwright.Webkit.LaunchAsync(new() { Headless = settings?.Headless }),
                _ => await Playwright.Chromium.LaunchAsync(new() { Headless = settings?.Headless }),
            };

            // Setup a browser context
            Context = await Browser.NewContextAsync();

            // Initialize a page on the browser context
            Page = await Context.NewPageAsync();

        }

        public async Task StopAsync()
        {
            if (Browser != null)
                await Browser.CloseAsync();

            Playwright?.Dispose();
        }
    }
}
