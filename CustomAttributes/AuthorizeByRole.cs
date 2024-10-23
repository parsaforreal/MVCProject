using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace Irandoc.EPayment.Web.CustomAttributes
{
    public class AuthorizeByRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeByRoleAttribute(params string[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}
