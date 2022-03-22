using System.ComponentModel.DataAnnotations;

namespace ListaDeContatos1.Models
{
    public class ContatoModel
    {
        [Key]
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
