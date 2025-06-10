using LoanApplicationSiteCore.Tests.Configs;
using Microsoft.Playwright;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoanApplicationSiteCore.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario] // Notice how we're doing these steps before each scenario
        public async Task BeforeScenario()
        {
            var session = new PlaywrightSession();
            await session.StartAsync(browserType: "chromium", headless: false);
            _scenarioContext["PlaywrightSession"] = session;
            Console.WriteLine("Playwright session started successfully.");
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            if (_scenarioContext.TryGetValue("PlaywrightSession", out PlaywrightSession session))
            {
                // Clean up (dispose of the browser, context, and Playwright)
                await session.StopAsync();
            }
        }

    }
}
