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
    public class UpdateUOMCommandHandler : IRequestHandler<UpdateUOMCommand, BaseCommandResponse>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public UpdateUOMCommandHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(UpdateUOMCommand request, CancellationToken cancellationToken)
        {
            var response  = new BaseCommandResponse();
            var validator = new UOMEntityUpdateDtoValidator();
            var validationResult = await validator.ValidateAsync(request.UOMEntityUpdateDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var uom = await _uOMRepository.Get(request.UOMEntityUpdateDto.Id);
            if (uom == null)
                throw new NotFoundException(nameof(UOMEntityUpdateDto), request.UOMEntityUpdateDto.Id);

            _mapper.Map(request.UOMEntityUpdateDto, uom);
            await _uOMRepository.Update(uom);

            response.Success = true;
            response.Message = "Unit Successfully Saved";
            response.Id = uom.Id;
            return response;

        }

       
    }
}
