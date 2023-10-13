using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto.Validators;
using INV.Application.Exceptions;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using INV.Application.Response;
using INV.Domain.Entities.InventoryEntity.BasicEntity;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class CreateUOMCommanHandler : IRequestHandler<CreateUOMCommand, BaseCommandResponse>
    {
        private readonly IUOMRepository _uOMRepository;
        private readonly IMapper _mapper;

        public CreateUOMCommanHandler(IUOMRepository uOMRepository, IMapper mapper)
        {
            _uOMRepository = uOMRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateUOMCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new UOMEntityCreateDtoValidator();
            var validationResult = await validator.ValidateAsync(request.UOMEntityCreateDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult); 

            var uom = _mapper.Map<UOMEntity>(request.UOMEntityCreateDto);
            uom = await _uOMRepository.Add(uom);

            response.Success = true;
            response.Message = "Unit Successfully Saved";
            response.Id = uom.Id;
            return response;
        }
    }
}
