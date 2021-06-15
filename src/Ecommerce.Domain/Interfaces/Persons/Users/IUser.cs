using System.Collections.Generic;
using System.Security.Claims;

namespace Ecommerce.Domain.Interfaces.Persons.Users
{
    public interface IUser
    {
        string Nmae { get; }

        bool IsAuthenticated();

        IEnumerable<Claim> GetClaimIdentity();
    }
}
