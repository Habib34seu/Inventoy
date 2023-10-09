using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using INV.Domain.Entities.InventoryEntity.BasicEntity;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class CreateUOMCommanHandler : IRequestHandler<CreateUOMCommand, int>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public CreateUOMCommanHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateUOMCommand request, CancellationToken cancellationToken)
        {
            var uom = _mapper.Map<UOMEntity>(request.UOMEntityCreateDto);
            uom = await _uOMRepository.Add(uom);
            return uom.Id;
        }
    }
}
