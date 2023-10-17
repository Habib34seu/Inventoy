using AutoMapper;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.Dto.InventoryDto.BasicDto.Validators;
using INV.Application.Exceptions;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Commands;
using INV.Application.Response;
using INV.Application.UoW;
using INV.Domain.Entities.InventoryEntity.BasicEntity;
using MediatR;

namespace INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Handlers.Commands
{
    public class CreateUOMCommanHandler : IRequestHandler<CreateUOMCommand, BaseCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUOMCommanHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
        public async Task<BaseCommandResponse> Handle(CreateUOMCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new UOMEntityCreateDtoValidator();
            var validationResult = await validator.ValidateAsync(request.UOMEntityCreateDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult); 

            var uom = _mapper.Map<UOMEntity>(request.UOMEntityCreateDto);
            uom = await _unitOfWork.UOMRepository.Add(uom);
            await _unitOfWork.Save();

            response.Success = true;
            response.Message = "Unit Successfully Saved";
            response.Id = uom.Id;
            return response;
        }
    }
}
