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
        public int IdCarro { get; set; }
        public string Status { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }


        public void CalcularDataEntrega(string categoria)
        {
            if (categoria == "Ouro")
                DataDevolucao = DateTime.Now.AddDays(9);

            else if (categoria == "Prata")
                DataDevolucao = DateTime.Now.AddDays(15);

            else if (categoria == "Bronze")
                DataDevolucao = DateTime.Now.AddDays(20);
        }
    }
}