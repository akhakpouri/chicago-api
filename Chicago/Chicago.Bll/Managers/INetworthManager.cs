using Chicago.Bll.Dto;
using System.Threading.Tasks;

namespace Chicago.Bll.Managers
{
    public interface INetworthManager : IChicagoManager<Networth>
    {
        Task<double> Calculate(int networthId);
    }
}
