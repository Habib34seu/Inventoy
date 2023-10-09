using INV.Application.Dto.InventoryDto.BasicDto;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands
{
    public class UpdateUOMCommand : IRequest<int>
    {
        public UOMEntityUpdateDto UOMEntityUpdateDto { get; set; }
    }
}
}
