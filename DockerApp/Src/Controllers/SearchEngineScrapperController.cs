using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace DockerApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SearchEngineScrapperController : ControllerBase
    {

        private readonly ILogger<SearchEngineScrapperController> _logger;
        private readonly ISearchUrlBuilder _searchUrlBuilder;
        private readonly ISearchEngineHttpHandler _searchEngineHttpHandler;
        private readonly IPageScrapper _pageScrapper;

        public SearchEngineScrapperController(ILogger<SearchEngineScrapperController> logger, ISearchUrlBuilder searchUrlBuilder, ISearchEngineHttpHandler searchEngineHttpHandler, IPageScrapper pageScrapper)
        {
            _logger = logger;
            _searchUrlBuilder = searchUrlBuilder;
            _searchEngineHttpHandler = searchEngineHttpHandler;
            _pageScrapper = pageScrapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetResult([FromQuery] SearchModel searchModel)
        {
            try
            {
                Uri seeachUrl = _searchUrlBuilder.Build(searchModel.Keyword);
                string searchResults = await _searchEngineHttpHandler.Search(seeachUrl);

                string result = _pageScrapper.ScrapeForUrl(searchResults, searchModel.Url);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetResult error", ex.Message);
                return Problem(detail: ex.Message, statusCode: (int)HttpStatusCode.InternalServerError);
            }            

        }
    }
}
