using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace prodmatApp.Models;

public partial class ProdMatDbContext : DbContext
{
    public ProdMatDbContext()
    {
    }

    public ProdMatDbContext(DbContextOptions<ProdMatDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<WarehouseMaterial> WarehouseMaterials { get; set; }

    public virtual DbSet<WarehouseProduct> WarehouseProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=prodMatDB;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Materials_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutoAmount)
                .HasDefaultValue(1)
                .HasColumnName("autoAmount");
            entity.Property(e => e.Colour)
                .HasDefaultValueSql("'FFFFFF'::text")
                .HasColumnName("colour");
            entity.Property(e => e.NameOfMaterial).HasColumnName("nameOfMaterial");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasDefaultValueSql("'FFFFFF'::text")
                .HasColumnName("colour");
            entity.Property(e => e.IdTemplate).HasColumnName("idTemplate");
            entity.Property(e => e.NameOfProduct).HasColumnName("nameOfProduct");

            entity.HasOne(d => d.IdTemplateNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTemplate)
                .HasConstraintName("fk_products_warehouse_products");
        });

        modelBuilder.Entity<WarehouseMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Warehouse_Materials_pkey");

            entity.ToTable("Warehouse_Materials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAddedProduct).HasColumnName("idAddedProduct");
            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
            entity.Property(e => e.IsAdded).HasColumnName("isAdded");
            entity.Property(e => e.IsCanceled).HasColumnName("isCanceled");
            entity.Property(e => e.IsMultipliedByProduct).HasColumnName("isMultipliedByProduct");

            entity.HasOne(d => d.IdAddedProductNavigation).WithMany(p => p.WarehouseMaterials)
                .HasForeignKey(d => d.IdAddedProduct)
                .HasConstraintName("fk_warehouse_materials_warehouse_products");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.WarehouseMaterials)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_warehouse_materials");
        });

        modelBuilder.Entity<WarehouseProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WareHouse_Products_pkey");

            entity.ToTable("Warehouse_Products");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"WareHouse_Products_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.IdProduct).HasColumnName("idProduct");
            entity.Property(e => e.IsAdded)
                .HasDefaultValue(true)
                .HasColumnName("isAdded");
            entity.Property(e => e.IsCanceled)
                .HasDefaultValue(false)
                .HasColumnName("isCanceled");
            entity.Property(e => e.IsTemplateOnly)
                .HasDefaultValue(false)
                .HasColumnName("isTemplateOnly");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.WarehouseProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_warehouse_products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
