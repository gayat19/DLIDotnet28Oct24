using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Interfaces
{
    public interface IRepository<K,T> where T : class
    {
        public T Add(T item);
        public T Update(K key,T item);
        public T Delete(K key);
        public T Get(K key);
        public IEnumerable<T> GetAll();
        
    }
}
