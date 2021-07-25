using Chicago.Bll;
using Chicago.Bll.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chicago.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        readonly IChicagoManager<Item> _manager;

        public ItemsController(IChicagoManager<Item> manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _manager.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _manager.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Save(Item item) => Ok(await _manager.Save(item));

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) => await _manager.Delete(id).ContinueWith(_ => NoContent());
    }
}
