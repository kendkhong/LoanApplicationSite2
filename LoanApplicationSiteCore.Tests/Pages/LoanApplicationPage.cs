using Microsoft.Playwright;
using FluentAssertions;
using TechTalk.SpecFlow;
using LoanApplicationSiteCore.Tests.Configs;

namespace LoanApplicationSiteCore.Tests.Pages
{
    // This represents a Page Object Model class
    public class LoanApplicationPage
    {
        private readonly IPage page;

        // Using support Selenium nuget packages to create Declarative Page Object Model
        private ILocator errorText => page.Locator("css=div.validation-summary-errors ul li");
        private ILocator FirstNameInput => page.Locator("input[id='FirstName']");
        private ILocator SecondNameInput => page.Locator("input[id='LastName']");
        private ILocator ExistingLoan => page.Locator("xpath=//html/body/div[2]/form/fieldset/div[3]/div[2]/input");
        private ILocator TermsAcceptance => page.Locator("input[id='TermsAcceptance']");
        private ILocator SubmitButton => page.Locator(".btn.btn-primary");

        public LoanApplicationPage(ScenarioContext scenarioContext)
        {

            var session = scenarioContext.Get<PlaywrightSession>("PlaywrightSession");
            this.page = session.Page;
        }

        public async Task goTo()
        {
            // Expose BaseUrl from the configuration file
            var settings = ConfigLoader.GetPlaywrightSettings();
            Console.WriteLine(settings?.BaseUrl);
            await this.page.GotoAsync($"{settings?.BaseUrl}/Home/StartLoanApplication");
        } 
        public async Task AssertPageContent()
        {
            // Expose BaseUrl from the configuration file
            var settings = ConfigLoader.GetPlaywrightSettings();
            // Assert that the correct URL has been reached
            page.Url.Should().Be($"{settings?.BaseUrl}/Home/StartLoanApplication");

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
