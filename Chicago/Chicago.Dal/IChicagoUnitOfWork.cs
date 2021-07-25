using Chicago.Dal.Models;
using Daytona;

namespace Chicago.Dal
{
    public interface IChicagoUnitOfWork : IUnitOfWork<ChicagoDbContext>
    {
        IRepository<Item> ItemRepository { get; }
    }
}
