using Chicago.Dal;
using Daytona;
using Daytona.Dto;

namespace Chicago.Bll
{
    public interface IChicagoManager<TDto> : IManager<IChicagoUnitOfWork, TDto> 
        where TDto : BaseDto
    {
    }
}
