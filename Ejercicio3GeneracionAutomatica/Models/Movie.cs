using System.ComponentModel.DataAnnotations;

namespace Ejercicio3GeneracionAutomatica.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La fecha de lanzamiento es obligatoria.")]
        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }
    }


}
