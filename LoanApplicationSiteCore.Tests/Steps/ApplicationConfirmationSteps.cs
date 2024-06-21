using LoanApplicationSiteCore.Tests.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace LoanApplicationSiteCore.Tests.Steps
{
    [Binding]
    public class ApplicationConfirmationSteps
    {
        private readonly IPage page;
        private readonly ApplicationConfirmationPage applicationConfirmationPage;

        public ApplicationConfirmationSteps(Hooks.Hooks hooks, ApplicationConfirmationPage applicationConfirmationPage) {

            this.page = hooks.Page; 
            this.applicationConfirmationPage = applicationConfirmationPage;
        }

        [Then(@"I should see the application complete confirmation for Sarah")]
        public async Task ThenIShouldSeeTheApplicationCompleteConfirmationForSarah()
        {
            await Assertions.Expect(applicationConfirmationPage.FirstName).ToContainTextAsync("Sarah");
        }
    }
}
