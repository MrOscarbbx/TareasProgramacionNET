using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen3.Models
{
    public class Platillo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre Platillo")]
        public string Nombre { get; set; }
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categorias? Categoria { get; set; }
        public double? Precio { get; set; }
        [Display(Name = "Imagen")]
        public string? UrlImagen { get; set; }
    }
}