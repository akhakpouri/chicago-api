using AutoMapper;

namespace Chicago.Bll
{
    public class ChicagoMappingProfile : Profile
    {
        public ChicagoMappingProfile()
        {
            CreateMap<Dal.Models.Item, Dto.Item>().ReverseMap();
        }
    }
}
