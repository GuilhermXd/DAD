using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PlantaValidator : AbstractValidator<Planta>
    {
        public PlantaValidator()
        {
            RuleFor(planta => planta.Nomecientifico)
                .NotEmpty().WithMessage("Campo NOME CIENTÍFICO é obrigatório!")
                .Length(3, 100).WithMessage("O NOME CIENTÍFICO deve ter entre 3 e 100 caracteres!");

            RuleFor(planta => planta.Observacoes)
                .MaximumLength(500).WithMessage("As OBSERVAÇÕES não podem exceder 500 caracteres.");

            RuleFor(planta => planta.Datadeverificacao)
                .NotEmpty().WithMessage("Campo DATA DE VERIFICAÇÃO é obrigatório!")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A DATA DE VERIFICAÇÃO não pode ser no futuro.");

            /* RuleFor(planta => planta.Ciclodeagua)
                 .GreaterThan(0).WithMessage("O CICLO DE ÁGUA deve ser um valor positivo.");

             RuleFor(planta => planta.Cicloiluminacao)
                 .GreaterThan(0).WithMessage("O CICLO DE ILUMINAÇÃO deve ser um valor positivo.");*/

            RuleFor(planta => planta.Tiposolo)
                .NotEmpty().WithMessage("Campo TIPO DE SOLO é obrigatório!")
                .Length(3, 50).WithMessage("O TIPO DE SOLO deve ter entre 3 e 50 caracteres!");
        }
    }
}
