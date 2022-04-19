using System;
using Xunit;

namespace UnitTests
{
    public class GooglePageScrapperTests
    {
       // readonly IHtmlParser htmlParser;
        readonly GooglePageScrapper sut;

        public GooglePageScrapperTests()
        {
            sut = new GooglePageScrapper();
        }

        [Fact]
        public void Should_throw_exception_for_null_html_Source()
        {

        }
    }
}
