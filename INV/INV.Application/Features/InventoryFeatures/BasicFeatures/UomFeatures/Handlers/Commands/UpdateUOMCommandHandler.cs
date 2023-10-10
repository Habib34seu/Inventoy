using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class UpdateUOMCommandHandler : IRequestHandler<UpdateUOMCommand, Unit>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public UpdateUOMCommandHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateUOMCommand request, CancellationToken cancellationToken)
        {
           var uom = await _uOMRepository.Get(request.UOMEntityUpdateDto.Id);
           _mapper.Map(request.UOMEntityUpdateDto, uom);
            await _uOMRepository.Update(uom);
            return Unit.Value;

        }

       
    }
}
