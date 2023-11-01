using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace web_app_1.Models;

public partial class Customerdb2Context : DbContext
{
    public Customerdb2Context()
    {
    }

    public Customerdb2Context(DbContextOptions<Customerdb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer2> Customer2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=15432;User Id=postgres;Password=password;Database=customerdb2;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer2>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("customer2_pkey");

            entity.ToTable("customer2");

            entity.Property(e => e.Customerid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("customerid");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Customeramount).HasColumnName("customeramount");
            entity.Property(e => e.Customername)
                .HasMaxLength(50)
                .HasColumnName("customername");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
