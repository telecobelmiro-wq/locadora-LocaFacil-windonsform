using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class Emprestimos
    {
            public string Cliente { get; set; }
            public string Carro { get; set; }
            public DateTime DataRetirada { get; set; }
            public DateTime DataDevolucao { get; set; }
            public string Status { get; set; }
    }
}
