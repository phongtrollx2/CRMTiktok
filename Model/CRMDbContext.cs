using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public partial class CRMDbContext : DbContext
    {
        public CRMDbContext()
            : base("name=CRMDbContext")
        {
        }

        public virtual DbSet<CustomerCategory> CustomerCategories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerCategory>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.CustomerCategory)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UID);
        }
    }
}
