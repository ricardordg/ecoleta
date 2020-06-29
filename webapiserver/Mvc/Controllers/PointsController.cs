using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webapiserver.Domain.Entities;
using webapiserver.Domain.Interfaces;
using webapiserver.Mvc.Dto;

namespace webapiserver.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsController : ControllerBase
    {
        private readonly IPointItemsRepository _pointItemsRepository;
        private readonly IPointsRepository _repository;
        private readonly IMapper _mapper;

        public PointsController(
            IPointsRepository repository, 
            IPointItemsRepository pointItemsRepository,
            IMapper mapper
        )
        {
            _pointItemsRepository = pointItemsRepository;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<PointReadDto>> GetAllPoints()
        {
            var points = _repository.GetAll();

            return Ok(_mapper.Map<IEnumerable<PointReadDto>>(points));
        }

        [HttpGet("{id}", Name="GetPointById")]
        public ActionResult <PointReadDto> GetPointById(int id)
        {
            var point = _repository.Get(id);

            if(point != null)
                return Ok(_mapper.Map<PointReadDto>(point));
            
            return NotFound();
        }
        
        [HttpPost]
        public ActionResult <PointCreateDto> CreatePoint(PointCreateDto pointCreateDto)
        {
            var pointModel = _mapper.Map<Point>(pointCreateDto);
            _repository.Add(pointModel);
            _repository.SaveChanges();

            if (pointCreateDto.Items != null)
            {
                var pointItems = new List<PointItem>();
                foreach(var id in pointCreateDto.Items)
                {
                    pointItems.Add(new PointItem {
                        Point = pointModel,
                        ItemId = id
                    });
                }

                if (pointItems.Count > 0)
                {
                    _pointItemsRepository.AddRange(pointItems);
                    _pointItemsRepository.SaveChanges();
                }
            }
            
            var pointReadDto = _mapper.Map<PointReadDto>(pointModel);

            return CreatedAtRoute(nameof(GetPointById), new {Id = pointReadDto.Id}, pointReadDto);
        }
    }
}