using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "o campo nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "o campo nome deve ter no minímo 3 caracteres e no máximo 100")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo email é obrigatório")]
        [EmailAddress(ErrorMessage = "o campo email é inválido")]
        public string Email { get; set; }
        public char Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoUsuario { get; set; } // ADICIONE ISSO
    }
}
