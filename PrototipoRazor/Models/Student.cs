using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrototipoRazor.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o nome do Usuário")]
    [StringLength(80, ErrorMessage = "Nome deve conter até 80 caracteres")]
    [MinLength(5 , ErrorMessage = "Nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiumns { get; set; } = new();
}
