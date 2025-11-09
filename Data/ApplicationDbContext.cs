using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LisaKonveyer.Models;

namespace LisaKonveyer.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Client> Clients {get;set;}
        public DbSet<Filial> Filials {get;set;}
        public DbSet<Loan> Loans {get;set;}
        public DbSet<LoanRequest> LoanRequests {get;set;}
        public DbSet<Application> Applications {get;set;}
        public DbSet<PhoneNumber> PhoneNumbers {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoanRequest>()
                .HasOne(lr=>lr.Filial)
                .WithMany()
                .HasForeignKey(lr=>lr.FilialId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanRequest>()
                .HasOne(lr=>lr.Client)
                .WithMany()
                .HasForeignKey(lr=>lr.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanRequest>()
                .HasOne(lr=>lr.Application)
                .WithMany()
                .HasForeignKey(lr=>lr.ApplicationId)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Loan>()
                .HasOne(lr=>lr.Filial)
                .WithMany()
                .HasForeignKey(lr=>lr.FilialId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Loan>()
                .HasOne(lr=>lr.Client)
                .WithMany()
                .HasForeignKey(lr=>lr.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Loan>()
                .HasOne(lr=>lr.Application)
                .WithMany()
                .HasForeignKey(lr=>lr.ApplicationId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
