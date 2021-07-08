using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5Crud.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El título es obligatorio")]
        [StringLength(50,ErrorMessage ="El {0} deve ser al menos  {2} y máximo {1} caracteres,", MinimumLength = 3)]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripción es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} deve ser al menos  {2} y máximo {1} caracteres,", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DataType FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public int Precio { get; set; }
    }
}
