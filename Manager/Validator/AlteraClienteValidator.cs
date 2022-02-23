using Core.ModelViews.Cliente;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Validator
{
    public class AlteraClienteValidator : AbstractValidator<AlteraCliente>
    {
        public AlteraClienteValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty().GreaterThan(0); //Não nulo, não vazio e maior do que 0.
            Include(new NovoClienteValidator()); //Extende todas as validações do Novo Cliente.
        }
    }
}
