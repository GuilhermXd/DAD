using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Adm
    {
        String email;
        String senha;
        public Adm(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }
            
        public string Email { get => email; set => email = value; }
        public string Senha
        {
            get => senha; set => senha = value;

        }

        
    }
}
   
