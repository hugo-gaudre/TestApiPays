using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTestableApi.Controllers;
using Xunit;

namespace MyTestableApi.Tests
{
    public class CountryInfoTests
    {
        [Fact]
        public async Task Feature_CombinedFlagAndWikipediaLink()
        {
            
            var controller = new CountryInfoController(); // données simulées du controller
            var countryName = "France";

            var result = await controller.GetCountryInfo(countryName) as ObjectResult;

            Assert.NotNull(result);
            var data = Assert.IsType<Dictionary<string, string>>(result.Value);
            Assert.Equal("https://en.wikipedia.org/wiki/France", data["WikipediaLink"]);
            Assert.NotNull(data["FlagImage"]);
        }

        [Fact]
        public async Task Feature_FlagDisplay()
        {
            var controller = new FlagController(); // le controller donne des info simulé
            var countryName = "Italy";

            var result = await controller.GetFlag(countryName) as ObjectResult;

            Assert.NotNull(result);
            var flagUrl = Assert.IsType<string>(result.Value);
            Assert.Equal("https://fakeimg.pl/250x100/?text=Flag_of_Italy", flagUrl);
        }
    }
}
