using CJTechShow.Client.Pages;
using CJTechShow.Server.Configurations.Entities;
using CJTechShow.Server.Models;
using CJTechShow.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Drawing;

namespace CJTechShow.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<VendorPage> VendorPages { get; set; }
        public DbSet<SponsorPage> SponsorPages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new VisitorSeedConfiguration());
            builder.ApplyConfiguration(new OrganizerSeedConfiguration());
            builder.ApplyConfiguration(new VendorPageSeedConfiguration());
            builder.ApplyConfiguration(new SponsorPageSeedConfiguration());
            builder.ApplyConfiguration(new MainSeedConfiguration());


        }
    }
}