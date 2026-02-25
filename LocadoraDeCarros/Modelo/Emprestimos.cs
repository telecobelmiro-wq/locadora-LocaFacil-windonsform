using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class Emprestimos
    {
            public int Id { get; set; }
            public int IdCliente { get; set; }
            public int IdVeiculos{ get; set; }
            public string Status { get; set; }
            public decimal ValorTotal { get; set; }
            public DateTime DataRetirada { get; set; }
            public DateTime DataDevolucao { get; set; }
        
    }
}
