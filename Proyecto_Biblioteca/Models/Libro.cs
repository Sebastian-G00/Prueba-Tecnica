using System.ComponentModel.DataAnnotations;

namespace Proyecto_Biblioteca.Models
{
    public class Libro
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Titulo { get; set; }

        public int AutorID { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
