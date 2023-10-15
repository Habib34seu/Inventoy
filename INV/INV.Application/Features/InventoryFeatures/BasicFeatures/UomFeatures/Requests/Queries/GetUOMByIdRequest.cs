
using INV.Application.Dto.InventoryDto.BasicDto;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries
{
    public class GetUOMByIdRequest : IRequest<UOMEntityDto>
    {
        public int Id { get; set; }
    }
}
