using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplicationSiteCore.Tests.Configs
{
    // Create a configuration class
    public class PlaywrightSettings
    {
        public string Browser { get; set; } = "firefox";
        public bool Headless { get; set; } = false;
        public string BaseUrl { get; set; } = "";
    }
}
