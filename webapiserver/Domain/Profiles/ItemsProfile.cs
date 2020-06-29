using AutoMapper;
using webapiserver.Domain.Entities;
using webapiserver.Mvc.Dto;

namespace webapiserver.Domain.Profiles
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            CreateMap<Item, ItemReadDto>()
               .ForMember(dest => dest.Image_url, opt => opt.MapFrom(src => src.Image));
        }
    }
}