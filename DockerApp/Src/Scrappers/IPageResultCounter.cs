namespace DockerApp
{
    public interface IResultPageCounter
    {
        string CountUrlOccurence(string htmlSource, string url);
    }
}