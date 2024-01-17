using Microsoft.AspNetCore.Mvc;
using ServiceAbstraction;

namespace TMS.Controllers
{
    [Route("api/[controller]/[action]/")]
    public class HomeController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public HomeController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _serviceManager.UserService.GetAllAsync();
            return Ok(response);
        }
    }
}
