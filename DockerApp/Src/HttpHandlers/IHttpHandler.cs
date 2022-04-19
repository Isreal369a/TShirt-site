using System;
using System.Threading.Tasks;

namespace DockerApp
{
    public interface ISearchEngineHttpHandler
    {
        Task<string> Search(Uri searchUrl);
    }
}
