using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Response;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands
{
    public class DeleteUOMCommand : IRequest<BaseCommandResponse>
    {
        public UOMEntityDeleteDto UOMEntityDeleteDto { get; set; }
    }
}
