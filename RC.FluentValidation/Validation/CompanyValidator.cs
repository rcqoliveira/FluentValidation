using FluentValidation;
using RC.FluentValidation.Domains;

namespace RC.FluentValidation.Validation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().MinimumLength(4).MaximumLength(60).WithMessage("Campo nome é obrigatório");
            RuleFor(x => x.DateRegister).Must(CustomValidation.BeValidDate).WithMessage("Informe uma data válida");
        }
    }
}
