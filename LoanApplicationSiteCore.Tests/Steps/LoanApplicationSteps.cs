using LoanApplicationSiteCore.Tests.Pages;
using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using LoanApplicationSiteCore.Tests.Configs;


namespace LoanApplicationSiteCore.Tests.Steps
{
    [Binding]
    public class LoanApplicationSteps
    {
        private PlaywrightSession _session;
        private LoanApplicationPage _loanApplicationPage;

        public LoanApplicationSteps(ScenarioContext scenarioContext, LoanApplicationPage loanApplicationPage)
        {
            this._session = scenarioContext.Get<PlaywrightSession>("PlaywrightSession");
            this._loanApplicationPage = loanApplicationPage;
        }

        [Given(@"I am on the loan application screen")]
        public async Task GivenIAmNonTheLoanApplicationScreen()
        {
            // Go to the Loan Application screen
            //await _session.Page.GotoAsync($"{settings?.BaseUrl}/Home/StartLoanApplication");
            await _loanApplicationPage.goTo();

            // Assert the page
            await _loanApplicationPage.AssertPageContent();

        }

        [Given(@"I enter a first name of (.*)")]
        public async Task GivenIEnterAFirstNameOf(string firstName)
        {
            await _loanApplicationPage.FirstName(firstName);
        }

        [Given(@"I enter a second name of (.*)")]
        public async Task GivenIEnterASecondNameOf(string lastName)
        {
            await _loanApplicationPage.SecondName(lastName);
        }

        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {

            _loanApplicationPage.SelectExistingLoan();
        }

        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            _loanApplicationPage.AcceptTermsAndConditions();
        }

        [When(@"I submit my application")]
        public async Task WhenISubmitMyApplication()
        {
            await _loanApplicationPage.SubmitApplication();
        }

        [Then(@"I should see an error message telling me I must accept the terms and conditions")]
        public async Task ThenIShouldSeeAnErrorMessageTellingMeIMustAcceptTheTermsAndConditions()
        {
            await Assertions.Expect(_loanApplicationPage.ErrorText).ToContainTextAsync("You must accept the terms and conditions");
        }

    }
}
