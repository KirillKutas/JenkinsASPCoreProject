using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace JenkinsASPCoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAppSettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TestAppSettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAppSettingsValue")]
        public string GetAppSettingsValue()
        {
            return _configuration["TestAppSettings"];
        }
    }
}
