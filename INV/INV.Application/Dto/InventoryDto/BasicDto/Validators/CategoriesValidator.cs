
using FluentValidation;

namespace INV.Application.Dto.InventoryDto.BasicDto.Validators
{
    public class CategoryEntityCreateDtoValidator : AbstractValidator<CategoryEntityCreateDto>
    {
        public CategoryEntityCreateDtoValidator()
        {
            RuleFor(p => p.CategoryName)
                .NotEmpty()
                .WithMessage("{PropertyNane} is required")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyNane} must not execute 50 characters");
        }
    }
    public class CategoryEntityUpdateDtoValidator : AbstractValidator<CategoryEntityUpdateDto>
    {
        public CategoryEntityUpdateDtoValidator()
        {
            RuleFor(p => p.CategoryName)
                .NotEmpty()
                .WithMessage("{PropertyNane} is required")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyNane} must not execute 50 characters");

            RuleFor(p => p.IsActive)
               .NotEmpty();

            RuleFor(p => p.UpdatedBy)
               .NotEmpty();

            RuleFor(p => p.UpdatedDate)
               .NotEmpty();
        }
    }
    public class CategoryEntityDeleteDtoValidator : AbstractValidator<CategoryEntityDeleteDto>
    {
        public CategoryEntityDeleteDtoValidator()
        {

        }
    }
}
