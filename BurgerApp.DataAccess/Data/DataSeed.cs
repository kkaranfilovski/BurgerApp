using BurgerApp.Domain.Enums;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Data
{
    public static class DataSeed
    {
        public static void InsertData(ModelBuilder builder)
        {
            builder.Entity<Burger>()
                .HasData
                (
                    new Burger
                    {
                        Id = 1,
                        Name = "Hamburger",
                        Price = 150,
                        IsVegan = false,
                        IsVegeterian = false,
                        HasFries = true,
                        Image = "https://www.pngall.com/wp-content/uploads/2016/05/Burger-Free-Download-PNG.png"
                    },
                    new Burger
                    {
                        Id = 2,
                        Name = "Cheeseburger",
                        Price = 180,
                        IsVegan = false,
                        IsVegeterian = false,
                        HasFries = true,
                        Image = "https://www.pngmart.com/files/16/Bacon-Cheese-Burger-Transparent-PNG.png"
                    },
                    new Burger
                    {
                        Id = 3,
                        Name = "Vegeburger",
                        Price = 140,
                        IsVegan = false,
                        IsVegeterian = true,
                        HasFries = true,
                        Image = "https://www.kindpng.com/picc/m/537-5374610_veg-patties-png-burger-images-hd-png-transparent.png"
                    },
                    new Burger
                    {
                        Id = 4,
                        Name = "Veganburger",
                        Price = 200,
                        IsVegan = true,
                        IsVegeterian = true,
                        HasFries = false,
                        Image = "https://www.seekpng.com/png/full/316-3165034_falafel-burger-hamburger.png"
                    }
                );

            builder.Entity<Order>()
                .HasData
                (
                    new Order
                    {
                        Id = 1,
                        UserId = 1,
                        IsDelivered = false,
                        PaymentMethod = PaymentMethod.card,
                    },
                    new Order
                    {
                        Id = 2,
                        UserId = 2,
                        IsDelivered = false,
                        PaymentMethod = PaymentMethod.card,
                    },
                    new Order
                    {
                        Id = 3,
                        UserId = 3,
                        IsDelivered = false,
                        PaymentMethod = PaymentMethod.card,
                    }
                );

            builder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        Id = 1,
                        FirstName = "Kristijan",
                        LastName = "Karanfilovski",
                        Address = "ul.France Preshern br.46",
                        Location = "Vlae",
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Ilija",
                        LastName = "Mitev",
                        Address = "ul. Radishani Hills br. 10",
                        Location = "Radishani",
                    },
                    new User
                    {
                        Id = 3,
                        FirstName = "Aneta",
                        LastName = "Stankovska",
                        Address = "ul.Sparkling Water br. 99",
                        Location = "Kisela voda",
                    }
                );

            builder.Entity<BurgerOrder>()
                .HasData
                (
                new BurgerOrder
                {
                    Id = 1,
                    OrderId = 1,
                    BurgerId = 1  
                },
                new BurgerOrder
                {
                    Id = 2,
                    OrderId = 1,
                    BurgerId = 2  
                },
                new BurgerOrder
                {
                    Id = 3,
                    OrderId = 2,
                    BurgerId = 3
                },
                new BurgerOrder
                {
                    Id = 4,
                    OrderId = 3,
                    BurgerId = 3
                },
                new BurgerOrder
                {
                    Id = 5,
                    OrderId = 3,
                    BurgerId = 4
                }
                );
        }
    }
}
