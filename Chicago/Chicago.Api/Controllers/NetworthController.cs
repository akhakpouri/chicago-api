using Chicago.Bll.Managers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chicago.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NetworthController : ControllerBase
    {
        readonly INetworthManager _manager;

        public NetworthController(INetworthManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _manager.Calculate());
    }
}
