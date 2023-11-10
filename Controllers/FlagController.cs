using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MyTestableApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlagController : ControllerBase
    {
        [HttpGet("GetFlag/{countryName}")]
        public async Task<IActionResult> GetFlag(string countryName)
        {
            // c'est pour faire une simulation asynchrone ça 
            await Task.Delay(100);

            var flagUrl = $"https://fakeimg.pl/250x100/?text=Flag_of_{countryName}";
            return Ok(flagUrl);
        }
    }
}
