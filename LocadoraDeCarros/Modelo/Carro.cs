using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public int Ano { get; set; }
        public string Categoria { get; set; }

        
    }
}
