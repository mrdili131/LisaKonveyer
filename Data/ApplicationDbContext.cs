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

        DbSet<Client> Clients {get;set;}
        DbSet<Filial> Filials {get;set;}
        DbSet<Loan> Loans {get;set;}
        DbSet<LoanRequest> LoanRequests {get;set;}

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
