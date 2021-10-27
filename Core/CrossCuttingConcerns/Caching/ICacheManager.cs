using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int dureation);
        bool IsAdd(string key);//cachete varmı
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
