using LoanApplicationSiteCore.Tests.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace LoanApplicationSiteCore.Tests.Steps
{
    [Binding]
    public class ApplicationConfirmationSteps
    {
        private readonly ApplicationConfirmationPage _applicationConfirmationPage;
        private readonly POManager _poManager;

        public ApplicationConfirmationSteps(ScenarioContext scenarioContext) {

            this._poManager = new POManager(scenarioContext);
            this._applicationConfirmationPage = _poManager.ApplicationConfirmationPage;
        }

        [Then(@"I should see the application complete confirmation for Sarah")]
        public async Task ThenIShouldSeeTheApplicationCompleteConfirmationForSarah()
        {
            await Assertions.Expect(_applicationConfirmationPage.FirstName).ToContainTextAsync("Sarah");
        }
    }
}
