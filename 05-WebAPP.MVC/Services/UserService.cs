using _05_WebAPP.MVC.Data;
using _05_WebAPP.MVC.Interfaces;
using _05_WebAPP.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _05_WebAPP.MVC.Services
{
    public class UserService : IUserService
    {
        protected EntityContext _context;

        public UserService(EntityContext context)
        {
            _context = context;
        }

        public bool Add(User newUser)
        {
            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<User?> GetAsync(long id)
        {
            try
            {
                return await _context.Users.Where(u => u.id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o usuário.", ex);
            }
        }

        public Task<List<User>> ListAsync(int page, int dataPage)
        {
            try
            {
                var contUser = _context.Users.Count();
                var totalPags = (int)Math.Ceiling((decimal)contUser / dataPage);
                return _context.Users.Skip((page - 1) * dataPage).Take(dataPage).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os usuário.", ex);
            }
        }

        public bool Remove(User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao removero o usuário", ex);
            }
        }
    }
}