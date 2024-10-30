using BackToBasicsApp.Exceptions;
using BackToBasicsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Repositories
{
    public abstract class Repositories<K, T> : IRepository<K, T> where T : class
    {
        IList<T> list;
        //public Repositories()
        //{
        //    list = new List<T>();
        //}
        protected Repositories(IList<T> givenList)
        {
            list = givenList;
        }
        public T Add(T item)
        {
            list.Add(item);
            return item;
        }

        public T Delete(K key)
        {
            T item = Get(key);
            if(item != null)
            {
                list.Remove(item);
                return item;
            }
            throw new EntityNotFoundException();
        }

        public abstract T Get(K key);
    

        public IEnumerable<T> GetAll()
        {
            if(list.Count == 0)
                throw new CollectionEmptyException();
            return list;
        }

        public T Update(K key, T item)
        {
            T oldItem = Get(key);
            if (item != null)
            {
                list.Remove(oldItem);
                list.Add(item);
                return item;
            }
            throw new EntityNotFoundException();
        }
    }
}
