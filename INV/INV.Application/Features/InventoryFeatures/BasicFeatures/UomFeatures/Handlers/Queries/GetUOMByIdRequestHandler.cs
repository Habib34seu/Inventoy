using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Queries
{
    public class GetUOMByIdRequestHandler : IRequestHandler<GetUOMByIdRequest, UOMEntityDto>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public GetUOMByIdRequestHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<UOMEntityDto> Handle(GetUOMByIdRequest request, CancellationToken cancellationToken)
        {
            var uom = await _uOMRepository.Get(request.Id);
            return _mapper.Map<UOMEntityDto>(uom);
        }
    }
}
