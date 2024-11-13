namespace FirstAPiApp.Interfaces
{
    public interface IRepository<K, T> where T : class
    {
        public Task<T> GetAsync(K key);
        public Task<ICollection<T>> GetAllAsync();
        public Task<T> AddAsync(T item);
        public Task<T> UpdateAsync(K key, T item);
        public Task<T> DeleteAsync(K key);
    }
}
