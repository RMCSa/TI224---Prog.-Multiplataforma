
using Microsoft.EntityFrameworkCore;

public partial class DatabaseContext : DbContext{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<SalesOrder> SalesOrders { get; set; }
    public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder){ // Fluid Api method
        modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
        modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Customer>().Property(c => c.City).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Customer>().Property(c => c.State).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Customer>().Property(c => c.Latitude).IsRequired().HasPrecision(10, 3);
        modelBuilder.Entity<Customer>().Property(c => c.Longitude).IsRequired().HasPrecision(11, 3);

        modelBuilder.Entity<ProductCategory>().HasKey(pc => pc.ProductCategoryId);
        modelBuilder.Entity<ProductCategory>().Property(pc => pc.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<ProductCategory>().HasMany<Product>().WithOne().HasForeignKey(p => p.ProductCategoryId); //Um para muitos

        modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
        modelBuilder.Entity<Product>().Property(p => p.ProductCategoryId).IsRequired();
        modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Product>().Property(p => p.UnitPrice).IsRequired().HasPrecision(11, 5);
        modelBuilder.Entity<Product>().HasMany<SalesOrderItem>().WithOne().HasForeignKey(soi => soi.ProductId); //Um para muitos

        modelBuilder.Entity<SalesOrder>().HasKey(so => so.SalesOrderId);
        modelBuilder.Entity<SalesOrder>().HasOne<Customer>().WithMany().HasForeignKey(so => so.CustomerId);
        modelBuilder.Entity<SalesOrder>().Property(so => so.OrderDate).IsRequired();
        modelBuilder.Entity<SalesOrder>().Property(so => so.EstimatedDeliveryDate).IsRequired();
        modelBuilder.Entity<SalesOrder>().Property(so => so.Status).IsRequired().HasMaxLength(20);
        modelBuilder.Entity<SalesOrder>().HasMany<SalesOrderItem>().WithOne().HasForeignKey(soi => soi.OrderId); //Um para muitos

        modelBuilder.Entity<SalesOrderItem>().HasKey(soi => new { soi.OrderId, soi.ProductId }); // Chave composta
        modelBuilder.Entity<SalesOrderItem>().Property(soi => soi.Quantity).IsRequired();
        modelBuilder.Entity<SalesOrderItem>().Property(soi => soi.UnitPrice).IsRequired().HasPrecision(11, 5);


        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}