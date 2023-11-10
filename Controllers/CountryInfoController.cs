using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTestableApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryInfoController : ControllerBase
    {
        [HttpGet("GetCountryInfo/{countryName}")]
        public async Task<IActionResult> GetCountryInfo(string countryName)
        {
            
            await Task.Delay(100);

            var result = new Dictionary<string, string>
            {
                { "FlagImage", $"https://fakeimg.pl/250x100/?text=Flag_of_{countryName}" },
                { "WikipediaLink", $"https://en.wikipedia.org/wiki/{countryName}" }
            };

            return Ok(result);
        }
    }
}
