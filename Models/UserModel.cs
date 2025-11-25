using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class UserModel 
    {
        public int Id { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression(@"^[a-zA-ZÀúÃ\s]+$", ErrorMessage = "O {0} deve conter apenas letras e espaços.")]
        public string Nome { get; set; }

        [Display(Name = "Idade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(0, 100, ErrorMessage = "A {0} deve estar entre {1} e {2} anos.")]
        public int Idade { get; set; }

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(500, ErrorMessage = "A {0} deve ter no máximo {1} caracteres.")]
        [MinLength(5, ErrorMessage = "A {0} deve ter pelo menos {1} caracteres.")]
        public string Mensagem { get; set; }

        public UserModel()
        {
            Nome = string.Empty;
            Mensagem = string.Empty;
        }
    }
}