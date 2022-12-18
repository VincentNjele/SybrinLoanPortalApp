using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SybrinLoanPortal.Server.Models;
using SybrinLoanPortal.Shared.Models;

namespace SybrinLoanPortal.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<ClientDoc> ClientDoc { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Loan> Loan { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductType>().HasData(new ProductType
            {
                Id = 1,
                Name = "Loan Account"
            },
            new ProductType
            {
                Id = 2,
                Name = "Cheque Account"
            },
            new ProductType
            {
                Id = 3,
                Name = "Savings Account"
            }

            );
            builder.Entity<ClientDoc>().HasData(new ClientDoc
            {
                Id = 1,
                ProductTypeId = 1,
                CountryOfBirth = "Zambia",
                FirstName = "Vincent",
                Gender = "Male",
                LastName = "Njele",
                Nationality = "Zambian",
                Status = "Active"
            },
             new ClientDoc
             {
                 Id = 2,
                 ProductTypeId = 1,
                 CountryOfBirth = "Zambia",
                 FirstName = "Sarah",
                 Gender = "Female",
                 LastName = "Njele",
                 Nationality = "Zambian",
                 Status = "Active"
             },

           new ClientDoc
           {
               Id = 3,
               ProductTypeId = 1,
               CountryOfBirth = "Zambia",
               FirstName = "Muze",
               Gender = "Male",
               LastName = "Oda",
               Nationality = "Zambian",
               Status = "Active"
           },
               new ClientDoc
               {
                   Id = 4,
                   ProductTypeId = 1,
                   CountryOfBirth = "Zambia",
                   FirstName = "Faith",
                   Gender = "Female",
                   LastName = "Kabandula",
                   Nationality = "Zambian",
                   Status = "Active"
               });
            base.OnModelCreating(builder);
        }
    }
}