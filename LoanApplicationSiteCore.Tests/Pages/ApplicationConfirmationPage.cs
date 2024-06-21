
using FluentAssertions;
using Microsoft.Playwright;



namespace LoanApplicationSiteCore.Tests.Pages
{
    public class ApplicationConfirmationPage
    {
        private readonly IPage page;

        private ILocator _firstName => page.Locator("xpath=/html/body/div[2]/div/p[1]/span");
        public ApplicationConfirmationPage(Hooks.Hooks hooks)
        {
            this.page = hooks.Page;
        }

        public ILocator FirstName => _firstName;
    }
}
