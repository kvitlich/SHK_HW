using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SKHPay.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SKHPay
{
  public class ClassContext : DbContext
  {
    
    public ClassContext()
    {
      Database.EnsureCreated();
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=KVITLICH;Database=SKHS_Db;Trusted_Connection=true;");
    }
  }
}
