
using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Queries
{
    public class GetUOMListRequestHandler : IRequestHandler<GetUOMListRequest, List<UOMEntityDto>>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public GetUOMListRequestHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<List<UOMEntityDto>> Handle(GetUOMListRequest request, CancellationToken cancellationToken)
        {
            var uoms = await _uOMRepository.GetAll();
            return _mapper.Map<List<UOMEntityDto>>(uoms);
        }
    }
}
