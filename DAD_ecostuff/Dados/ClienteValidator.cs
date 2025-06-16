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
        public ClienteValidator()
        {
            RuleFor(cliente => cliente.Nome)
                .NotEmpty().WithMessage("Campo NOME é obrigatório!")
                .Length(3, 50).WithMessage("Tamanho do campo NOME não pode estar vazio");

            RuleFor(cliente => cliente.Email)
                .NotEmpty().WithMessage("Campo EMAIL é obrigatório!")
                .EmailAddress().WithMessage("Um email válido é requerido!");

            RuleFor(cliente => cliente.Cpf_Cnpj)
     .NotEmpty().WithMessage("Campo CPF/CNPJ é obrigatório!")
     .Must(cpfCnpj =>
     {
         cpfCnpj = cpfCnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

         if (cpfCnpj.Length == 11)
             return ValidacaoDocumentos.ValidarCpf(cpfCnpj);
         else if (cpfCnpj.Length == 14)
             return ValidacaoDocumentos.ValidarCnpj(cpfCnpj);
         else
             return false;
     }).WithMessage("CPF ou CNPJ inválido!");

            RuleFor(cliente => cliente.Rg)
    .NotEmpty().WithMessage("Campo RG é obrigatório!")
    .Length(7, 12).WithMessage("Tamanho do campo RG deve estar entre 7 e 12 caracteres!")
    .Must(rg =>
    {
        // Remove formatação
        var rgLimpo = rg.Trim().Replace(".", "").Replace("-", "");

        // Verifica se não são todos dígitos iguais
        return rgLimpo.Distinct().Count() > 1;
    }).WithMessage("RG não pode ter todos os dígitos iguais!")
    .Must(rg => ValidacaoDocumentos.ValidarRg(rg)).WithMessage("RG inválido!");


            RuleFor(cliente => cliente.Celular)
                .NotEmpty().WithMessage("Campo CELULAR é obrigatório!");
                

            RuleFor(cliente => cliente.Senha)
                .NotEmpty().WithMessage("Campo SENHA é obrigatório!")
                .Length(6, 20).WithMessage("A SENHA deve ter entre 6 e 20 caracteres!");
        }
    }
    public static class ValidacaoDocumentos
    {
        public static bool ValidarCpf(string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            // Verifica se todos os dígitos são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Calcula primeiro dígito verificador
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Calcula segundo dígito verificador
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            // Verifica se os dígitos calculados conferem com os informados
            return cpf.EndsWith(digito1.ToString() + digito2.ToString());
        }

        public static bool ValidarCnpj(string cnpj)
        {
            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
                return false;

            // Verifica se todos os dígitos são iguais
            if (cnpj.Distinct().Count() == 1)
                return false;

            // Calcula primeiro dígito verificador
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Calcula segundo dígito verificador
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            // Verifica se os dígitos calculados conferem com os informados
            return cnpj.EndsWith(digito1.ToString() + digito2.ToString());
        }

        public static bool ValidarRg(string rg)
        {
            rg = rg.Trim().Replace(".", "").Replace("-", "");

            // Verifica se tem entre 7 e 12 dígitos e se são todos números
            if (rg.Length < 7 || rg.Length > 12 || !rg.All(char.IsDigit))
                return false;

            // Verifica se todos os dígitos são iguais (ex: 1111111, 22222222, etc.)
            if (rg.Distinct().Count() == 1)
                return false;

            // Aqui você pode adicionar validações específicas por estado se necessário
            return true;
        }
    }
}


