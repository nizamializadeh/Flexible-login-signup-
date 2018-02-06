namespace WebApplication9.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(e => e.User_Role)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Role_id);

            modelBuilder.Entity<Table>()
                .HasMany(e => e.User_Role)
                .WithRequired(e => e.Table)
                .HasForeignKey(e => e.Table_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User_Role)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_id);
        }
    }
}
