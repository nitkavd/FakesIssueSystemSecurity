using System;
[assembly: System.Security.SecurityRules(global::System.Security.SecurityRuleSet.Level2, SkipVerificationInFullTrust = true)]

namespace SecuredProject
{
    public class SecuredClass
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
