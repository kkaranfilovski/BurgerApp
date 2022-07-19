using BurgerApp.DataAccess.Relations;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Data
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order>? Orders{ get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Burger>? Burgers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // data relations
            RelationResolver.AddOrderRelation(builder);
            RelationResolver.AddUserRelation(builder);
            RelationResolver.AddBurgerRelation(builder);

            // data seed
            DataSeed.InsertData(builder);
        }

    }
}
