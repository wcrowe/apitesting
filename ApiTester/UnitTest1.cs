using System;
using System.Formats.Asn1;
using System.Net.Http;
using ApiTester.Api;
using ApiTester.Client;
using Xunit;

namespace ApiTester
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var quoteApi = new QuoteApi("https://test-api.iasadmin.com/Quote_API");
            var qu = await quoteApi.ApiQuoteGetUSStateGetWithHttpInfoAsync("33611");
            Assert.Equal("FL", qu.Content.ToString());
        }

        [Fact]
        public async void Test2()
        {
            var quoteApi = new QuoteApi("https://test-api.iasadmin.com/Quote_API");
            var qu = await quoteApi.ApiQuoteGetIssueAgeGetWithHttpInfoAsync(DateTime.Now,
                Convert.ToDateTime("11/23/1968"));
            Assert.Equal("52", qu.Content.ToString());
        }
    }
}
