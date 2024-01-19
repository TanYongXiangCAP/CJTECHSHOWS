using CJTechShow.Client.Pages;
using CJTechShow.Server.Models;
using CJTechShow.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Organizers> Organizers { get; set; }
        public DbSet<ITTechShows> ITTechShows { get; set; }
        public DbSet<Sponsors> Sponsors { get; set; }

    }
}