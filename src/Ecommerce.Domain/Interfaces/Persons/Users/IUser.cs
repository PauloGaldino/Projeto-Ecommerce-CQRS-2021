using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.Persons.Users
{
    public interface IUser
    {
        string Nmae { get; }

        bool IsAuthenticated();

        IEnumerable<Claim> GetClaimIdentity();
    }
}
