using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace BugBountyDevs.Businness.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        Object Get(string key);

        void Insert(string key, Object obj, int duration);

        void Remove(string key);

        void RemoveByPattern(string pattern);
    }
}
