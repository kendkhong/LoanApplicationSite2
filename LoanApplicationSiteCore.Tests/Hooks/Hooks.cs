using Microsoft.Playwright;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoanApplicationSiteCore.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        public IPage Page { get; private set; } = null; // We will call this property in the tests
        public IBrowser browser;

        [BeforeScenario] // Notice how we're doing these steps before each scenario
        public async Task RegisterSingleInstancePractitioner()
        {
            // Initialize Playwright 
            var playwright = await Playwright.CreateAsync();

            // Initialize a browser - 'Chromium' can be changed to 'Firefox' or 'Webkit'
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions {
                    
                    Headless = false // Use this option to be able to see test running
                }
            );

            // Setup a browser context
            var context1 = await browser.NewContextAsync();

            // Initialize a page on the browser context
            Page = await context1.NewPageAsync();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            browser.DisposeAsync();
        }

    }
}
