using AutoMapper;
using webapiserver.Domain.Entities;
using webapiserver.Mvc.Dto;

namespace webapiserver.Domain.Profiles
{
    public class PointsProfile : Profile
    {
        public PointsProfile()
        {
            CreateMap<Point, PointReadDto>();

            CreateMap<PointCreateDto, Point>();
        }
    }
}