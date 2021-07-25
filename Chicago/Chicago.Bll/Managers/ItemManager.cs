using AutoMapper;
using Chicago.Bll.Dto;
using Chicago.Dal;
using Daytona;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chicago.Bll.Managers
{
    public class ItemManager : Manager<IChicagoUnitOfWork, Item>, IChicagoManager<Item>
    {
        public ItemManager(IChicagoUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public override async Task Delete(int id)
        {
            await UnitOfWork.ItemRepository.Delete(id);
            await UnitOfWork.Commit();
        }

        public override async Task<List<Item>> GetAll()
        {
            return Mapper.Map<List<Item>>(await UnitOfWork.ItemRepository.FilterBy(x => true).ToListAsync());
        }

        public override async Task<Item> GetById(int id)
        {
            return Mapper.Map<Item>(await UnitOfWork.ItemRepository.GetById(id));
        }

        public override async Task<int> Save(Item dto)
        {
            var entity = dto.Id > 0 ? Mapper.Map(dto, await UnitOfWork.ItemRepository.GetById(dto.Id)) : Mapper.Map<Dal.Models.Item>(dto);
            UnitOfWork.ItemRepository.Save(entity);
            await UnitOfWork.Commit();
            return entity.Id;
        }
    }
}
