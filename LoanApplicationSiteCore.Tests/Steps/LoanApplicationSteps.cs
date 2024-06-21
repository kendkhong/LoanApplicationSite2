using LoanApplicationSiteCore.Tests.Pages;
using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using TechTalk.SpecFlow;




namespace LoanApplicationSiteCore.Tests.Steps
{
    [Binding]
    public class LoanApplicationSteps
    {
        private readonly IPage page;
        private readonly LoanApplicationPage loanApplicationPage;

        public LoanApplicationSteps(Hooks.Hooks hooks, LoanApplicationPage loanApplicationPage)
        {
            this.page = hooks.Page;
            this.loanApplicationPage = loanApplicationPage;
        }

        [Given(@"I am on the loan application screen")]
        public async Task GivenIAmNonTheLoanApplicationScreen()
        {
            // Go to the Loan Application screen
            await page.GotoAsync("https://localhost:7115/Home/StartLoanApplication");

            // Assert the page
            await loanApplicationPage.AssertPageContent();

        }

        [Given(@"I enter a first name of (.*)")]
        public async Task GivenIEnterAFirstNameOf(string firstName)
        {
            await loanApplicationPage.FirstName(firstName);
        }

        [Given(@"I enter a second name of (.*)")]
        public async Task GivenIEnterASecondNameOf(string lastName)
        {
            await loanApplicationPage.SecondName(lastName);
        }

        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {

            loanApplicationPage.SelectExistingLoan();
        }

        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            loanApplicationPage.AcceptTermsAndConditions();
        }

        [When(@"I submit my application")]
        public async Task WhenISubmitMyApplication()
        {
            await loanApplicationPage.SubmitApplication();
        }

        [Then(@"I should see an error message telling me I must accept the terms and conditions")]
        public async Task ThenIShouldSeeAnErrorMessageTellingMeIMustAcceptTheTermsAndConditions()
        {
            await Assertions.Expect(loanApplicationPage.ErrorText).ToContainTextAsync("You must accept the terms and conditions");
        }

    }
}
