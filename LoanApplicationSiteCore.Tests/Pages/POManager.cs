using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoanApplicationSiteCore.Tests.Pages
{
    public class POManager
    {
        private readonly ScenarioContext _scenarioContext;
        public POManager(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        public LoanApplicationPage LoanApplicationPage
        {
            get
            {
                if (!_scenarioContext.TryGetValue("LoanApplicationPage", out LoanApplicationPage loanApplicationPage))
                {
                    loanApplicationPage = new LoanApplicationPage(_scenarioContext);
                    _scenarioContext["LoanApplicationPage"] = loanApplicationPage;
                }
                return loanApplicationPage;
            }
        }
        // Add other page objects as needed
        public ApplicationConfirmationPage ApplicationConfirmationPage
        {
            get
            {
                if (!_scenarioContext.TryGetValue("ApplicationConfirmationPage", out ApplicationConfirmationPage applicationConfirmationPage))
                {
                    applicationConfirmationPage = new ApplicationConfirmationPage(_scenarioContext);
                    _scenarioContext["ApplicationConfirmationPage"] = applicationConfirmationPage;
                }
                return applicationConfirmationPage;
            }
        }
    }
}
