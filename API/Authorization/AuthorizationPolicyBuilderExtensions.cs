using Microsoft.AspNetCore.Authorization;

namespace Api.Authorization
{
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static AuthorizationPolicyBuilder RequireScope(this AuthorizationPolicyBuilder builder, string scope)
        {
            return builder.AddRequirements(new ScopeRequirement(scope));
        }
    }
}
