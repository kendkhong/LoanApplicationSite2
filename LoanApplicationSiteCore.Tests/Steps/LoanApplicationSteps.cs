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
        private readonly LoanApplicationPage _loanApplicationPage;
        private readonly POManager _poManager;

        public LoanApplicationSteps(ScenarioContext scenarioContext)
        {
            this._poManager = new POManager(scenarioContext);
            this._loanApplicationPage = _poManager.LoanApplicationPage;

        }

        [Given(@"I am on the loan application screen")]
        public async Task GivenIAmNonTheLoanApplicationScreen()
        {
            // Go to the Loan Application screen
            await this._loanApplicationPage.GoTo();

            // Assert the page
            await this._loanApplicationPage.AssertPageContent();

        }

        [Given(@"I enter a first name of (.*)")]
        public async Task GivenIEnterAFirstNameOf(string firstName)
        {
            await this._loanApplicationPage.FirstName(firstName);
        }

        [Given(@"I enter a second name of (.*)")]
        public async Task GivenIEnterASecondNameOf(string lastName)
        {
            await this._loanApplicationPage.SecondName(lastName);
        }

        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {

            this._loanApplicationPage.SelectExistingLoan();
        }

        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            this._loanApplicationPage.AcceptTermsAndConditions();
        }

        [When(@"I submit my application")]
        public async Task WhenISubmitMyApplication()
        {
            await this._loanApplicationPage.SubmitApplication();
        }

        [Then(@"I should see an error message telling me I must accept the terms and conditions")]
        public async Task ThenIShouldSeeAnErrorMessageTellingMeIMustAcceptTheTermsAndConditions()
        {
            await Assertions.Expect(this._loanApplicationPage.ErrorText).ToContainTextAsync("You must accept the terms and conditions");
        }

    }
}
