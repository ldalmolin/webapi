using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webapi.Models
{
    public partial class WebapiContext : IdentityDbContext
    {
        public WebapiContext(DbContextOptions<WebapiContext> options) : base(options)
        { }

    }
}
