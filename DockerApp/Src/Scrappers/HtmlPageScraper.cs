using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System.Text;

namespace DockerApp
{
    public class GooglePageScrapper : IPageScrapper
    {
        public const string RESULT_LINK_SELECTOR = "div.egMi0 a";
        private readonly IHtmlParser parser;

        public GooglePageScrapper(IHtmlParser htmlParser)
        {
            parser = htmlParser;
        }

        public string ScrapeForUrl(string htmlSource, string url)
        {           

            var _document = parser.ParseDocument(htmlSource);
            IHtmlCollection<IElement> elems = _document.QuerySelectorAll(RESULT_LINK_SELECTOR);


            int count = 0;
            StringBuilder result = new StringBuilder("0");

            for (int i = 0; i < elems.Length; i++)
            {
                count++;
                if (elems[i] != null && elems[i].OuterHtml.Contains(url))
                {
                    if (result.Length > 0)
                    {

                        result.Append(',');
                    }
                    result.Append(count);
                }

            }
            return result.ToString();
        }
    }

   /* public class ResultBuilder
    {
        public string BuildResult(IHtmlCollection<IElement>)
    }
   */
}
