using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataMVCCore.Models;

public partial class BusinessDbContext : DbContext
{
    public BusinessDbContext()
    {
    }

    public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=PC2022;Initial Catalog=BusinessDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK_Employee");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Firstname)
                .HasMaxLength(30)
                .HasColumnName("firstname");
            entity.Property(e => e.Hiredate)
                .HasColumnType("date")
                .HasColumnName("hiredate");
            entity.Property(e => e.Lastname)
                .HasMaxLength(30)
                .HasColumnName("lastname");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");

            entity.HasOne(d => d.Store).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Storeid)
                .HasConstraintName("FK_Employee_Store");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Orderid)
                .ValueGeneratedNever()
                .HasColumnName("orderid");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Freight)
                .HasColumnType("money")
                .HasColumnName("freight");
            entity.Property(e => e.Orderdate)
                .HasColumnType("date")
                .HasColumnName("orderdate");
            entity.Property(e => e.Shipcity)
                .HasMaxLength(50)
                .HasColumnName("shipcity");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Employeeid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Orders_Employee");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Storeid).HasName("PK_Store");

            entity.Property(e => e.Storeid)
                .ValueGeneratedNever()
                .HasColumnName("storeid");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Storename)
                .HasMaxLength(50)
                .HasColumnName("storename");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
