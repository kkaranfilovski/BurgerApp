using BurgerApp.DataAccess.Data;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {

        private readonly BurgerAppDbContext _context;
        public UserRepository(BurgerAppDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteUser = GetById(id);
            if(deleteUser != null)
            {
                _context.Users.Remove(deleteUser);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("User with that ID was not found!");
            }
        }

    }
}
