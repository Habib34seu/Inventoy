using AutoMapper;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace INV.API.Controllers.INV.InvBasic
{
    [Route("api/[controller]")]
    [ApiController]
    public class UOMController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UOMController( IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<UOMEntityDto>>>GetAllUoms()
        {
            var uoms = await _mediator.Send(new GetUOMListRequest());
            return uoms;
        }
    }
}
