using UserDemo.Core.Interface;
using UserDemo.Infrastructure.Data;
using UserDemo.Core.Entities;

namespace UserDemo.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDemoContext _context;
        public UserRepository(UserDemoContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public void AddUser(User user) 
        { 
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
