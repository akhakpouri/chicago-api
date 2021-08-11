using AutoMapper;
using Chicago.Bll.Dto;
using Chicago.Dal;
using Daytona;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chicago.Bll.Managers
{
    public class NetworthManager : Manager<IChicagoUnitOfWork, Networth>, INetworthManager
    {
        public NetworthManager(IChicagoUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<double> Calculate(int networthId)
        {
            var networth = Mapper.Map<Networth>(await UnitOfWork.NetworthRepoistory.GetById(networthId));
            if (networth is null)
                throw new ArgumentNullException(nameof(networth));

            return networth.Items.Where(i => i.Type == 1).Sum(i => i.Balance) - networth.Items.Where(i => i.Type == 2).Sum(i => i.Balance);
        }

        public override async Task Delete(int id)
        {
            await UnitOfWork.NetworthRepoistory.Delete(id);
            await UnitOfWork.Commit();
        }

        public override async Task<List<Networth>> GetAll()
        {
            return Mapper.Map<List<Networth>>(await UnitOfWork.NetworthRepoistory.FilterBy(n => true).ToListAsync());
        }

        public override async Task<Networth> GetById(int id)
        {
            return Mapper.Map<Networth>(await UnitOfWork.NetworthRepoistory.GetById(id));
        }

        public override async Task<int> Save(Networth dto)
        {
            var entity = dto.Id > 0 ? Mapper.Map(dto, await UnitOfWork.NetworthRepoistory.GetById(dto.Id)) : Mapper.Map<Dal.Models.Networth>(dto);
            UnitOfWork.NetworthRepoistory.Save(entity);
            await UnitOfWork.Commit();
            return entity.Id;
        }
    }
}
