
using INV.Application.Dto.InventoryDto.BasicDto;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries
{
    public class GetUOMListRequest : IRequest<List<UOMEntityDto>>
    {
    }
}
