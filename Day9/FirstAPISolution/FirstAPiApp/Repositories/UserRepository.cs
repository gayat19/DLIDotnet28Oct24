using FirstAPiApp.Contexts;
using FirstAPiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPiApp.Repositories
{
    public class UserRepository : Repository<int, User>
    {
        public UserRepository(HRContext context):base(context)
        {
            
        }
        public async override Task<ICollection<User>> GetAllAsync()
        {
            var users = _context.Users;
            if (users.Count() == 0)
                throw new Exception("NO users Exception");
            return users.ToList();
        }

        public async override Task<User> GetAsync(int key)
        {
           var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == key);
            if (user == null)
                throw new Exception("No such user");
            return user;
        }
    }
}
