using System.Collections.Generic;

namespace ProductionCode
{
    public static class ClaimValueGenerator
    {
        public static string ClaimValue(Dictionary<string, string> userClaims, string claim)
        {
            // Ignore userclaims for now...
            return (claim == null) ? null : $"VALUE FOR CLAIM {claim} is {claim}";
        }
    }
}