using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using webapiserver.Domain.Entities;
using webapiserver.Domain.Interfaces;
using webapiserver.Mvc.Dto;

namespace webapiserver.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _repository;
        private readonly IMapper _mapper;

        public ItemsController(IItemsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<ItemReadDto>> GetAllItems()
        {
            var items = _repository.GetAll();

            var serializedItems = items
                .Select(x => new Item {
                    Id = x.Id,
                    Image = $"http://localhost:5000/images/{x.Image}",
                    Title = x.Title
                }).ToList();

            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(serializedItems));
        }
    }
}