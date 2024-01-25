using BuySell.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Dal.Context
{
    public class BuySellContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=BuySellProject;Trusted_Connection=True; Encrypt=False;");
        }

        public DbSet<InstitutionalUser> InstitutionalUsers { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstitutionalUser>().HasData(
                new InstitutionalUser() { Id=1, CorporateName="komagene", GSMNo="12345678901", Address="istanbul", TaxNumber=15141312, TaxAdministration="veri mevcut değil"}
                );
        }
    }
}
