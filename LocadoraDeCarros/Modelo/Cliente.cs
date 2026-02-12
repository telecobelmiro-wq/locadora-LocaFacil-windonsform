using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
