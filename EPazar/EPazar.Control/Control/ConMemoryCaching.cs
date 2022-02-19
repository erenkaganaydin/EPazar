using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace EPazar.Control.Control
{
    public static class ConMemoryCaching
    {
        public static List<T> DataResult<T>(string cacheName, List<T> entity, IMemoryCache memoryCache, int duration = 30)
        {
            memoryCache.Set(cacheName, entity, TimeSpan.FromSeconds(duration));
            return entity;
        }

        public static T DataResult<T>(string cacheName, T entity, IMemoryCache memoryCache, int duration = 30)
        {
            memoryCache.Set(cacheName, entity, TimeSpan.FromSeconds(duration));
            return entity;
        }
    }
}