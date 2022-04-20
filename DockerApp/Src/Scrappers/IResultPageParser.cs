using System.Collections.Generic;

namespace DockerApp
{
    public interface IResultPageParser
    {
        IEnumerable<string> Parse(string htmlSource);
    }
}