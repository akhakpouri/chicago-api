﻿using AutoMapper;

namespace Chicago.Bll
{
    public class ChicagoMappingProfile : Profile
    {
        public ChicagoMappingProfile()
        {
            CreateMap<Dal.Models.Item, Dto.Item>()
                .ForMember(destination => destination.TypeValue, opt => opt.MapFrom(source =>
                    source.Type.ToString()))
                .ReverseMap();
            CreateMap<Dal.Models.Networth, Dto.Networth>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(n => n.Items))
                .ReverseMap();
        }
    }
}
