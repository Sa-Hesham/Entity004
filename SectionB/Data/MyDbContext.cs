using Microsoft.EntityFrameworkCore;
using SectionB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SectionB.Data
{
    internal class MyDbContext :DbContext
    {
        #region Q1
        ////    public DbSet<Vehicle> Vehicles { get; set; } = null!;

        ////    protected override void OnModelCreating(ModelBuilder modelBuilder)
        ////    {

        ////        //modelBuilder.Entity<Car>().HasBaseType<Vehicle>();
        ////        //modelBuilder.Entity<Bus>().HasBaseType<Vehicle>();


        ////         modelBuilder.Entity<Vehicle>()
        ////        .HasDiscriminator<string>("VehicleType")
        ////        .HasValue<Vehicle>("Vehicle")
        ////        .HasValue<Car>("Car")
        ////        .HasValue<Bus>("Bus");


        ////    }



        ////    public DbSet<Vehicle> vehicles { get; set; }


        ////    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        ////    {
        ////        optionsBuilder.UseSqlServer("Server=.;Database=VehiclesDb;Trusted_Connection=True;TrustServerCertificate=True;");


        ////    } 
        #endregion



        #region Q2
        //public DbSet<Payment> Payments { get; set; } 
        //public DbSet<CreditCardPayment> CreditCardPayments { get; set; } 
        //public DbSet<CashPayment> CashPayments { get; set; } 

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
         
        //    modelBuilder.Entity<CreditCardPayment>().ToTable("CreditCardPayments");
        //    modelBuilder.Entity<CashPayment>().ToTable("CashPayments");
        //    modelBuilder.Entity<Payment>().ToTable("Payments");

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=PaymentsDb;Trusted_Connection=True;TrustServerCertificate=True;");
         
        //}
        #endregion
    }
}
