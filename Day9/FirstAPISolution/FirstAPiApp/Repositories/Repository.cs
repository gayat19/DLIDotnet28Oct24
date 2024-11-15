using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;

namespace FirstAPiApp.Repositories
{
    public abstract class Repository<K, T> : IRepository<K, T> where T : class
    {
        protected readonly HRContext _context;

        public Repository(HRContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<T> DeleteAsync(K key)
        {
            var item = await GetAsync(key);
            if (item != null) 
            {
                _context.Remove(item);
                await _context.SaveChangesAsync();
                return item;
            }
            throw new Exception("No suct item "+typeof(T));
        }

        public abstract  Task<ICollection<T>> GetAllAsync();


        public abstract  Task<T> GetAsync(K key);


        public async Task<T> UpdateAsync(K key, T item)
        {
            var newItem = await GetAsync(key);
            if (newItem != null)
            {
                _context.Update(newItem);
                await _context.SaveChangesAsync();
                return item;
            }
            throw new Exception("No suct item " + typeof(T));
        }
    }
}
