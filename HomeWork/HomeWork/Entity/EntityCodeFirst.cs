using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HomeWork.Entity
{
    public partial class EntityCodeFirst : DbContext
    {
        public EntityCodeFirst()
            : base("name=EntityCodeFirst")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersHasProduct> OrdersHasProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrdersHasProduct)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.id_orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrdersHasProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.id_product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserData>()
                .HasMany(e => e.Client)
                .WithOptional(e => e.UserData)
                .HasForeignKey(e => e.ud_id);

            modelBuilder.Entity<UserData>()
                .HasMany(e => e.User)
                .WithOptional(e => e.UserData)
                .HasForeignKey(e => e.ud_id);
        }
    }
}
