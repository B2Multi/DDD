using Dominio.Modelos;
using FluentValidation;

namespace Servico.Validacao
{
    public class ContaValidator : AbstractValidator<Conta>
    {
        public ContaValidator()
        {
            RuleFor(c => c.Agencia)
                .NotEmpty().WithMessage("Informe a agência da conta.")
                .NotNull().WithMessage("Informe a agência da conta.");

            RuleFor(c => c.NumeroConta)
                .NotEmpty().WithMessage("Informe o número da conta.")
                .NotNull().WithMessage("Informe o número da conta.");

            RuleFor(c => c.DigitoVerificador)
                .NotEmpty().WithMessage("Por favor, reveja o dígito verificador.")
                .NotNull().WithMessage("Por favor, reveja o dígito verificador.");
        }
    }
}
