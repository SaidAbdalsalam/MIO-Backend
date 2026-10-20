using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIO.Application.Interfaces;

namespace MIO.Infrastructure.Data;

public sealed class AppDbContext : IdentityDbContext, IAppDbContext
{


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
