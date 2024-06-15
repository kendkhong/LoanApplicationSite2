
using FluentAssertions;
using Microsoft.Playwright;



namespace LoanApplicationSiteCore.Tests.Pages
{
    public class ApplicationConfirmationPage
    {
        private readonly IPage user;

        private ILocator _firstName => user.Locator("xpath=/html/body/div[2]/div/p[1]/span");
        public ApplicationConfirmationPage(Hooks.Hooks hooks)
        {
            this.user = hooks.User;
        }

        public ILocator FirstName => _firstName;
    }
}
