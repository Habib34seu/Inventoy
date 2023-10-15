using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Application.Dto.InventoryDto.BasicDto.Validators;
using INV.Application.Exceptions;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using INV.Application.Response;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class DeleteUOMCommandHandler : IRequestHandler<DeleteUOMCommand, BaseCommandResponse>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public DeleteUOMCommandHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteUOMCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new UOMEntityDeleteDtoValidator();
            var validationResult = await validator.ValidateAsync(request.UOMEntityDeleteDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            
            var uom = await _uOMRepository.Get(request.UOMEntityDeleteDto.Id);

            if (uom == null)
                throw new NotFoundException(nameof(UOMEntityDeleteDto), request.UOMEntityDeleteDto.Id);

            _mapper.Map(request.UOMEntityDeleteDto, uom);
            await _uOMRepository.Update(uom);

            response.Success = true;
            response.Message = "Unit Successfully Delete";
            response.Id = uom.Id;
            return response;
        }
    }
}
