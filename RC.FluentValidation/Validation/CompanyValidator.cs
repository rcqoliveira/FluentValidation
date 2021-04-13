using FluentValidation;
using RC.FluentValidation.Domains;

namespace RC.FluentValidation.Validation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().MinimumLength(4).MaximumLength(60).WithMessage("name field is riquired!");
            RuleFor(x => x.DateRegister).Must(CustomValidation.BeValidDate).WithMessage("datetime field is riquired!");
        }
    }
}
