using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager 
    {
        protected ObjectCache Cache => MemoryCache.Default;
        public void Add(string key, object data)
        {
            if (data==null)
            {
                return;
            }
            Cache.Add(new CacheItem(key, data),null);
            
        }

        public void Clear()
        {
            foreach (var item in Cache)
            {
                Remove(item.Key);
            }
        }
        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}
