using BurgerApp.DataAccess.Data;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BurgerAppDbContext _context;
        public OrderRepository(BurgerAppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAll()
        {
            return _context.Orders
                .Include(x => x.User)
                .Include(x => x.BurgerOrders)
                .ThenInclude(x => x.Burger).ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders
                .Include(x => x.User)
                .Include(x => x.BurgerOrders)
                .ThenInclude(x => x.Burger)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            _context.Orders.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteOrder = _context.Orders.FirstOrDefault(x => x.Id == id);
            if(deleteOrder != null)
            {
            _context.Orders.Remove(deleteOrder);
            _context.SaveChanges();
            }
            else
            {
                throw new Exception("Order with that ID was not found!");
            }
        }
    }
}
