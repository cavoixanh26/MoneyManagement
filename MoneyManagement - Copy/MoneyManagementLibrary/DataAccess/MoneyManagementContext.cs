using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MoneyManagementLibrary.DataAccess;

public partial class MoneyManagementContext : DbContext
{
    public MoneyManagementContext()
    {
    }

    public MoneyManagementContext(DbContextOptions<MoneyManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Borrow> Borrows { get; set; }

    public virtual DbSet<CateIncome> CateIncomes { get; set; }

    public virtual DbSet<CateSpend> CateSpends { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<Spend> Spends { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDB"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borrow>(entity =>
        {
            entity.ToTable("Borrow");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Money).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Time).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Borrows)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Borrow_User");
        });

        modelBuilder.Entity<CateIncome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Category");

            entity.ToTable("CateIncome");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CateSpend>(entity =>
        {
            entity.ToTable("CateSpend");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Income>(entity =>
        {
            entity.ToTable("Income");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.Money).HasColumnType("money");
            entity.Property(e => e.Time).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Cate).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK_Income_Category");

            entity.HasOne(d => d.User).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Income_User");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.ToTable("Loan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Money).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Time).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Loans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Loan_User");
        });

        modelBuilder.Entity<Spend>(entity =>
        {
            entity.ToTable("Spend");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.Money).HasColumnType("money");
            entity.Property(e => e.Time).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Cate).WithMany(p => p.Spends)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK_Spend_CateSpend");

            entity.HasOne(d => d.User).WithMany(p => p.Spends)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Spend_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
