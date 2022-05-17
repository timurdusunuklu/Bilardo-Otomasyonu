﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager 
    {
        T Get<T>(string key);
        void Add(string key, object data);
        void Remove(string key);
        void Clear();

    }
}
