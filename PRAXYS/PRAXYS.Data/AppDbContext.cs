using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company_PaymentType>().HasKey(x => new { x.CompanyID, x.PaymenTypeID });
            modelBuilder.Entity<Client_Address>().HasKey(x => new { x.AddressID, x.ClientID });
            modelBuilder.Entity<Company_Address>().HasKey(x => new { x.AddressID, x.CompanyID });
            modelBuilder.Entity<Agent_Address>().HasKey(x => new { x.AddressID, x.AgentID });
            modelBuilder.Entity<CoveragePlan_Coverage>().HasKey(x => new { x.CoverageID, x.CoveragePlanID });
            modelBuilder.Entity<Ramo_Coverage>().HasKey(x => new { x.CoverageID, x.BranchID });

            //------CREAR DATOS DEL USUARIO ADMINISTRADOR
            /*var hasher = new PasswordHasher<IdentityUser>();
            var roleAdminId = "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2";
            var userAdminID = "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4";

            var roleAdmin = new IdentityRole()
            {
                Id = roleAdminId,
                Name = "admin",
                NormalizedName = "admin"
            };

            var userAdmin = new IdentityUser()
            {
                Id = userAdminID,
                Email = "ccervantes@umbrella-seguros.com",
                UserName = "Admin1234",
                NormalizedUserName= "Admin1234",
                NormalizedEmail = "ccervantes@umbrella-seguros.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Aa12345!"),
            };

            modelBuilder.Entity<IdentityUser>().HasData(userAdmin);
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>() 
                { 
                    RoleId =  roleAdminId, 
                    UserId = userAdminID 
                });
            modelBuilder.Entity<IdentityRole>().HasData(roleAdmin);*/

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Adress { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<SubBranch> SubBranch { get; set; }
        public DbSet<Coverage> Coverage { get; set; }
        public DbSet<CoveragePlan> CoveragePlan { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<SubAgent> SubAgent { get; set; }
        public DbSet<PaymentInformation> PaymentInformation { get; set; }
        public DbSet<ClientDocumentation> ClientDocumentation { get; set; }
        public DbSet<InsuranceDocumentation> InsuranceDocumentation { get; set; }
        public DbSet<RegisterPayment> RegisterPayment { get; set; }
        public DbSet<Bond> Bond { get; set; }
        public DbSet<BondPayment> BondPayments { get; set; }
        public DbSet<CommissionPayment> CommissionPayments { get; set; }
        public DbSet<Endorsement> Endorsement { get; set; }
        public DbSet<EndorsementType> EndorsementType { get;set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Movement> Movement { get; set; }

        public DbSet<Company_PaymentType> Agent_PaymentTypes { get; set; }
        public DbSet<Company_Address> Company_Address { get; set; }
        public DbSet<Ramo_Coverage> Ramo_Coverage { get; set; }
        public DbSet<Client_Address> Client_Address { get; set; }
        public DbSet<Agent_Address> Agent_Address { get; set; }
        public DbSet<CoveragePlan_Coverage> CoveragePlan_Coverage { get; set; }
        public DbSet<PRAXYS.Shared.Entities.Agent> Agent { get; set; }
    }
}
