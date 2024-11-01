using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;




namespace Dados
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator() {
            RuleFor(cliente => cliente.Nome)
                .NotEmpty().WithMessage("Campo NOME é obrigatório!")
                .Length(3, 50).WithMessage("Tamanho do campo NOME não pode estar vazio");

            RuleFor(cliente => cliente.Email)
                .NotEmpty().WithMessage("Campo EMAIL é obrigatório!")
                .EmailAddress().WithMessage("Um email válido é requerido!");

            RuleFor(cliente => cliente.Cpf_Cnpj)
                .NotEmpty().WithMessage("Campo CPF/CNPJ é obrigatório!")
                .Matches(@"^\d{11}$|^\d{14}$").WithMessage("O CPF deve ter 11 dígitos ou o CNPJ 14 dígitos.");

            RuleFor(cliente => cliente.Rg)
                .NotEmpty().WithMessage("Campo RG é obrigatório!")
                .Length(7, 12).WithMessage("Tamanho do campo RG deve estar entre 7 e 12 caracteres!");

            RuleFor(cliente => cliente.Celular)
                .NotEmpty().WithMessage("Campo CELULAR é obrigatório!")
                .Matches(@"^\(\d{2}\) \d{5}-\d{4}$").WithMessage("O celular deve estar no formato (XX) XXXXX-XXXX.");

            RuleFor(cliente => cliente.Senha)
                .NotEmpty().WithMessage("Campo SENHA é obrigatório!")
                .Length(6, 20).WithMessage("A SENHA deve ter entre 6 e 20 caracteres!");
        }
    }
 }

