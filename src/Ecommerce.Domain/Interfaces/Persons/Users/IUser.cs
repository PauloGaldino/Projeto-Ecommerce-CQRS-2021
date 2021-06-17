using System.Collections.Generic;
using System.Security.Claims;

namespace Ecommerce.Domain.Interfaces.Persons.Users
{
    public interface IUser
    {
        string Name { get; }

        bool IsAuthenticated();

        IEnumerable<Claim> GetClaimIdentity();
    }
}
