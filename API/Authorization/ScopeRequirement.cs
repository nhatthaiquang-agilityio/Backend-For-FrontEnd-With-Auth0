using Microsoft.AspNetCore.Authorization;

namespace Api.Authorization
{
    public class ScopeRequirement : IAuthorizationRequirement
    {
        public string Scope { get; private set; }

        public ScopeRequirement(string scope)
        {
            Scope = scope;
        }
    }
}
