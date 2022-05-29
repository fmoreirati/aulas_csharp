using _05_WebAPP.MVC.Models;

namespace _05_WebAPP.MVC.Interfaces
{
    public interface IUserService
    {
        public Task<bool> AddAsync(User users);

        public Task<List<User>> ListAsync(int page, int dataPag);

        public Task<User?> GetAsync(long id);

        public bool Remove(User user);
    }
}