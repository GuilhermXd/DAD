using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Negocio;

namespace Dados
{
    public class AdmValidator : AbstractValidator<Adm>

    {
        public AdmValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty().WithMessage("O campo Email é obrigatório.")
                .EmailAddress().WithMessage("O campo Email deve ser um endereço de email válido.");
                

            RuleFor(a => a.Senha)
                .NotEmpty().WithMessage("O campo Senha é obrigatório.")
                .MinimumLength(6).WithMessage("A Senha deve ter pelo menos 6 caracteres.");
        }
    }
}
