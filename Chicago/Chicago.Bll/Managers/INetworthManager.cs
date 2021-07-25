using System.Threading.Tasks;

namespace Chicago.Bll.Managers
{
    public interface INetworthManager
    {
        Task<double> Calculate();
    }
}
