using System.ComponentModel.DataAnnotations;
namespace Examen3.Models
{
    public class Categorias
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre Categoria")]
        public string Nombre { get; set; }
    }
}