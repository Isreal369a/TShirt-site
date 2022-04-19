using System;

namespace DockerApp
{
    public interface ISearchUrlBuilder
    {
        Uri Build(string searchWords);
    }
}