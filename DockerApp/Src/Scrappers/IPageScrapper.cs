namespace DockerApp
{
    public interface IPageScrapper
    {
        string ScrapeForUrl(string htmlSource, string url);
    }
}