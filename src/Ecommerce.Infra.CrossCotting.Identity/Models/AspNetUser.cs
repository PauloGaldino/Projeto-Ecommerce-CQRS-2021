using Ecommerce.Domain.Interfaces.Persons.Users;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace Ecommerce.Infra.CrossCotting.Identity.Models
{
    public class AspNetUser : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }
        public IEnumerable<Claim> GetClaimIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }


    }
}
