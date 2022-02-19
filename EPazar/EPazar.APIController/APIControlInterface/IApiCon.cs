using EPazar.APIControls.APIControlBaseUrl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.APIControls.APIControlInterface
{
    public interface IApiCon<T> : IDisposable where T : class, new()
    {
        public Task<List<T>> ApiPost(string baseUrl,T Entity);

    }
}
