using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class DeleteUOMCommandHandler : IRequestHandler<DeleteUOMCommand, Unit>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public DeleteUOMCommandHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteUOMCommand request, CancellationToken cancellationToken)
        {
            var uom = await _uOMRepository.Get(request.UOMEntityDeleteDto.Id);
            _mapper.Map(request.UOMEntityDeleteDto, uom);
            await _uOMRepository.Update(uom);
            return Unit.Value;
        }
    }
}
