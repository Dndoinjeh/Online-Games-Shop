namespace OnlineShop
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopEntities : DbContext
    {
        public OnlineShopEntities()
            : base("name=OnlineShopEntities")
        {
        }

        public virtual DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
