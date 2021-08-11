using Chicago.Dal.Models;
using Daytona;

namespace Chicago.Dal
{
    public class ChicagoUnitOfWork : UnitOfWork<ChicagoDbContext>, IChicagoUnitOfWork
    {
        public IRepository<Item> ItemRepository => new Repository<Item>(Context);

        public IRepository<NetworthItems> NetworthItemsRepository => new Repository<NetworthItems>(Context);
        public IRepository<Networth> NetworthRepoistory => new Repository<Networth>(Context);
        public ChicagoUnitOfWork(ChicagoDbContext context) : base(context) { }
    }
}
