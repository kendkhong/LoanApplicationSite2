using Microsoft.Playwright;
using FluentAssertions;
using System.Threading.Tasks;
using LoanApplicationSiteCore.Tests.Hooks;

namespace LoanApplicationSiteCore.Tests.Pages
{
    // This represents a Page Object Model class
    public class LoanApplicationPage
    {
        private readonly IPage user;

        // Using support Selenium nuget packages to create Declarative Page Object Model
        private ILocator errorText => user.Locator("css=div.validation-summary-errors ul li");
        private ILocator FirstNameInput => user.Locator("input[id='FirstName']");
        private ILocator SecondNameInput => user.Locator("input[id='LastName']");
        private ILocator ExistingLoan => user.Locator("xpath=//html/body/div[2]/form/fieldset/div[3]/div[2]/input");
        private ILocator TermsAcceptance => user.Locator("input[id='TermsAcceptance']");
        private ILocator SubmitButton => user.Locator(".btn.btn-primary");

        public LoanApplicationPage(Hooks.Hooks hooks)
        {
            this.user = hooks.User;
        }

        public async Task AssertPageContent()
        {
            // Assert that the correct URL has been reached
            user.Url.Should().Be("https://localhost:7115/Home/StartLoanApplication");

            // Assert that the submit application button is visible
            var submitBtnVisibility = await SubmitButton.IsVisibleAsync();

        }

        public async Task FirstName(string firstname)
        {
            await FirstNameInput.FillAsync(firstname);
        }

        public async Task SecondName(string lastname)
        {
            await SecondNameInput.FillAsync(lastname);
        }

        public ILocator ErrorText => errorText;

        public async Task SelectExistingLoan()
        {
            await ExistingLoan.ClickAsync();
        }

        public async Task AcceptTermsAndConditions()
        {

            await TermsAcceptance.CheckAsync();
        }

        public async Task SubmitApplication()
        {
            await SubmitButton.ClickAsync();
        }

    }
}
