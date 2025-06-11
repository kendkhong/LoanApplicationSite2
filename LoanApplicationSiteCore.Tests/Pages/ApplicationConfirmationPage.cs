
using FluentAssertions;
using LoanApplicationSiteCore.Tests.Support;
using Microsoft.Playwright;
using TechTalk.SpecFlow;


namespace LoanApplicationSiteCore.Tests.Pages
{
    public class ApplicationConfirmationPage
    {
        private readonly IPage page;

        private ILocator _firstName => page.Locator("xpath=/html/body/div[2]/div/p[1]/span");
        public ApplicationConfirmationPage(ScenarioContext senarioContext)
        {
            var session = senarioContext.Get<PlaywrightSession>("PlaywrightSession");
            this.page = session.Page;
        }

        public ILocator FirstName => _firstName;
    }
}
