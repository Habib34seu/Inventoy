
using AutoMapper;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using INV.Application.UoW;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Queries
{
    public class GetUOMListRequestHandler : IRequestHandler<GetUOMListRequest, List<UOMEntityDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUOMListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<UOMEntityDto>> Handle(GetUOMListRequest request, CancellationToken cancellationToken)
        {
            var uoms = await _unitOfWork.UOMRepository.GetAll();
            return _mapper.Map<List<UOMEntityDto>>(uoms);
        }
    }
}
