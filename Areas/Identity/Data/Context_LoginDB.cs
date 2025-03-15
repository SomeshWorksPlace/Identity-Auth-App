using IdentityFramework_AUTH.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityFramework_AUTH.Areas.Identity.Data;

public class Context_LoginDB : IdentityDbContext<ApplicationUser>
{
    public Context_LoginDB(DbContextOptions<Context_LoginDB> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        //for fetching the properties from the mode or applicationUser

        builder.ApplyConfiguration(new ApplicationLoginConfiguration());

    }

/*public class ApplicationLoginConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

    }*/
        }

public class ApplicationLoginConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(m => m.FirstName).HasMaxLength(250);
        builder.Property(m => m.LastName).HasMaxLength(250);
    }
}