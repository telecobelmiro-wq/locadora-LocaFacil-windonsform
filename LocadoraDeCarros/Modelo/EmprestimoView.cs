using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class EmprestimoView
    {
            
            public int Id { get; set; }
            public string NomeCliente { get; set; }
            public string NomeCarro { get; set; }
            public string Status { get; set; }
            public DateTime DataRetirada { get; set; }
            public DateTime DataDevolucao { get; set; }
        
    }
}
