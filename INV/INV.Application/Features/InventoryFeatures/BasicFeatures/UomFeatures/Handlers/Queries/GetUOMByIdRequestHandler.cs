using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using INV.Application.UoW;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Queries
{
    public class GetUOMByIdRequestHandler : IRequestHandler<GetUOMByIdRequest, UOMEntityDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public GetUOMByIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UOMEntityDto> Handle(GetUOMByIdRequest request, CancellationToken cancellationToken)
        {
            var uom = await _unitOfWork.UOMRepository.Get(request.Id);
            return _mapper.Map<UOMEntityDto>(uom);
        }
    }
}
