using INV.Application.Dto.InventoryDto.BasicDto;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands
{
    public class DeleteUOMCommand : IRequest<Unit>
    {
        public UOMEntityDeleteDto UOMEntityDeleteDto { get; set; }
    }
}
