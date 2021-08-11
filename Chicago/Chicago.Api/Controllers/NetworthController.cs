using Chicago.Bll.Dto;
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

        [HttpGet("{id}/calculate")]
        public async Task<IActionResult> Get(int id) => Ok(await _manager.Calculate(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _manager.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _manager.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Save(Networth item) => Ok(await _manager.Save(item));

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) => await _manager.Delete(id).ContinueWith(_ => NoContent());
    }
}
