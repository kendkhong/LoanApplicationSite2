using LoanApplicationSiteCore.Tests.Support;
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

        [BeforeScenario(Order = 0)] // Notice how we're doing these steps before each scenario
        public async Task StartPlaywright()
        {
            var session = new PlaywrightSession();
            // Start the Playwright session before store session in the ScenarioContext
            await session.StartAsync(browserType: "chromium", headless: false);
            _scenarioContext["PlaywrightSession"] = session;
            Console.WriteLine("Playwright session started successfully.");
        }

        [AfterScenario(Order = 999)]
        public async Task DisposePlaywright()
        {
            if (_scenarioContext.TryGetValue("PlaywrightSession", out PlaywrightSession session))
            {
                // Clean up (dispose of the Browser, Context, and Playwright)
                await session.StopAsync();
            }
        }
    }
}
