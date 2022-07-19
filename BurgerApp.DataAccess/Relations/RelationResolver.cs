using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Relations
{
    public class RelationResolver
    {
        public static void AddOrderRelation(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);                
        }

        public static void AddUserRelation(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }

        public static void AddBurgerRelation(ModelBuilder builder)
        {
            builder.Entity<Burger>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);
        }
    }
}
