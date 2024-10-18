using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Biblioteca.Models
{
    public class Autor
    {
        public int AutorID { get; set; }

        [Required(ErrorMessage = "El nombre del autor es obligatorio.")]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
