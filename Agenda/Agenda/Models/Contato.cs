using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Celular { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}