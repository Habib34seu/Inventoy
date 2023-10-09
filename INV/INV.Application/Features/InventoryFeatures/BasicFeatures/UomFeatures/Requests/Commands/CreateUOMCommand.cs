
using INV.Application.Dto.InventoryDto.BasicDto;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands
{
    public class CreateUOMCommand : IRequest<int>
    {
        public UOMEntityCreateDto UOMEntityCreateDto { get; set; }
    }
}
