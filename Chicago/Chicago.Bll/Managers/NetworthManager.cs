using Chicago.Bll.Dto;
using System.Linq;
using System.Threading.Tasks;

namespace Chicago.Bll.Managers
{
    public class NetworthManager : INetworthManager
    {
        readonly IChicagoManager<Item> _itemManager;

        public NetworthManager(IChicagoManager<Item> itemManager)
        {
            _itemManager = itemManager;
        }

        public async Task<double> Calculate()
        {
            var items = (await _itemManager.GetAll());

            return items.Where(i => i.Type == 1).Sum(i => i.Balance) -
                items.Where(i => i.Type == 2).Sum(i => i.Balance);

        }
    }
}
