using Chicago.Dal.Models;
using Daytona;

namespace Chicago.Dal
{
    public class ChicagoUnitOfWork : UnitOfWork<ChicagoDbContext>, IChicagoUnitOfWork
    {
        public IRepository<Item> ItemRepository => new Repository<Item>(Context);

        public ChicagoUnitOfWork(ChicagoDbContext context) : base(context) { }
    }
}
