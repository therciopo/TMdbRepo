using Akavache;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace TMDbApp.Services
{
    public class CacheService : ICacheService
    {
        public CacheService()
        {
            try
            {
                //BlobCache.ApplicationName = "TMdb"; It seems there´s a bug on referencing this package from nuget. So i decided to stop and finish the code challenge on time
            }
            catch (Exception e)
            {
                var a = e.Message;
            }
        }

        public async Task<T> GetObject<T>(string key)
        {
            try
            {
                return await BlobCache.LocalMachine.GetObject<T>(key);
            }
            catch (KeyNotFoundException)
            {
                return default(T);
            }
        }

        public async Task InsertObject<T>(string key, T value)
        {
            await BlobCache.LocalMachine.InsertObject(key, value);
        }

        public async Task RemoveObject(string key)
        {
            await BlobCache.LocalMachine.Invalidate(key);
        }
    }
}