using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

namespace TTLOtomasyonWebAPI.Control.Interface
{
    public interface ICache<T> : IMemoryCache
    {
        IEnumerable<T> Cache(string cacheName, IEnumerable<T> result, int duration);
    }
}