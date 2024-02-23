using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Nome não pode ter mais do que 100 caracteres.")]
        public string Nome { get; set; } = null!;

        [Required]
        [Range(1, 100, ErrorMessage = "Idade tem que ser entre 1 e 100")]
        public int Idade { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O campo deve ter o formato xxxxxxxxxxx@gmail.com")]
        public string Email { get; set; } = null!;
    }
}
