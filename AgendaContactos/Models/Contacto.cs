using System.ComponentModel.DataAnnotations;

namespace AgendaContactos.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Display(Name = "Teléfono Fijo")]
        public string Telefono { get; set; }

        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
