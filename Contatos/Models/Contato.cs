using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaContatos.Models
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        public int ContatoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
