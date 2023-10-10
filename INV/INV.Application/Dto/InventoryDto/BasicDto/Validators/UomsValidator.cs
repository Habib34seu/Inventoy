using FluentValidation;


namespace INV.Application.Dto.InventoryDto.BasicDto.Validators
{
    public class IUOMEntityDtoValidator : AbstractValidator<IUOMEntityDto>
    {
        public IUOMEntityDtoValidator()
        {
            RuleFor(p => p.UnitName)
               .NotEmpty()
               .WithMessage("{PropertyNane} is required")
               .NotNull()
               .MaximumLength(50)
               .WithMessage("{PropertyNane} must not execute 50 characters");
        }
    }
    public class UOMEntityCreateDtoValidator : AbstractValidator<UOMEntityCreateDto>
    {
        public UOMEntityCreateDtoValidator()
        {
            Include(new IUOMEntityDtoValidator());
        }
    }
    public class UOMEntityUpdateDtoValidator : AbstractValidator<UOMEntityUpdateDto>
    {
        public UOMEntityUpdateDtoValidator()
        {
            Include(new IUOMEntityDtoValidator());

            RuleFor(p => p.Id)
              .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.IsActive)
               .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.UpdatedBy)
               .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.UpdatedDate)
               .NotNull().WithMessage("{PropertyNane} must be present");
        }
    }
    public class UOMEntityDeleteDtoValidator : AbstractValidator<UOMEntityDeleteDto>
    {
        public UOMEntityDeleteDtoValidator()
        {
            RuleFor(p => p.Id)
              .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.IsDelete)
               .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.DeletedBy)
              .NotNull().WithMessage("{PropertyNane} must be present");

            RuleFor(p => p.DeletedDate)
              .NotNull().WithMessage("{PropertyNane} must be present");
        }
    }

    
}
