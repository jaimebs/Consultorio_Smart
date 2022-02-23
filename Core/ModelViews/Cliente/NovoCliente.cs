using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ModelViews.Cliente
{
    public class NovoCliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
    }
}
