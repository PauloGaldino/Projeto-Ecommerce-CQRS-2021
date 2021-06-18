using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.UI.Web.Data
{
    public class ApplicationsDbContext : IdentityDbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options)
            : base(options)
        {
        }
    }
}
